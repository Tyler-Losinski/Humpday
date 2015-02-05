namespace Humpday
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
            this.Activate = new System.Windows.Forms.Button();
            this.Banner = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Activate
            // 
            this.Activate.Location = new System.Drawing.Point(12, 226);
            this.Activate.Name = "Activate";
            this.Activate.Size = new System.Drawing.Size(260, 23);
            this.Activate.TabIndex = 0;
            this.Activate.Text = "Is it Hump Day?";
            this.Activate.UseVisualStyleBackColor = true;
            this.Activate.Click += new System.EventHandler(this.Activate_Click);
            // 
            // Banner
            // 
            this.Banner.AutoSize = true;
            this.Banner.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Banner.Location = new System.Drawing.Point(71, 85);
            this.Banner.Name = "Banner";
            this.Banner.Size = new System.Drawing.Size(134, 26);
            this.Banner.TabIndex = 1;
            this.Banner.Text = "Awesome Title";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Banner);
            this.Controls.Add(this.Activate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Activate;
        private System.Windows.Forms.Label Banner;
    }
}

