namespace ProxySwitcher
{
    partial class ProxySwitcher
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
            this.btnSwitch = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblProxyName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTimerTick = new System.Windows.Forms.Label();
            this.lblPolicyChangeTimes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSwitch
            // 
            this.btnSwitch.Location = new System.Drawing.Point(12, 117);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(314, 56);
            this.btnSwitch.TabIndex = 0;
            this.btnSwitch.Text = "Switch On";
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblStatus.Location = new System.Drawing.Point(7, 24);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(59, 23);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "label1";
            // 
            // lblProxyName
            // 
            this.lblProxyName.AutoSize = true;
            this.lblProxyName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProxyName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblProxyName.Location = new System.Drawing.Point(8, 78);
            this.lblProxyName.Name = "lblProxyName";
            this.lblProxyName.Size = new System.Drawing.Size(50, 19);
            this.lblProxyName.TabIndex = 2;
            this.lblProxyName.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(8, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Proxy Server : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(7, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Proxy Status : ";
            // 
            // lblTimerTick
            // 
            this.lblTimerTick.AutoSize = true;
            this.lblTimerTick.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimerTick.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTimerTick.Location = new System.Drawing.Point(239, 14);
            this.lblTimerTick.Name = "lblTimerTick";
            this.lblTimerTick.Size = new System.Drawing.Size(37, 14);
            this.lblTimerTick.TabIndex = 6;
            this.lblTimerTick.Text = "label1";
            this.lblTimerTick.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblPolicyChangeTimes
            // 
            this.lblPolicyChangeTimes.AutoSize = true;
            this.lblPolicyChangeTimes.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPolicyChangeTimes.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblPolicyChangeTimes.Location = new System.Drawing.Point(239, 28);
            this.lblPolicyChangeTimes.Name = "lblPolicyChangeTimes";
            this.lblPolicyChangeTimes.Size = new System.Drawing.Size(37, 14);
            this.lblPolicyChangeTimes.TabIndex = 7;
            this.lblPolicyChangeTimes.Text = "label1";
            this.lblPolicyChangeTimes.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // ProxySwitcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 189);
            this.Controls.Add(this.lblPolicyChangeTimes);
            this.Controls.Add(this.lblTimerTick);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblProxyName);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnSwitch);
            this.Name = "ProxySwitcher";
            this.Text = "Proxy Switcher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblProxyName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTimerTick;
        private System.Windows.Forms.Label lblPolicyChangeTimes;
    }
}

