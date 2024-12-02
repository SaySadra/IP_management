namespace UI
{
    partial class frmWellcome
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWellcome));
            this.prgbWellcome = new System.Windows.Forms.ProgressBar();
            this.timerWellcome = new System.Windows.Forms.Timer(this.components);
            this.picWellcome = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picWellcome)).BeginInit();
            this.SuspendLayout();
            // 
            // prgbWellcome
            // 
            this.prgbWellcome.BackColor = System.Drawing.SystemColors.Control;
            this.prgbWellcome.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.prgbWellcome.Location = new System.Drawing.Point(0, 351);
            this.prgbWellcome.Name = "prgbWellcome";
            this.prgbWellcome.Size = new System.Drawing.Size(635, 59);
            this.prgbWellcome.TabIndex = 1;
            // 
            // timerWellcome
            // 
            this.timerWellcome.Enabled = true;
            this.timerWellcome.Interval = 30;
            this.timerWellcome.Tick += new System.EventHandler(this.timerWellcome_Tick);
            // 
            // picWellcome
            // 
            this.picWellcome.Image = global::UI.Properties.Resources.how_to_develop_ip_management_software_main_1600;
            this.picWellcome.Location = new System.Drawing.Point(0, -2);
            this.picWellcome.Name = "picWellcome";
            this.picWellcome.Size = new System.Drawing.Size(637, 361);
            this.picWellcome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWellcome.TabIndex = 0;
            this.picWellcome.TabStop = false;
            // 
            // frmWellcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(635, 410);
            this.Controls.Add(this.prgbWellcome);
            this.Controls.Add(this.picWellcome);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmWellcome";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.picWellcome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picWellcome;
        private System.Windows.Forms.ProgressBar prgbWellcome;
        private System.Windows.Forms.Timer timerWellcome;
    }
}

