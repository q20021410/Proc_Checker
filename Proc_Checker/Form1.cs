using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection;

namespace Proc_Checker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Process Checker (V" + Assembly.GetExecutingAssembly().GetName().Version.ToString() + ")";
        }

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]

        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal,
         int size, string filePath);
        public static int count = 1;
        public static string statchk = "Start";
        public static string ntime = "";
        public static string crlf = System.Environment.NewLine;

        private void Getnowtime_Tick(object sender, EventArgs e)
        {
            nowtime.Text = DateTime.Now.ToString("yyyy년 MM월 dd일 tt hh:mm:ss");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            filepath.Clear();
            //String file_path = null;
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Title = "실행 파일 선택";
            openFileDialog1.FileName = "OhysCrawler.exe";
            openFileDialog1.Filter = "실행 파일 (*.exe) | *.exe; | 모든 파일 (*.*) | *.*";

            //openFileDialog의 시작 위치를 C:\\ 로 설정      
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filepath.Text = openFileDialog1.FileName;

                //선택된 파일의 풀 경로를 불러와 저장
                //filepath.Text = file_path.Split('\\')[file_path.Split('\\').Length - 1];
                //해당 경로에서 파일명만 추출하여 textBox1에 표시
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WritePrivateProfileString("Proc_Checker", "run_path", filepath.Text, Application.StartupPath + @"\Config.ini");
            WritePrivateProfileString("Proc_Checker", "runtime", rnt.Text, Application.StartupPath + @"\Config.ini");
            WritePrivateProfileString("Proc_Checker", "procname", Proc_name.Text, Application.StartupPath + @"\Config.ini");

            StringBuilder run_path = new StringBuilder();
            StringBuilder run_time = new StringBuilder();
            StringBuilder run_proc = new StringBuilder();

            Proccheck.Enabled = false;
            Proccheck.Interval = Convert.ToInt32(rnt.Text) * 60000;
            Proccheck.Enabled = true;
            timer1.Enabled = true;
            label6.Text = Convert.ToString(Convert.ToInt32(rnt.Text) * 60);
            ntime = Convert.ToString(Convert.ToInt32(rnt.Text) * 60);

            ListViewItem item;
            count += 1;
            item = new ListViewItem(count.ToString());
            item.SubItems.Add(DateTime.Now.ToString("yyyy년 MM월 dd일 tt hh:mm:ss"));
            item.SubItems.Add("Changed");
            Logview.Items.Add(item);
            Logview.EnsureVisible(Logview.Items.Count - 1);


        }

        private void Rtime(object sender, KeyPressEventArgs e)
        {
            //숫자만 입력되도록 필터링
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back))) //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StringBuilder retpath = new StringBuilder();
            StringBuilder rettime = new StringBuilder();
            StringBuilder retproc = new StringBuilder();

            //("Form1", "run_path", "test", Application.StartupPath + @"\Config.ini");
            GetPrivateProfileString("Proc_Checker", "run_path", "", retpath, 128, Application.StartupPath + @"\Config.ini");
            GetPrivateProfileString("Proc_Checker", "runtime", "", rettime, 32, Application.StartupPath + @"\Config.ini");
            GetPrivateProfileString("Proc_Checker", "procname", "", retproc, 32, Application.StartupPath + @"\Config.ini");

            filepath.Text = retpath.ToString();
            rnt.Text = rettime.ToString();
            Proc_name.Text = retproc.ToString();

            if (rnt.Text.Length <= 0)
            {
                ntime = "";
                timer1.Enabled = false;
                Proccheck.Enabled = false;
            }
            else
            {
                ntime = Convert.ToString(Convert.ToInt32(rnt.Text) * 60);
                timer1.Enabled = true;
            }

            label6.Text = "다음 실행까지: " + ntime + "초";
            //label6.Text = Convert.ToString(Convert.ToInt32(rnt.Text) * 60) + "초";


            if (rnt.Text.Length > 0)
            {
                Proccheck.Interval = Convert.ToInt32(rnt.Text) * 60000;
                Proccheck.Enabled = true;
            }
            else
            {
                Proccheck.Interval = 10 * 60000;
            }

            ListViewItem item;

            item = new ListViewItem(count.ToString());
            item.SubItems.Add(DateTime.Now.ToString("yyyy년 MM월 dd일 tt hh:mm:ss"));
            item.SubItems.Add(statchk);
            Logview.Items.Add(item);
            Logview.EnsureVisible(Logview.Items.Count - 1);

        }

        private void Proccheck_Tick(object sender, EventArgs e)
        {
            StringBuilder retpath = new StringBuilder();
            GetPrivateProfileString("Proc_Checker", "run_path", "", retpath, 128, Application.StartupPath + @"\Config.ini");

            if (retpath.ToString().Length <= 0)
            {
                MessageBox.Show("실행할 프로그램 경로가 지정되어 있지 않습니다."+crlf + "경로를 확인 해 주세요.", "[오류] 실행팔 프로그램이 지정 되어 있지 않습니다.", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                Process[] processList = Process.GetProcessesByName(Proc_name.Text);
                ListViewItem item;
                count += 1;
                if (processList.Length < 1)
                {
                    Process.Start(filepath.Text);
                    statchk = "Proc start";
                    ntime = Convert.ToString(Convert.ToInt32(rnt.Text) * 60);
                }
                else
                {
                    statchk = "Okay";
                    ntime = Convert.ToString(Convert.ToInt32(rnt.Text) * 60);
                }

                item = new ListViewItem(count.ToString());
                item.SubItems.Add(DateTime.Now.ToString("yyyy년 MM월 dd일 tt hh:mm:ss"));
                item.SubItems.Add(statchk);
                Logview.Items.Add(item);
                Logview.EnsureVisible(Logview.Items.Count - 1);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Convert.ToInt32(ntime) == 1)
            {
               
                label6.Text = "다음 실행까지: " + ntime + "초";
            }
            else
            {
                ntime = Convert.ToString(Convert.ToInt32(ntime) - 1);
                label6.Text = "다음 실행까지: " + ntime + "초";
            }
        }
        
    }
}