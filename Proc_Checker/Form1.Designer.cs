namespace Proc_Checker
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.nowtime = new System.Windows.Forms.Label();
            this.Getnowtime = new System.Windows.Forms.Timer(this.components);
            this.Logview = new System.Windows.Forms.ListView();
            this.idx = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.filepath = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.rnt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Proccheck = new System.Windows.Forms.Timer(this.components);
            this.Proc_name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "현재 시간:";
            // 
            // nowtime
            // 
            this.nowtime.AutoSize = true;
            this.nowtime.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.nowtime.Location = new System.Drawing.Point(70, 9);
            this.nowtime.Name = "nowtime";
            this.nowtime.Size = new System.Drawing.Size(179, 15);
            this.nowtime.TabIndex = 1;
            this.nowtime.Text = "yyyy년 MM월 dd일 tt hh:mm:ss";
            // 
            // Getnowtime
            // 
            this.Getnowtime.Enabled = true;
            this.Getnowtime.Tick += new System.EventHandler(this.Getnowtime_Tick);
            // 
            // Logview
            // 
            this.Logview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idx,
            this.time,
            this.stat});
            this.Logview.FullRowSelect = true;
            this.Logview.GridLines = true;
            this.Logview.Location = new System.Drawing.Point(13, 85);
            this.Logview.Name = "Logview";
            this.Logview.Size = new System.Drawing.Size(386, 188);
            this.Logview.TabIndex = 2;
            this.Logview.UseCompatibleStateImageBehavior = false;
            this.Logview.View = System.Windows.Forms.View.Details;
            // 
            // idx
            // 
            this.idx.Text = "Idx";
            this.idx.Width = 47;
            // 
            // time
            // 
            this.time.Text = "Time";
            this.time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.time.Width = 236;
            // 
            // stat
            // 
            this.stat.Text = "Status";
            this.stat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.stat.Width = 73;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(38, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "경로:";
            // 
            // filepath
            // 
            this.filepath.Location = new System.Drawing.Point(73, 32);
            this.filepath.Name = "filepath";
            this.filepath.Size = new System.Drawing.Size(301, 21);
            this.filepath.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(380, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(19, 20);
            this.button1.TabIndex = 5;
            this.button1.Text = "&C";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(354, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 20);
            this.button2.TabIndex = 6;
            this.button2.Text = "&Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(9, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "실행주기 :";
            // 
            // rnt
            // 
            this.rnt.Location = new System.Drawing.Point(73, 59);
            this.rnt.MaxLength = 3;
            this.rnt.Name = "rnt";
            this.rnt.Size = new System.Drawing.Size(28, 21);
            this.rnt.TabIndex = 8;
            this.rnt.Text = "123";
            this.rnt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Rtime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(100, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "분, 프로세스 명:";
            // 
            // Proccheck
            // 
            this.Proccheck.Tick += new System.EventHandler(this.Proccheck_Tick);
            // 
            // Proc_name
            // 
            this.Proc_name.Location = new System.Drawing.Point(195, 58);
            this.Proc_name.Name = "Proc_name";
            this.Proc_name.Size = new System.Drawing.Size(153, 21);
            this.Proc_name.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(262, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "다음 실행까지: xxx 초";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 277);
            this.Controls.Add(this.rnt);
            this.Controls.Add(this.Proc_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.filepath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Logview);
            this.Controls.Add(this.nowtime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Process Checker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nowtime;
        private System.Windows.Forms.Timer Getnowtime;
        private System.Windows.Forms.ListView Logview;
        private System.Windows.Forms.ColumnHeader idx;
        private System.Windows.Forms.ColumnHeader time;
        private System.Windows.Forms.ColumnHeader stat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox filepath;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox rnt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer Proccheck;
        private System.Windows.Forms.TextBox Proc_name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
    }
}

