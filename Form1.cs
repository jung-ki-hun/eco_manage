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
            InitializeComponent();
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
