using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        string path = null;
        string gitLog = "";//전역변수로 설정하여 프로그램 전역에서 활용가능하도록 지정
        string resultstate = "";
        public Form1()
        {
            ProcessStartInfo cmd = new ProcessStartInfo();
            Process process = new Process();
            cmd.FileName = @"cmd";
            cmd.WindowStyle = ProcessWindowStyle.Hidden;             // cmd창이 숨겨지도록 하기
            cmd.CreateNoWindow = true;                               // cmd창을 띄우지 안도록 하기

            cmd.UseShellExecute = false;
            cmd.RedirectStandardOutput = true;        // cmd창에서 데이터를 가져오기
            cmd.RedirectStandardInput = true;          // cmd창으로 데이터 보내기
            cmd.RedirectStandardError = true;        // cmd창에서 오류 내용 가져오기
            label1.Text = "반갑습니다!!";
            InitializeComponent();
        }
        /// <summary>
        /// cmd 명령 실행 전용함수
        /// </summary>
        /// <param name="sender"></param>

        /// <param name="e"></param>
        
        public void cmdCommand(string command,int otion,EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo pri = new System.Diagnostics.ProcessStartInfo();
            System.Diagnostics.Process pro = new System.Diagnostics.Process();

            pri.FileName = "cmd.exe";
            pri.CreateNoWindow = false;//새창을 띄우실것인가??
            pri.UseShellExecute = false;//새창에서 실행할것인가??

            pri.RedirectStandardInput = true;
            pri.RedirectStandardOutput = true;
            pri.RedirectStandardError = true;

            pro.StartInfo = pri;
            pro.Start();
            //명령어 실행

            pro.StandardInput.Write(@command+ Environment.NewLine);
            pro.StandardInput.Close();
            switch (otion)
            {
                case 0: //log
                    string resultValue = pro.StandardOutput.ReadToEnd();
                    break;
                case 1://commit
                    string resultstate = pro.StandardOutput.ReadToEnd();
                    break;


            }
            pro.WaitForExit();
            pro.Close();            

        }
        private void 폴더열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //folderBrowserDialog1;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                if (path == null)
                {
                    path = folderBrowserDialog1.SelectedPath;//파일 경로 저장
                }
                else
                {

                }
            }
        }
        private void 종료XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 깃로그ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 gitlog = new Form2(gitLog);
            //Form2
        }

        private void 코드실행VToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo cmd = new ProcessStartInfo();
            Process process = new Process();
            cmd.FileName = @"cmd";
            cmd.WindowStyle = ProcessWindowStyle.Hidden;             // cmd창이 숨겨지도록 하기
            cmd.CreateNoWindow = true;                               // cmd창을 띄우지 안도록 하기

            cmd.UseShellExecute = false;
            cmd.RedirectStandardOutput = true;        // cmd창에서 데이터를 가져오기
            cmd.RedirectStandardInput = true;          // cmd창으로 데이터 보내기
            cmd.RedirectStandardError = true;        // cmd창에서 오류 내용 가져오기
 
            if (path == null)
            {
                string command = "code .";
                Process.Start("cmd.exe", command);
            }
            else
            { 
                string command = "code "+path;
                Process.Start("cmd.exe", command);
            }
            //System
        }
    }
}
