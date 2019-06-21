namespace SlidingPuzzle
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuPanel = new System.Windows.Forms.Panel();
            this.scorePanel = new System.Windows.Forms.Panel();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblOpenCnt = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRetry = new System.Windows.Forms.Button();
            this.btnLevel2 = new System.Windows.Forms.Button();
            this.btnLevel1 = new System.Windows.Forms.Button();
            this.btnImage4 = new System.Windows.Forms.Button();
            this.btnImage3 = new System.Windows.Forms.Button();
            this.btnImage2 = new System.Windows.Forms.Button();
            this.btnImage1 = new System.Windows.Forms.Button();
            this.btnImage0 = new System.Windows.Forms.Button();
            this.btnLevel0 = new System.Windows.Forms.Button();
            this.lblImage = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.viewPanel = new System.Windows.Forms.Panel();
            this.gamePanel = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.timeThread = new System.Windows.Forms.Timer(this.components);
            this.menuPanel.SuspendLayout();
            this.scorePanel.SuspendLayout();
            this.viewPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.menuPanel.Controls.Add(this.scorePanel);
            this.menuPanel.Controls.Add(this.lblOpenCnt);
            this.menuPanel.Controls.Add(this.btnExit);
            this.menuPanel.Controls.Add(this.btnRetry);
            this.menuPanel.Controls.Add(this.btnLevel2);
            this.menuPanel.Controls.Add(this.btnLevel1);
            this.menuPanel.Controls.Add(this.btnImage4);
            this.menuPanel.Controls.Add(this.btnImage3);
            this.menuPanel.Controls.Add(this.btnImage2);
            this.menuPanel.Controls.Add(this.btnImage1);
            this.menuPanel.Controls.Add(this.btnImage0);
            this.menuPanel.Controls.Add(this.btnLevel0);
            this.menuPanel.Controls.Add(this.lblImage);
            this.menuPanel.Controls.Add(this.lblLevel);
            resources.ApplyResources(this.menuPanel, "menuPanel");
            this.menuPanel.Name = "menuPanel";
            // 
            // scorePanel
            // 
            resources.ApplyResources(this.scorePanel, "scorePanel");
            this.scorePanel.Controls.Add(this.lblScore);
            this.scorePanel.Name = "scorePanel";
            // 
            // lblScore
            // 
            this.lblScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(173)))));
            resources.ApplyResources(this.lblScore, "lblScore");
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Name = "lblScore";
            // 
            // lblOpenCnt
            // 
            resources.ApplyResources(this.lblOpenCnt, "lblOpenCnt");
            this.lblOpenCnt.ForeColor = System.Drawing.Color.White;
            this.lblOpenCnt.Name = "lblOpenCnt";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.Image = global::SlidingPuzzle.Properties.Resources.txt_exit;
            this.btnExit.Name = "btnExit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRetry
            // 
            this.btnRetry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnRetry.FlatAppearance.BorderSize = 0;
            this.btnRetry.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.btnRetry.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            resources.ApplyResources(this.btnRetry, "btnRetry");
            this.btnRetry.Image = global::SlidingPuzzle.Properties.Resources.txt_retry;
            this.btnRetry.Name = "btnRetry";
            this.btnRetry.UseVisualStyleBackColor = false;
            this.btnRetry.Click += new System.EventHandler(this.btnRetry_Click);
            // 
            // btnLevel2
            // 
            this.btnLevel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.btnLevel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLevel2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnLevel2.FlatAppearance.BorderSize = 0;
            this.btnLevel2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.btnLevel2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            resources.ApplyResources(this.btnLevel2, "btnLevel2");
            this.btnLevel2.ForeColor = System.Drawing.Color.White;
            this.btnLevel2.Name = "btnLevel2";
            this.btnLevel2.UseVisualStyleBackColor = false;
            this.btnLevel2.Click += new System.EventHandler(this.btnLevel2_Click);
            // 
            // btnLevel1
            // 
            this.btnLevel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(73)))));
            this.btnLevel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLevel1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.btnLevel1.FlatAppearance.BorderSize = 0;
            this.btnLevel1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(123)))), ((int)(((byte)(120)))));
            this.btnLevel1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(123)))), ((int)(((byte)(120)))));
            resources.ApplyResources(this.btnLevel1, "btnLevel1");
            this.btnLevel1.ForeColor = System.Drawing.Color.White;
            this.btnLevel1.Name = "btnLevel1";
            this.btnLevel1.UseVisualStyleBackColor = false;
            this.btnLevel1.Click += new System.EventHandler(this.btnLevel1_Click);
            // 
            // btnImage4
            // 
            this.btnImage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.btnImage4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImage4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnImage4.FlatAppearance.BorderSize = 0;
            this.btnImage4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.btnImage4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            resources.ApplyResources(this.btnImage4, "btnImage4");
            this.btnImage4.ForeColor = System.Drawing.Color.White;
            this.btnImage4.Name = "btnImage4";
            this.btnImage4.UseVisualStyleBackColor = false;
            this.btnImage4.Click += new System.EventHandler(this.btnImage4_Click);
            // 
            // btnImage3
            // 
            this.btnImage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.btnImage3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImage3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnImage3.FlatAppearance.BorderSize = 0;
            this.btnImage3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.btnImage3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            resources.ApplyResources(this.btnImage3, "btnImage3");
            this.btnImage3.ForeColor = System.Drawing.Color.White;
            this.btnImage3.Name = "btnImage3";
            this.btnImage3.UseVisualStyleBackColor = false;
            this.btnImage3.Click += new System.EventHandler(this.btnImage3_Click);
            // 
            // btnImage2
            // 
            this.btnImage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.btnImage2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImage2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnImage2.FlatAppearance.BorderSize = 0;
            this.btnImage2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.btnImage2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            resources.ApplyResources(this.btnImage2, "btnImage2");
            this.btnImage2.ForeColor = System.Drawing.Color.White;
            this.btnImage2.Name = "btnImage2";
            this.btnImage2.UseVisualStyleBackColor = false;
            this.btnImage2.Click += new System.EventHandler(this.btnImage2_Click);
            // 
            // btnImage1
            // 
            this.btnImage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.btnImage1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImage1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnImage1.FlatAppearance.BorderSize = 0;
            this.btnImage1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.btnImage1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            resources.ApplyResources(this.btnImage1, "btnImage1");
            this.btnImage1.ForeColor = System.Drawing.Color.White;
            this.btnImage1.Name = "btnImage1";
            this.btnImage1.UseVisualStyleBackColor = false;
            this.btnImage1.Click += new System.EventHandler(this.btnImage1_Click);
            // 
            // btnImage0
            // 
            this.btnImage0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(73)))));
            this.btnImage0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImage0.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.btnImage0.FlatAppearance.BorderSize = 0;
            this.btnImage0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(123)))), ((int)(((byte)(120)))));
            this.btnImage0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(123)))), ((int)(((byte)(120)))));
            resources.ApplyResources(this.btnImage0, "btnImage0");
            this.btnImage0.ForeColor = System.Drawing.Color.White;
            this.btnImage0.Name = "btnImage0";
            this.btnImage0.UseVisualStyleBackColor = false;
            this.btnImage0.Click += new System.EventHandler(this.btnImage0_Click);
            // 
            // btnLevel0
            // 
            this.btnLevel0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.btnLevel0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLevel0.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnLevel0.FlatAppearance.BorderSize = 0;
            this.btnLevel0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.btnLevel0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            resources.ApplyResources(this.btnLevel0, "btnLevel0");
            this.btnLevel0.ForeColor = System.Drawing.Color.White;
            this.btnLevel0.Name = "btnLevel0";
            this.btnLevel0.UseVisualStyleBackColor = false;
            this.btnLevel0.Click += new System.EventHandler(this.btnLevel0_Click);
            // 
            // lblImage
            // 
            resources.ApplyResources(this.lblImage, "lblImage");
            this.lblImage.ForeColor = System.Drawing.Color.White;
            this.lblImage.Name = "lblImage";
            // 
            // lblLevel
            // 
            resources.ApplyResources(this.lblLevel, "lblLevel");
            this.lblLevel.ForeColor = System.Drawing.Color.White;
            this.lblLevel.Name = "lblLevel";
            // 
            // viewPanel
            // 
            this.viewPanel.Controls.Add(this.gamePanel);
            this.viewPanel.Controls.Add(this.lblTime);
            this.viewPanel.Controls.Add(this.lblTitle);
            resources.ApplyResources(this.viewPanel, "viewPanel");
            this.viewPanel.Name = "viewPanel";
            // 
            // gamePanel
            // 
            resources.ApplyResources(this.gamePanel, "gamePanel");
            this.gamePanel.Name = "gamePanel";
            // 
            // lblTime
            // 
            resources.ApplyResources(this.lblTime, "lblTime");
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(73)))));
            this.lblTime.Name = "lblTime";
            // 
            // lblTitle
            // 
            resources.ApplyResources(this.lblTitle, "lblTitle");
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.lblTitle.Name = "lblTitle";
            // 
            // timeThread
            // 
            this.timeThread.Interval = 1000;
            this.timeThread.Tick += new System.EventHandler(this.timeThread_Tick);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(90)))));
            this.Controls.Add(this.viewPanel);
            this.Controls.Add(this.menuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            this.scorePanel.ResumeLayout(false);
            this.viewPanel.ResumeLayout(false);
            this.viewPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Panel viewPanel;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.Button btnLevel0;
        private System.Windows.Forms.Button btnLevel2;
        private System.Windows.Forms.Button btnLevel1;
        private System.Windows.Forms.Button btnImage0;
        private System.Windows.Forms.Button btnImage4;
        private System.Windows.Forms.Button btnImage3;
        private System.Windows.Forms.Button btnImage2;
        private System.Windows.Forms.Button btnImage1;
        private System.Windows.Forms.Timer timeThread;
        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRetry;
        private System.Windows.Forms.Label lblOpenCnt;
        private System.Windows.Forms.Panel scorePanel;
        private System.Windows.Forms.Label lblScore;
    }
}

