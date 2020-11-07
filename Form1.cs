using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace checkNetFramework
{
    public partial class Form1 : Form
    {
        bool firstIn = true;
        bool counter = false;
        string text = "";
        int len = 0;
        int initialLen = 0;
        string OutPutText = "";

        //CODE FOR FORM MOVABLE
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            text = checkText.Text;
            len = text.Length;
            initialLen = len+3;
            timer1.Start();          
            
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.DoEvents();
            timer1.Interval = 500; //espera 1 segundo
            text = len < initialLen ? text + "." : text.Substring(0, len - 3);
            len = text.Length;
            checkText.Text = text;

            if(counter)
            {
                checkText.Hide();
                timer1.Stop();
            }

            if (firstIn)
            {                
                firstIn = false;
                System.Windows.Forms.Application.DoEvents();
                Task.Factory.StartNew(() =>
                {
                    Thread.Sleep(5000);
                    //Executa pelo registro
                    try
                    {
                        OutPutText = getFrameworks.MainExec();
                    }
                    catch (Exception)
                    {
                        //continue
                    }
                    
                    this.Invoke((MethodInvoker)delegate
                    {
                        AppendText(OutPutText);
                        text = "Verificando no cmd";
                        len = text.Length;
                        initialLen = len + 3;        

                    });
                    //realiza chamada da função sem interromper as ações na UI
                    Thread.Sleep(1000);
                    CmdInitiate();

                });
                
            }

        }

        private  void CmdInitiate()
        {
            
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            //cmd.StartInfo.FileName = "powershell.exe";
            //cmd.StartInfo.Arguments = @"/c dir \windows";
            //cmd.StartInfo.Arguments = "wmic product get description | findstr /C:.NET";
            string command = @"/c wmic product where ""Name like '%Net Framework%'"" get Name, Version";
            cmd.StartInfo.Arguments = command;
            //OutPutText += command + "\n";
            
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.RedirectStandardError = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.RedirectStandardInput = false;

            cmd.StartInfo.UseShellExecute = false;
            cmd.EnableRaisingEvents = true;

            //cmd.OutputDataReceived += (a, b) => {
            //    Debug.WriteLine(b.Data);               

            //};

            cmd.OutputDataReceived += (a, b) =>
            {

                OutPutText += $"{b.Data} \n";
                Console.WriteLine(b.Data);
            };
            cmd.ErrorDataReceived += (a, b) =>
            {

                OutPutText += $"{b.Data} \n";
                Console.WriteLine(b.Data);

            };
            //ao finalizar erro
            cmd.Exited += (a, b) =>
            {
                counter = true;
            };

            //cmd.StartInfo.Arguments = "wmic product where \"Name like 'Microsoft .Net Framework%'\" get Name, Version";
            cmd.Start();
           // cmd.BeginErrorReadLine();
            cmd.BeginOutputReadLine();
            //string output = cmd.StandardOutput.ReadToEnd();
            cmd.WaitForExit();


            if (cmd.HasExited)
            {
                // MethodInvoker e BeginInvoke utilizado para que o método AppendText seja chamado utilizando a Thread Principal
                this.Invoke((MethodInvoker)delegate
                {
                    AppendText(OutPutText);
                });

                //MethodInvoker mi = new MethodInvoker(this.AppendText);
                //this.BeginInvoke(mi);
                
            }

        }

        public void AppendText(string val)
        {
            richTextResult.AppendText(val);
        }
    }
}
