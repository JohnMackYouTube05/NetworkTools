namespace NetworkTools
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpenWhoIS = new System.Windows.Forms.Button();
            this.btnPing = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(422, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Network Tools";
            // 
            // btnOpenWhoIS
            // 
            this.btnOpenWhoIS.AccessibleDescription = "Opens the Whois form.";
            this.btnOpenWhoIS.AccessibleName = "WHOIS Button";
            this.btnOpenWhoIS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnOpenWhoIS.Location = new System.Drawing.Point(39, 72);
            this.btnOpenWhoIS.Name = "btnOpenWhoIS";
            this.btnOpenWhoIS.Size = new System.Drawing.Size(207, 73);
            this.btnOpenWhoIS.TabIndex = 1;
            this.btnOpenWhoIS.Text = "WHOIS";
            this.btnOpenWhoIS.UseVisualStyleBackColor = true;
            this.btnOpenWhoIS.Click += new System.EventHandler(this.btnOpenWhoIS_Click);
            // 
            // btnPing
            // 
            this.btnPing.AccessibleDescription = "Opens the ping form.";
            this.btnPing.AccessibleName = "Ping Button";
            this.btnPing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPing.Location = new System.Drawing.Point(274, 72);
            this.btnPing.Name = "btnPing";
            this.btnPing.Size = new System.Drawing.Size(207, 73);
            this.btnPing.TabIndex = 2;
            this.btnPing.Text = "Ping";
            this.btnPing.UseVisualStyleBackColor = true;
            this.btnPing.Click += new System.EventHandler(this.btnPing_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 579);
            this.Controls.Add(this.btnPing);
            this.Controls.Add(this.btnOpenWhoIS);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Network Tools Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpenWhoIS;
        private System.Windows.Forms.Button btnPing;
    }
}

