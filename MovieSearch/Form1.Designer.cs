namespace MovieSearch
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new System.Windows.Forms.Label();
            txtFilter = new System.Windows.Forms.TextBox();
            btnScanMovies = new System.Windows.Forms.Button();
            lblMovies = new System.Windows.Forms.Label();
            lstDirList = new System.Windows.Forms.ListBox();
            dirListMenuStrip = new System.Windows.Forms.ContextMenuStrip(components);
            browseDirListMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            removeDirListMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            addDirListMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            clearAllDirListMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            exportDirListMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            exportCSV = new System.Windows.Forms.ToolStripMenuItem();
            exportJSON = new System.Windows.Forms.ToolStripMenuItem();
            exportXML = new System.Windows.Forms.ToolStripMenuItem();
            btnAddDirectory = new System.Windows.Forms.Button();
            btnClearDirectoryList = new System.Windows.Forms.Button();
            chkRemovePath = new System.Windows.Forms.CheckBox();
            label2 = new System.Windows.Forms.Label();
            btnClearMovieList = new System.Windows.Forms.Button();
            dgvDirectories = new System.Windows.Forms.DataGridView();
            chkShowFiles = new System.Windows.Forms.CheckBox();
            btnExport = new System.Windows.Forms.Button();
            dirListMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDirectories).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(10, 207);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(33, 15);
            label1.TabIndex = 2;
            label1.Text = "Filter";
            // 
            // txtFilter
            // 
            txtFilter.Location = new System.Drawing.Point(51, 198);
            txtFilter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new System.Drawing.Size(916, 23);
            txtFilter.TabIndex = 60;
            txtFilter.TextChanged += txtFilter_TextChanged;
            // 
            // btnScanMovies
            // 
            btnScanMovies.Location = new System.Drawing.Point(845, 66);
            btnScanMovies.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnScanMovies.Name = "btnScanMovies";
            btnScanMovies.Size = new System.Drawing.Size(210, 30);
            btnScanMovies.TabIndex = 40;
            btnScanMovies.Text = "Scan Directories";
            btnScanMovies.UseVisualStyleBackColor = true;
            btnScanMovies.Click += btnScan_Click;
            // 
            // lblMovies
            // 
            lblMovies.AutoSize = true;
            lblMovies.Location = new System.Drawing.Point(734, 689);
            lblMovies.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblMovies.MinimumSize = new System.Drawing.Size(321, 15);
            lblMovies.Name = "lblMovies";
            lblMovies.Size = new System.Drawing.Size(321, 15);
            lblMovies.TabIndex = 0;
            lblMovies.Text = "0 Result(s)";
            lblMovies.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lstDirList
            // 
            lstDirList.ContextMenuStrip = dirListMenuStrip;
            lstDirList.FormattingEnabled = true;
            lstDirList.ItemHeight = 15;
            lstDirList.Location = new System.Drawing.Point(122, 67);
            lstDirList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            lstDirList.Name = "lstDirList";
            lstDirList.Size = new System.Drawing.Size(719, 124);
            lstDirList.TabIndex = 9;
            lstDirList.TabStop = false;
            lstDirList.MouseDown += lstDirList_MouseDown;
            // 
            // dirListMenuStrip
            // 
            dirListMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { browseDirListMenuItem, removeDirListMenuItem, toolStripSeparator1, addDirListMenuItem, clearAllDirListMenuItem, toolStripSeparator2, exportDirListMenuItem });
            dirListMenuStrip.Name = "dirListMenuStrip";
            dirListMenuStrip.ShowImageMargin = false;
            dirListMenuStrip.Size = new System.Drawing.Size(107, 126);
            dirListMenuStrip.Opening += DirList_ContextMenuStrip_Opening;
            // 
            // browseDirListMenuItem
            // 
            browseDirListMenuItem.Name = "browseDirListMenuItem";
            browseDirListMenuItem.Size = new System.Drawing.Size(106, 22);
            browseDirListMenuItem.Text = "Browse";
            browseDirListMenuItem.Click += Browse_DirList_MenuItem_Click;
            // 
            // removeDirListMenuItem
            // 
            removeDirListMenuItem.Name = "removeDirListMenuItem";
            removeDirListMenuItem.Size = new System.Drawing.Size(106, 22);
            removeDirListMenuItem.Text = "Remove";
            removeDirListMenuItem.Click += Remove_DirList_MenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(103, 6);
            // 
            // addDirListMenuItem
            // 
            addDirListMenuItem.Name = "addDirListMenuItem";
            addDirListMenuItem.Size = new System.Drawing.Size(106, 22);
            addDirListMenuItem.Text = "Add New";
            addDirListMenuItem.Click += Add_DirList_MenuItem_Click;
            // 
            // clearAllDirListMenuItem
            // 
            clearAllDirListMenuItem.Name = "clearAllDirListMenuItem";
            clearAllDirListMenuItem.Size = new System.Drawing.Size(106, 22);
            clearAllDirListMenuItem.Text = "Clear All";
            clearAllDirListMenuItem.Click += ClearAll_DirList_MenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(103, 6);
            // 
            // exportDirListMenuItem
            // 
            exportDirListMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { exportCSV, exportJSON, exportXML });
            exportDirListMenuItem.Name = "exportDirListMenuItem";
            exportDirListMenuItem.Size = new System.Drawing.Size(106, 22);
            exportDirListMenuItem.Text = "Export to...";
            // 
            // exportCSV
            // 
            exportCSV.Name = "exportCSV";
            exportCSV.Size = new System.Drawing.Size(102, 22);
            exportCSV.Text = "CSV";
            // 
            // exportJSON
            // 
            exportJSON.Name = "exportJSON";
            exportJSON.Size = new System.Drawing.Size(102, 22);
            exportJSON.Text = "JSON";
            // 
            // exportXML
            // 
            exportXML.Name = "exportXML";
            exportXML.Size = new System.Drawing.Size(102, 22);
            exportXML.Text = "XML";
            // 
            // btnAddDirectory
            // 
            btnAddDirectory.Location = new System.Drawing.Point(14, 72);
            btnAddDirectory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnAddDirectory.Name = "btnAddDirectory";
            btnAddDirectory.Size = new System.Drawing.Size(102, 62);
            btnAddDirectory.TabIndex = 10;
            btnAddDirectory.Text = "Add Directory to Search";
            btnAddDirectory.UseVisualStyleBackColor = true;
            btnAddDirectory.Click += btnAddDirectory_Click;
            // 
            // btnClearDirectoryList
            // 
            btnClearDirectoryList.Location = new System.Drawing.Point(14, 141);
            btnClearDirectoryList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnClearDirectoryList.Name = "btnClearDirectoryList";
            btnClearDirectoryList.Size = new System.Drawing.Size(98, 47);
            btnClearDirectoryList.TabIndex = 20;
            btnClearDirectoryList.Text = "Clear Directory List";
            btnClearDirectoryList.UseVisualStyleBackColor = true;
            btnClearDirectoryList.Click += btnClearDirList_Click;
            // 
            // chkRemovePath
            // 
            chkRemovePath.AutoSize = true;
            chkRemovePath.Checked = true;
            chkRemovePath.CheckState = System.Windows.Forms.CheckState.Checked;
            chkRemovePath.Location = new System.Drawing.Point(849, 141);
            chkRemovePath.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chkRemovePath.Name = "chkRemovePath";
            chkRemovePath.Size = new System.Drawing.Size(167, 19);
            chkRemovePath.TabIndex = 30;
            chkRemovePath.Text = "Remove Path From Results";
            chkRemovePath.UseVisualStyleBackColor = true;
            chkRemovePath.CheckedChanged += chkRemovePath_CheckedChanged;
            // 
            // label2
            // 
            label2.Location = new System.Drawing.Point(24, 10);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(1031, 53);
            label2.TabIndex = 0;
            label2.Text = resources.GetString("label2.Text");
            // 
            // btnClearMovieList
            // 
            btnClearMovieList.Location = new System.Drawing.Point(975, 195);
            btnClearMovieList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnClearMovieList.Name = "btnClearMovieList";
            btnClearMovieList.Size = new System.Drawing.Size(84, 29);
            btnClearMovieList.TabIndex = 70;
            btnClearMovieList.Text = "Clear List";
            btnClearMovieList.UseVisualStyleBackColor = true;
            btnClearMovieList.Click += btnClearMovieList_Click;
            // 
            // dgvDirectories
            // 
            dgvDirectories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDirectories.Location = new System.Drawing.Point(14, 237);
            dgvDirectories.Name = "dgvDirectories";
            dgvDirectories.Size = new System.Drawing.Size(1045, 449);
            dgvDirectories.TabIndex = 71;
            // 
            // chkShowFiles
            // 
            chkShowFiles.AutoSize = true;
            chkShowFiles.Location = new System.Drawing.Point(849, 169);
            chkShowFiles.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chkShowFiles.Name = "chkShowFiles";
            chkShowFiles.Size = new System.Drawing.Size(81, 19);
            chkShowFiles.TabIndex = 72;
            chkShowFiles.Text = "Show Files";
            chkShowFiles.UseVisualStyleBackColor = true;
            chkShowFiles.CheckedChanged += chkShowFiles_CheckedChanged;
            // 
            // btnExport
            // 
            btnExport.Location = new System.Drawing.Point(845, 102);
            btnExport.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnExport.Name = "btnExport";
            btnExport.Size = new System.Drawing.Size(210, 30);
            btnExport.TabIndex = 73;
            btnExport.Text = "Export Results";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1070, 723);
            Controls.Add(btnExport);
            Controls.Add(chkShowFiles);
            Controls.Add(dgvDirectories);
            Controls.Add(btnClearMovieList);
            Controls.Add(label2);
            Controls.Add(chkRemovePath);
            Controls.Add(btnClearDirectoryList);
            Controls.Add(btnAddDirectory);
            Controls.Add(lstDirList);
            Controls.Add(lblMovies);
            Controls.Add(btnScanMovies);
            Controls.Add(txtFilter);
            Controls.Add(label1);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            dirListMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDirectories).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Button btnScanMovies;
        private System.Windows.Forms.Label lblMovies;
        private System.Windows.Forms.Button btnScanTV;
        private System.Windows.Forms.ListBox lstDirList;
        private System.Windows.Forms.Button btnAddDirectory;
        private System.Windows.Forms.Button btnClearDirectoryList;
        private System.Windows.Forms.CheckBox chkRemovePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClearMovieList;
        private System.Windows.Forms.ContextMenuStrip dirListMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem browseDirListMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeDirListMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem addDirListMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearAllDirListMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exportDirListMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportCSV;
        private System.Windows.Forms.ToolStripMenuItem exportJSON;
        private System.Windows.Forms.ToolStripMenuItem exportXML;
        private System.Windows.Forms.DataGridView dgvDirectories;
        private System.Windows.Forms.CheckBox chkShowFiles;
        private System.Windows.Forms.Button btnExport;
    }
}

