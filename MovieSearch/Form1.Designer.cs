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
            lstMovies = new System.Windows.Forms.ListBox();
            label1 = new System.Windows.Forms.Label();
            txtFilter = new System.Windows.Forms.TextBox();
            lstFiltered = new System.Windows.Forms.ListBox();
            btnScanMovies = new System.Windows.Forms.Button();
            lblMovies = new System.Windows.Forms.Label();
            btnScanTV = new System.Windows.Forms.Button();
            lstDirList = new System.Windows.Forms.ListBox();
            dirListMenuStrip = new System.Windows.Forms.ContextMenuStrip(components);
            browseDirListMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            removeDirListMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            addDirListMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            clearAllDirListMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            btnAddDirectory = new System.Windows.Forms.Button();
            btnClear = new System.Windows.Forms.Button();
            chkRemovePath = new System.Windows.Forms.CheckBox();
            label2 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            dirListMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // lstMovies
            // 
            lstMovies.FormattingEnabled = true;
            lstMovies.ItemHeight = 15;
            lstMovies.Location = new System.Drawing.Point(14, 228);
            lstMovies.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            lstMovies.Name = "lstMovies";
            lstMovies.Size = new System.Drawing.Size(1041, 454);
            lstMovies.TabIndex = 0;
            lstMovies.TabStop = false;
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
            // lstFiltered
            // 
            lstFiltered.FormattingEnabled = true;
            lstFiltered.ItemHeight = 15;
            lstFiltered.Location = new System.Drawing.Point(14, 232);
            lstFiltered.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            lstFiltered.Name = "lstFiltered";
            lstFiltered.Size = new System.Drawing.Size(1041, 454);
            lstFiltered.TabIndex = 5;
            lstFiltered.TabStop = false;
            lstFiltered.Visible = false;
            // 
            // btnScanMovies
            // 
            btnScanMovies.Location = new System.Drawing.Point(849, 98);
            btnScanMovies.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnScanMovies.Name = "btnScanMovies";
            btnScanMovies.Size = new System.Drawing.Size(210, 44);
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
            // btnScanTV
            // 
            btnScanTV.Location = new System.Drawing.Point(849, 149);
            btnScanTV.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnScanTV.Name = "btnScanTV";
            btnScanTV.Size = new System.Drawing.Size(210, 43);
            btnScanTV.TabIndex = 50;
            btnScanTV.Text = "Scan Files";
            btnScanTV.UseVisualStyleBackColor = true;
            btnScanTV.Click += btnScanTV_Click;
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
            dirListMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { browseDirListMenuItem, removeDirListMenuItem, toolStripSeparator1, addDirListMenuItem, clearAllDirListMenuItem });
            dirListMenuStrip.Name = "dirListMenuStrip";
            dirListMenuStrip.ShowImageMargin = false;
            dirListMenuStrip.Size = new System.Drawing.Size(99, 98);
            dirListMenuStrip.Opening += DirList_ContextMenuStrip_Opening;
            // 
            // browseDirListMenuItem
            // 
            browseDirListMenuItem.Name = "browseDirListMenuItem";
            browseDirListMenuItem.Size = new System.Drawing.Size(98, 22);
            browseDirListMenuItem.Text = "Browse";
            browseDirListMenuItem.Click += Browse_DirList_MenuItem_Click;
            // 
            // removeDirListMenuItem
            // 
            removeDirListMenuItem.Name = "removeDirListMenuItem";
            removeDirListMenuItem.Size = new System.Drawing.Size(98, 22);
            removeDirListMenuItem.Text = "Remove";
            removeDirListMenuItem.Click += Remove_DirList_MenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(95, 6);
            // 
            // addDirListMenuItem
            // 
            addDirListMenuItem.Name = "addDirListMenuItem";
            addDirListMenuItem.Size = new System.Drawing.Size(98, 22);
            addDirListMenuItem.Text = "Add New";
            addDirListMenuItem.Click += Add_DirList_MenuItem_Click;
            // 
            // clearAllDirListMenuItem
            // 
            clearAllDirListMenuItem.Name = "clearAllDirListMenuItem";
            clearAllDirListMenuItem.Size = new System.Drawing.Size(98, 22);
            clearAllDirListMenuItem.Text = "Clear All";
            clearAllDirListMenuItem.Click += ClearAll_DirList_MenuItem_Click;
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
            // btnClear
            // 
            btnClear.Location = new System.Drawing.Point(14, 141);
            btnClear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(98, 47);
            btnClear.TabIndex = 20;
            btnClear.Text = "Clear Directory List";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // chkRemovePath
            // 
            chkRemovePath.AutoSize = true;
            chkRemovePath.Checked = true;
            chkRemovePath.CheckState = System.Windows.Forms.CheckState.Checked;
            chkRemovePath.Location = new System.Drawing.Point(878, 72);
            chkRemovePath.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chkRemovePath.Name = "chkRemovePath";
            chkRemovePath.Size = new System.Drawing.Size(167, 19);
            chkRemovePath.TabIndex = 30;
            chkRemovePath.Text = "Remove Path From Results";
            chkRemovePath.UseVisualStyleBackColor = true;
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
            // button1
            // 
            button1.Location = new System.Drawing.Point(975, 195);
            button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(84, 29);
            button1.TabIndex = 70;
            button1.Text = "Clear List";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1070, 723);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(chkRemovePath);
            Controls.Add(btnClear);
            Controls.Add(btnAddDirectory);
            Controls.Add(lstDirList);
            Controls.Add(btnScanTV);
            Controls.Add(lblMovies);
            Controls.Add(btnScanMovies);
            Controls.Add(lstFiltered);
            Controls.Add(txtFilter);
            Controls.Add(label1);
            Controls.Add(lstMovies);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            dirListMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox lstMovies;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.ListBox lstFiltered;
        private System.Windows.Forms.Button btnScanMovies;
        private System.Windows.Forms.Label lblMovies;
        private System.Windows.Forms.Button btnScanTV;
        private System.Windows.Forms.ListBox lstDirList;
        private System.Windows.Forms.Button btnAddDirectory;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox chkRemovePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip dirListMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem browseDirListMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeDirListMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem addDirListMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearAllDirListMenuItem;
    }
}

