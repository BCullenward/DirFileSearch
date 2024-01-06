using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.ComponentModel;

namespace MovieSearch
{
    public partial class Form1 : Form
    {

        private DataTable dt = new DataTable();
        private MediaContext db = new MediaContext();
        private enum ScanType
        {
            Directories,
            Files
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void ClearDirList()
        {
            lstDirList.Items.Clear();
        }

        private void AddDirectory()
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string dir = fbd.SelectedPath;
                    if (dir.Substring(dir.Length - 1) != @"\")
                    {
                        dir = dir + @"\";
                    }
                    lstDirList.Items.Add(dir);
                }
            }
            lstDirList.Sorted = true;
        }

        private string removeFilePath(string sFileName)
        {
            try
            {
                foreach (string path in lstDirList.Items)
                {
                    if (sFileName.IndexOf(path) >= 0)
                    {
                        sFileName = sFileName.Substring(path.Length);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return sFileName;
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string filter = txtFilter.Text;
            if (filter == String.Empty)
            {
                lstMovies.DataSource = dt;
            }
            else
            {
                DataTable dtFilteredTable = new DataTable();
                DataTable dtEmpty = new DataTable();
                dtEmpty.Columns.Add(new DataColumn("MovieTitle"));
                DataRow dr = dtEmpty.NewRow();
                dr[0] = String.Empty;
                dtEmpty.Rows.Add(dr);

                var rows = dt.AsEnumerable()
                        .Where(row => row.Field<string>("MovieTitle").ToUpper().Contains(filter.ToUpper()))
                        .OrderBy(row => row.Field<string>("MovieTitle"));

                dtFilteredTable = rows.Any() ? rows.CopyToDataTable() : dtEmpty.Clone();

                lstMovies.DataSource = dtFilteredTable;
            }
            lblMovies.Text = string.Format("{0} Result{1}", lstMovies.Items.Count.ToString(), lstMovies.Items.Count == 1 ? "(s)" : "");
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            ScanFolders(ScanType.Directories);
        }

        private void EmptyMovies()
        {
            dt.Rows.Clear();
        }

        private void ScanFolders(ScanType scanType)
        {
            try
            {
                List<string> lines = new List<string>();
                List<string> paths = new List<string>();
                EmptyMovies();

                foreach (string path in lstDirList.Items)
                {
                    foreach (string dir in Directory.EnumerateDirectories(path))
                    {
                        if (scanType == ScanType.Files)
                        {
                            foreach (string file in Directory.EnumerateFiles(dir, "*.*", SearchOption.AllDirectories))
                            {
                                DataRow dr = dt.NewRow();
                                if (chkRemovePath.Checked)
                                {
                                    dr[0] = removeFilePath(file);
                                }
                                else
                                {
                                    dr[0] = file;
                                }
                                dt.Rows.Add(dr);
                            }
                        }
                        else
                        {
                            DataRow dr = dt.NewRow();
                            dr[0] = removeFilePath(dir);

                            dt.Rows.Add(dr);
                        }

                    }
                }
                lstMovies.DataSource = dt;
                lstMovies.ValueMember = "MovieTitle";
                lstMovies.DisplayMember = "MovieTitle";
                lblMovies.Text = string.Format("{0} Result{1}", lstMovies.Items.Count.ToString(), lstMovies.Items.Count == 1 ? "(s)" : "");
                SortDataTable();
                MessageBox.Show("Loaded!");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SortDataTable()
        {
            DataView dv = dt.DefaultView;
            dv.Sort = "MovieTitle asc";
            dt = dv.ToTable();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dt.Columns.Add(new DataColumn("MovieTitle"));
            db.SearchPaths.ToList().ForEach(m => lstDirList.Items.Add(m.Directory));
            lstDirList.Sorted = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            db.SearchPaths.RemoveRange(db.SearchPaths);
            db.SaveChanges();
            foreach (string path in lstDirList.Items)
            {
                db.SearchPaths.Add(new SearchPaths { Directory = path });
            }
            db.SaveChanges();
        }

        private void btnScanTV_Click(object sender, EventArgs e)
        {
            ScanFolders(ScanType.Files);
        }

        private void btnAddDirectory_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string dir = fbd.SelectedPath;
                    if (dir.Substring(dir.Length -1) != @"\")
                    {
                        dir = dir + @"\";
                    }
                    lstDirList.Items.Add(dir);
                }
            }
            lstDirList.Sorted = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearDirList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmptyMovies();
        }
        private void DirList_ContextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            if (lstDirList.SelectedItem == null)
                e.Cancel = true;
        }

        private void lstDirList_MouseDown(object sender, MouseEventArgs e)
        {
            lstDirList.SelectedIndex = lstDirList.IndexFromPoint(e.X, e.Y);
        }
        private void Browse_DirList_MenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", lstDirList.SelectedItem.ToString());
        }

        private void Remove_DirList_MenuItem_Click(object sender, EventArgs e)
        {
            var item = lstDirList.SelectedItem;
            if (item != null)
            {
                lstDirList.Items.Remove(item);
            }
        }

        private void Add_DirList_MenuItem_Click(object sender, EventArgs e)
        {
            AddDirectory();
        }

        private void ClearAll_DirList_MenuItem_Click(object sender, EventArgs e)
        {
            ClearDirList();
        }

    }
}
