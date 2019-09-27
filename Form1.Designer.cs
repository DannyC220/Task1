namespace GADE_POE_Part_1
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
            this.lblMap = new System.Windows.Forms.Label();
            this.lblRoundCount = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.txtGameInfo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblMap
            // 
            this.lblMap.AutoSize = true;
            this.lblMap.Location = new System.Drawing.Point(173, 111);
            this.lblMap.Name = "lblMap";
            this.lblMap.Size = new System.Drawing.Size(35, 17);
            this.lblMap.TabIndex = 0;
            this.lblMap.Text = "Map";
            // 
            // lblRoundCount
            // 
            this.lblRoundCount.AutoSize = true;
            this.lblRoundCount.Location = new System.Drawing.Point(495, 68);
            this.lblRoundCount.Name = "lblRoundCount";
            this.lblRoundCount.Size = new System.Drawing.Size(50, 17);
            this.lblRoundCount.TabIndex = 1;
            this.lblRoundCount.Text = "Round";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(431, 350);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(114, 46);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(605, 350);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(114, 46);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // txtGameInfo
            // 
            this.txtGameInfo.Location = new System.Drawing.Point(566, 122);
            this.txtGameInfo.Multiline = true;
            this.txtGameInfo.Name = "txtGameInfo";
            this.txtGameInfo.Size = new System.Drawing.Size(153, 176);
            this.txtGameInfo.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 520);
            this.Controls.Add(this.txtGameInfo);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblRoundCount);
            this.Controls.Add(this.lblMap);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMap;
        private System.Windows.Forms.Label lblRoundCount;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox txtGameInfo;
    }
}

