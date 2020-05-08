﻿namespace TwimgSpeedPatch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.patchButton = new System.Windows.Forms.Button();
            this.openHostFile = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.status = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // patchButton
            // 
            this.patchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(116)))), ((int)(((byte)(157)))));
            this.patchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(90)))), ((int)(((byte)(130)))));
            this.patchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.patchButton.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.patchButton.ForeColor = System.Drawing.Color.Snow;
            this.patchButton.Location = new System.Drawing.Point(473, 327);
            this.patchButton.Name = "patchButton";
            this.patchButton.Size = new System.Drawing.Size(146, 58);
            this.patchButton.TabIndex = 1;
            this.patchButton.Text = "패치 or 제거하기";
            this.patchButton.UseVisualStyleBackColor = false;
            this.patchButton.Click += new System.EventHandler(this.PatchButton_Click);
            // 
            // openHostFile
            // 
            this.openHostFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(116)))), ((int)(((byte)(157)))));
            this.openHostFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(90)))), ((int)(((byte)(130)))));
            this.openHostFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openHostFile.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.openHostFile.ForeColor = System.Drawing.Color.Snow;
            this.openHostFile.Location = new System.Drawing.Point(625, 326);
            this.openHostFile.Name = "openHostFile";
            this.openHostFile.Size = new System.Drawing.Size(115, 58);
            this.openHostFile.TabIndex = 6;
            this.openHostFile.Text = "hosts 파일 열기";
            this.openHostFile.UseVisualStyleBackColor = false;
            this.openHostFile.Click += new System.EventHandler(this.OpenHostFile_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(116)))), ((int)(((byte)(157)))));
            this.linkLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.linkLabel1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(116)))), ((int)(((byte)(157)))));
            this.linkLabel1.Location = new System.Drawing.Point(511, 265);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(203, 19);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://twitter.com/sokcuri";
            this.linkLabel1.Click += new System.EventHandler(this.linkLabel1_Click);
            // 
            // linkLabel2
            // 
            this.linkLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(216)))), ((int)(((byte)(232)))));
            this.linkLabel2.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.linkLabel2.ForeColor = System.Drawing.Color.Black;
            this.linkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel2.LinkColor = System.Drawing.Color.Black;
            this.linkLabel2.LinkVisited = true;
            this.linkLabel2.Location = new System.Drawing.Point(511, 220);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(203, 38);
            this.linkLabel2.TabIndex = 8;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "트위터 속도 패치";
            this.linkLabel2.VisitedLinkColor = System.Drawing.Color.Black;
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TwimgSpeedPatch.Properties.Resources.kyouka;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(755, 453);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // linkLabel3
            // 
            this.linkLabel3.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(116)))), ((int)(((byte)(157)))));
            this.linkLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.linkLabel3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.linkLabel3.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(116)))), ((int)(((byte)(157)))));
            this.linkLabel3.Location = new System.Drawing.Point(511, 284);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(203, 19);
            this.linkLabel3.TabIndex = 9;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "https://twitter.com/ek2rlstk";
            // 
            // status
            // 
            this.status.BackColor = System.Drawing.Color.White;
            this.status.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.Location = new System.Drawing.Point(12, 143);
            this.status.Multiline = true;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.status.Size = new System.Drawing.Size(418, 296);
            this.status.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(752, 451);
            this.Controls.Add(this.status);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.openHostFile);
            this.Controls.Add(this.patchButton);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TwitterSpeedPatch";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button patchButton;
        private System.Windows.Forms.Button openHostFile;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.TextBox status;
    }
}

