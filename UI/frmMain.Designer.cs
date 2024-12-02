namespace UI
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.dgvIPList = new System.Windows.Forms.DataGridView();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileLoadFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileSaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOption = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOptionSeparator = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOptionDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProperthis = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProperthisLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProperthisNew = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuProperthisGenerate = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Starts = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIPList)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvIPList
            // 
            this.dgvIPList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIPList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIPList.Location = new System.Drawing.Point(0, 28);
            this.dgvIPList.Name = "dgvIPList";
            this.dgvIPList.RowHeadersWidth = 51;
            this.dgvIPList.RowTemplate.Height = 24;
            this.dgvIPList.Size = new System.Drawing.Size(567, 323);
            this.dgvIPList.TabIndex = 0;
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuOption,
            this.menuProperthis,
            this.menuAbout});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(567, 28);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menu";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileLoadFile,
            this.menuFileSaveFile,
            this.toolStripSeparator1,
            this.menuFileExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(46, 24);
            this.menuFile.Text = "File";
            // 
            // menuFileLoadFile
            // 
            this.menuFileLoadFile.Name = "menuFileLoadFile";
            this.menuFileLoadFile.Size = new System.Drawing.Size(224, 26);
            this.menuFileLoadFile.Text = "Load File";
            this.menuFileLoadFile.Click += new System.EventHandler(this.menuFileLoadFile_Click);
            // 
            // menuFileSaveFile
            // 
            this.menuFileSaveFile.Name = "menuFileSaveFile";
            this.menuFileSaveFile.Size = new System.Drawing.Size(224, 26);
            this.menuFileSaveFile.Text = "Save File";
            this.menuFileSaveFile.Click += new System.EventHandler(this.menuFileSaveFile_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // menuFileExit
            // 
            this.menuFileExit.Name = "menuFileExit";
            this.menuFileExit.Size = new System.Drawing.Size(224, 26);
            this.menuFileExit.Text = "Exit";
            // 
            // menuOption
            // 
            this.menuOption.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOptionSeparator,
            this.menuOptionDelete});
            this.menuOption.Name = "menuOption";
            this.menuOption.Size = new System.Drawing.Size(69, 24);
            this.menuOption.Text = "Option";
            // 
            // menuOptionSeparator
            // 
            this.menuOptionSeparator.Name = "menuOptionSeparator";
            this.menuOptionSeparator.Size = new System.Drawing.Size(224, 26);
            this.menuOptionSeparator.Text = "Separator";
            this.menuOptionSeparator.Click += new System.EventHandler(this.menuOptionSeparator_Click);
            // 
            // menuOptionDelete
            // 
            this.menuOptionDelete.Name = "menuOptionDelete";
            this.menuOptionDelete.Size = new System.Drawing.Size(224, 26);
            this.menuOptionDelete.Text = "Delete";
            this.menuOptionDelete.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // menuProperthis
            // 
            this.menuProperthis.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuProperthisLoad,
            this.menuProperthisNew,
            this.toolStripSeparator3,
            this.menuProperthisGenerate});
            this.menuProperthis.Name = "menuProperthis";
            this.menuProperthis.Size = new System.Drawing.Size(90, 24);
            this.menuProperthis.Text = "Properthis";
            // 
            // menuProperthisLoad
            // 
            this.menuProperthisLoad.Name = "menuProperthisLoad";
            this.menuProperthisLoad.Size = new System.Drawing.Size(242, 26);
            this.menuProperthisLoad.Text = "Refeash";
            this.menuProperthisLoad.Click += new System.EventHandler(this.menuProperthisLoad_Click);
            // 
            // menuProperthisNew
            // 
            this.menuProperthisNew.Name = "menuProperthisNew";
            this.menuProperthisNew.Size = new System.Drawing.Size(242, 26);
            this.menuProperthisNew.Text = "New";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(239, 6);
            // 
            // menuProperthisGenerate
            // 
            this.menuProperthisGenerate.Name = "menuProperthisGenerate";
            this.menuProperthisGenerate.Size = new System.Drawing.Size(242, 26);
            this.menuProperthisGenerate.Text = "Generate Sample Data";
            this.menuProperthisGenerate.Click += new System.EventHandler(this.menuGenrateSampleData_Click);
            // 
            // menuAbout
            // 
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.Size = new System.Drawing.Size(64, 24);
            this.menuAbout.Text = "About";
            // 
            // bgWorker
            // 
            this.bgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_DoWork);
            this.bgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorker_RunWorkerCompleted);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Starts});
            this.statusStrip1.Location = new System.Drawing.Point(0, 325);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(567, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Starts
            // 
            this.Starts.Name = "Starts";
            this.Starts.Size = new System.Drawing.Size(82, 20);
            this.Starts.Text = "App Ready";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 351);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dgvIPList);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIPList)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIPList;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuFileLoadFile;
        private System.Windows.Forms.ToolStripMenuItem menuFileSaveFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuFileExit;
        private System.Windows.Forms.ToolStripMenuItem menuOption;
        private System.Windows.Forms.ToolStripMenuItem menuOptionSeparator;
        private System.Windows.Forms.ToolStripMenuItem menuProperthis;
        private System.Windows.Forms.ToolStripMenuItem menuProperthisLoad;
        private System.Windows.Forms.ToolStripMenuItem menuProperthisNew;
        private System.Windows.Forms.ToolStripMenuItem menuProperthisGenerate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem menuAbout;
        private System.ComponentModel.BackgroundWorker bgWorker;
        private System.Windows.Forms.ToolStripMenuItem menuOptionDelete;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel Starts;
    }
}