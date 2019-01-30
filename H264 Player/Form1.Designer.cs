namespace H264_Player
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblFrameSize = new System.Windows.Forms.Label();
            this.lblCodecName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnFastBackward = new System.Windows.Forms.Button();
            this.btnGotoEnd = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnGotoBeginging = new System.Windows.Forms.Button();
            this.btnFastForward = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(923, 528);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblFrameSize
            // 
            this.lblFrameSize.AutoSize = true;
            this.lblFrameSize.Location = new System.Drawing.Point(12, 68);
            this.lblFrameSize.Name = "lblFrameSize";
            this.lblFrameSize.Size = new System.Drawing.Size(66, 13);
            this.lblFrameSize.TabIndex = 1;
            this.lblFrameSize.Text = "lblFrameSize";
            // 
            // lblCodecName
            // 
            this.lblCodecName.AutoSize = true;
            this.lblCodecName.Location = new System.Drawing.Point(12, 46);
            this.lblCodecName.Name = "lblCodecName";
            this.lblCodecName.Size = new System.Drawing.Size(76, 13);
            this.lblCodecName.TabIndex = 2;
            this.lblCodecName.Text = "lblCodecName";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnOpen);
            this.panel1.Controls.Add(this.btnFastBackward);
            this.panel1.Controls.Add(this.btnGotoEnd);
            this.panel1.Controls.Add(this.btnStop);
            this.panel1.Controls.Add(this.btnPause);
            this.panel1.Controls.Add(this.btnGotoBeginging);
            this.panel1.Controls.Add(this.btnFastForward);
            this.panel1.Controls.Add(this.btnPlay);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.lblCodecName);
            this.panel1.Controls.Add(this.lblFrameSize);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 428);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(923, 100);
            this.panel1.TabIndex = 3;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(836, 68);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 11;
            this.btnOpen.Text = "Open File";
            this.btnOpen.UseVisualStyleBackColor = true;
            // 
            // btnFastBackward
            // 
            this.btnFastBackward.Location = new System.Drawing.Point(389, 29);
            this.btnFastBackward.Name = "btnFastBackward";
            this.btnFastBackward.Size = new System.Drawing.Size(30, 30);
            this.btnFastBackward.TabIndex = 10;
            this.btnFastBackward.Text = "⏪";
            this.btnFastBackward.UseVisualStyleBackColor = true;
            // 
            // btnGotoEnd
            // 
            this.btnGotoEnd.Location = new System.Drawing.Point(353, 29);
            this.btnGotoEnd.Name = "btnGotoEnd";
            this.btnGotoEnd.Size = new System.Drawing.Size(30, 30);
            this.btnGotoEnd.TabIndex = 9;
            this.btnGotoEnd.Text = "⏭";
            this.btnGotoEnd.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(245, 29);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(30, 30);
            this.btnStop.TabIndex = 8;
            this.btnStop.Text = "■";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(209, 29);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(30, 30);
            this.btnPause.TabIndex = 7;
            this.btnPause.Text = "⏸";
            this.btnPause.UseVisualStyleBackColor = true;
            // 
            // btnGotoBeginging
            // 
            this.btnGotoBeginging.Location = new System.Drawing.Point(317, 29);
            this.btnGotoBeginging.Name = "btnGotoBeginging";
            this.btnGotoBeginging.Size = new System.Drawing.Size(30, 30);
            this.btnGotoBeginging.TabIndex = 6;
            this.btnGotoBeginging.Text = "⏮";
            this.btnGotoBeginging.UseVisualStyleBackColor = true;
            // 
            // btnFastForward
            // 
            this.btnFastForward.Location = new System.Drawing.Point(281, 29);
            this.btnFastForward.Name = "btnFastForward";
            this.btnFastForward.Size = new System.Drawing.Size(30, 30);
            this.btnFastForward.TabIndex = 5;
            this.btnFastForward.Text = "⏩";
            this.btnFastForward.UseVisualStyleBackColor = true;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(173, 29);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(30, 30);
            this.btnPlay.TabIndex = 4;
            this.btnPlay.Text = "▶";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.progressBar1.Location = new System.Drawing.Point(0, 0);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(923, 23);
            this.progressBar1.Step = 50;
            this.progressBar1.TabIndex = 3;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 528);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblFrameSize;
        private System.Windows.Forms.Label lblCodecName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFastBackward;
        private System.Windows.Forms.Button btnGotoEnd;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnGotoBeginging;
        private System.Windows.Forms.Button btnFastForward;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

