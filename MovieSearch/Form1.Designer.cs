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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lstMovies = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.lstFiltered = new System.Windows.Forms.ListBox();
            this.btnScanMovies = new System.Windows.Forms.Button();
            this.lblMovies = new System.Windows.Forms.Label();
            this.btnScanTV = new System.Windows.Forms.Button();
            this.lstDirList = new System.Windows.Forms.ListBox();
            this.btnAddDirectory = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.chkRemovePath = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstMovies
            // 
            this.lstMovies.FormattingEnabled = true;
            this.lstMovies.Location = new System.Drawing.Point(12, 198);
            this.lstMovies.Name = "lstMovies";
            this.lstMovies.Size = new System.Drawing.Size(776, 329);
            this.lstMovies.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filter";
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(44, 164);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(717, 20);
            this.txtFilter.TabIndex = 3;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // lstFiltered
            // 
            this.lstFiltered.FormattingEnabled = true;
            this.lstFiltered.Location = new System.Drawing.Point(12, 214);
            this.lstFiltered.Name = "lstFiltered";
            this.lstFiltered.Size = new System.Drawing.Size(776, 329);
            this.lstFiltered.TabIndex = 5;
            this.lstFiltered.Visible = false;
            // 
            // btnScanMovies
            // 
            this.btnScanMovies.Location = new System.Drawing.Point(608, 44);
            this.btnScanMovies.Name = "btnScanMovies";
            this.btnScanMovies.Size = new System.Drawing.Size(180, 38);
            this.btnScanMovies.TabIndex = 6;
            this.btnScanMovies.Text = "Scan Directories";
            this.btnScanMovies.UseVisualStyleBackColor = true;
            this.btnScanMovies.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // lblMovies
            // 
            this.lblMovies.AutoSize = true;
            this.lblMovies.Location = new System.Drawing.Point(726, 546);
            this.lblMovies.Name = "lblMovies";
            this.lblMovies.Size = new System.Drawing.Size(57, 13);
            this.lblMovies.TabIndex = 7;
            this.lblMovies.Text = "0 Result(s)";
            // 
            // btnScanTV
            // 
            this.btnScanTV.Location = new System.Drawing.Point(608, 88);
            this.btnScanTV.Name = "btnScanTV";
            this.btnScanTV.Size = new System.Drawing.Size(180, 37);
            this.btnScanTV.TabIndex = 8;
            this.btnScanTV.Text = "Scan Files";
            this.btnScanTV.UseVisualStyleBackColor = true;
            this.btnScanTV.Click += new System.EventHandler(this.btnScanTV_Click);
            // 
            // lstDirList
            // 
            this.lstDirList.FormattingEnabled = true;
            this.lstDirList.Location = new System.Drawing.Point(117, 45);
            this.lstDirList.Name = "lstDirList";
            this.lstDirList.Size = new System.Drawing.Size(468, 69);
            this.lstDirList.TabIndex = 9;
            // 
            // btnAddDirectory
            // 
            this.btnAddDirectory.Location = new System.Drawing.Point(24, 44);
            this.btnAddDirectory.Name = "btnAddDirectory";
            this.btnAddDirectory.Size = new System.Drawing.Size(75, 62);
            this.btnAddDirectory.TabIndex = 10;
            this.btnAddDirectory.Text = "Add Directory to Search";
            this.btnAddDirectory.UseVisualStyleBackColor = true;
            this.btnAddDirectory.Click += new System.EventHandler(this.btnAddDirectory_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(24, 112);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(72, 25);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear List";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // chkRemovePath
            // 
            this.chkRemovePath.AutoSize = true;
            this.chkRemovePath.Checked = true;
            this.chkRemovePath.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRemovePath.Location = new System.Drawing.Point(117, 136);
            this.chkRemovePath.Name = "chkRemovePath";
            this.chkRemovePath.Size = new System.Drawing.Size(155, 17);
            this.chkRemovePath.TabIndex = 12;
            this.chkRemovePath.Text = "Remove Path From Results";
            this.chkRemovePath.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(21, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(767, 36);
            this.label2.TabIndex = 13;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 567);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkRemovePath);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAddDirectory);
            this.Controls.Add(this.lstDirList);
            this.Controls.Add(this.btnScanTV);
            this.Controls.Add(this.lblMovies);
            this.Controls.Add(this.btnScanMovies);
            this.Controls.Add(this.lstFiltered);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstMovies);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

