namespace NetworkTools
{
    partial class PingTool
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPing = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nudMilliseconds = new System.Windows.Forms.NumericUpDown();
            this.txtOutput = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudMilliseconds)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 22F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(186, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ping Tool";
            // 
            // txtURL
            // 
            this.txtURL.AccessibleDescription = "URL or IP Address to ping.";
            this.txtURL.AccessibleName = "URL Text Box";
            this.txtURL.Location = new System.Drawing.Point(133, 80);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(429, 22);
            this.txtURL.TabIndex = 1;
            this.txtURL.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "URL or IP to Ping:";
            // 
            // btnPing
            // 
            this.btnPing.AccessibleDescription = "Sends the ping.";
            this.btnPing.AccessibleName = "Ping Button";
            this.btnPing.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPing.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnPing.Location = new System.Drawing.Point(187, 501);
            this.btnPing.Name = "btnPing";
            this.btnPing.Size = new System.Drawing.Size(198, 61);
            this.btnPing.TabIndex = 5;
            this.btnPing.Text = "Ping";
            this.btnPing.UseVisualStyleBackColor = true;
            this.btnPing.Click += new System.EventHandler(this.btnPing_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Milliseconds between pings:";
            // 
            // nudMilliseconds
            // 
            this.nudMilliseconds.AccessibleDescription = "Number of milliseconds between pings:";
            this.nudMilliseconds.AccessibleName = "Number of Milliseconds";
            this.nudMilliseconds.Location = new System.Drawing.Point(213, 104);
            this.nudMilliseconds.Name = "nudMilliseconds";
            this.nudMilliseconds.Size = new System.Drawing.Size(349, 22);
            this.nudMilliseconds.TabIndex = 7;
            // 
            // txtOutput
            // 
            this.txtOutput.FormattingEnabled = true;
            this.txtOutput.ItemHeight = 16;
            this.txtOutput.Location = new System.Drawing.Point(13, 141);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(549, 340);
            this.txtOutput.TabIndex = 8;
            // 
            // PingTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 574);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.nudMilliseconds);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPing);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.label1);
            this.Name = "PingTool";
            this.Text = "Ping";
            ((System.ComponentModel.ISupportInitialize)(this.nudMilliseconds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPing;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudMilliseconds;
        private System.Windows.Forms.ListBox txtOutput;
    }
}