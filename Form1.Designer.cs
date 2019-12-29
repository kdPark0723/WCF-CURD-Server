namespace WCF_Server
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
            this.serverStartButton = new System.Windows.Forms.Button();
            this.serverStopButton = new System.Windows.Forms.Button();
            this.statText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // serverStartButton
            // 
            this.serverStartButton.Location = new System.Drawing.Point(41, 41);
            this.serverStartButton.Name = "serverStartButton";
            this.serverStartButton.Size = new System.Drawing.Size(274, 56);
            this.serverStartButton.TabIndex = 1;
            this.serverStartButton.Text = "MCF SERVER START";
            this.serverStartButton.UseVisualStyleBackColor = true;
            this.serverStartButton.Click += new System.EventHandler(this.ServerStartButton_Click);
            // 
            // serverStopButton
            // 
            this.serverStopButton.Location = new System.Drawing.Point(481, 41);
            this.serverStopButton.Name = "serverStopButton";
            this.serverStopButton.Size = new System.Drawing.Size(274, 56);
            this.serverStopButton.TabIndex = 2;
            this.serverStopButton.Text = "MCF SERVER STOP";
            this.serverStopButton.UseVisualStyleBackColor = true;
            this.serverStopButton.Click += new System.EventHandler(this.ServerStopButton_Click);
            // 
            // statText
            // 
            this.statText.AutoSize = true;
            this.statText.Location = new System.Drawing.Point(354, 144);
            this.statText.Name = "statText";
            this.statText.Size = new System.Drawing.Size(85, 15);
            this.statText.TabIndex = 3;
            this.statText.Text = "Server Stop";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 197);
            this.Controls.Add(this.statText);
            this.Controls.Add(this.serverStopButton);
            this.Controls.Add(this.serverStartButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button serverStartButton;
        private System.Windows.Forms.Button serverStopButton;
        private System.Windows.Forms.Label statText;
    }
}

