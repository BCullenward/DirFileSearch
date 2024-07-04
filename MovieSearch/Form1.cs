using Microsoft.EntityFrameworkCore.Storage.Json;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Windows.Forms;
using System.Xml.Linq;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MovieSearch
{

    public partial class Form1 : Form
    {
        private DataTable dt = new();
        private MediaContext db = new();
        private DataAccess da = new();

        public Form1()
        {
            InitializeComponent();
            dt.Columns.Add(new DataColumn("RootDirectoryName"));
            dt.Columns.Add(new DataColumn("ParentDirectoryName"));
            dt.Columns.Add(new DataColumn("DirectoryName"));
            dt.Columns.Add(new DataColumn("FileName"));
            dt.Columns.Add(new DataColumn("Extension"));
            dt.Columns.Add(new DataColumn("FileSize"));
            dt.Columns.Add(new DataColumn("FullPath"));
            dt.DefaultView.Sort = "DirectoryName asc";
            dgvDirectories.DataSource = dt;
        }

        private void ClearDirList()
        {
            da.ClearDirectories();
            lstDirList.Items.Clear();
        }

        private void ClearMovieList()
        {
            dt.Clear();
            lblMovies.Text = "0 Result(s)";
        }

        private void SetColumnVisibility()
        {
            dgvDirectories.Columns["RootDirectoryName"].Visible = !chkRemovePath.Checked;
            dgvDirectories.Columns["DirectoryName"].Visible = chkShowFiles.Checked;
            dgvDirectories.Columns["FileName"].Visible = chkShowFiles.Checked;
            dgvDirectories.Columns["Extension"].Visible = chkShowFiles.Checked;
            dgvDirectories.Columns["FileSize"].Visible = chkShowFiles.Checked;
            dgvDirectories.Columns["FullPath"].Visible = chkShowFiles.Checked;
        }

        private void UpdateMovieListBinding()
        {
            SetColumnVisibility();

            string filter = ReplaceSpecialCharacters(txtFilter.Text);


            if (!chkShowFiles.Checked)
            {
                DataTable distinctValues = new DataTable();
                distinctValues = (DataTable)dt.AsEnumerable()
                    .GroupBy(r => new { ParentDirectoryName = r.Field<string>("ParentDirectoryName") })
                    .Select(g => g.First()).Distinct()
                    .OrderBy(n => n["ParentDirectoryName"]).CopyToDataTable();

                distinctValues.DefaultView.RowFilter = string.Format("ParentDirectoryName LIKE '%{0}%'", filter);
                dgvDirectories.DataSource = distinctValues;
            }
            else
            {
                //dt.DefaultView.RowFilter = string.Format("ParentDirectoryName LIKE '%{0}%'", filter);
                dt.DefaultView.RowFilter = string.Format("DirectoryName LIKE '%{0}%'", filter);
                dgvDirectories.DataSource = dt;
            }

            lblMovies.Text = String.Format("{0} Result{1}", dgvDirectories.Rows.Count.ToString("n0", CultureInfo.CurrentCulture),
                           dgvDirectories.Rows.Count == 1 ? "" : "(s)");
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            UpdateMovieListBinding();
        }


        private string ReplaceSpecialCharacters(string line)
        {
            line = line.Replace("'", "''");
            line = line.Replace("[", "[[]");
            line = line.Replace("%", "[%]");
            line = line.Replace("*", "[*]");
            return line;
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            Cursor cur = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            ScanFolders();
            Cursor.Current = cur;
        }

        private void ScanFolders()
        {
            //ScanType scanType
            try
            {
                bool onlyMedia = false;
                var extList = new List<string> { ".mp4", ".avi", ".mkv", ".webm" , ".mpeg", ".mpg", ".m4v", ".vob", ".wmv", ".flv"};

                dt.Rows.Clear();
                ClearMovieList();
                foreach (String path in lstDirList.Items)
                    foreach (String dir in Directory.EnumerateDirectories(path))
                    {
                        foreach (string file in Directory.EnumerateFiles(dir, "*.*", SearchOption.AllDirectories))
                        {
                            FileInfo fi = new FileInfo(file);
                            string ext = fi.Extension.ToLower();

                            int result = extList.IndexOf(ext);

                            if (!onlyMedia)
                                result = 0;

                            if (result != -1)
                            {
                                DataRow dr = dt.NewRow();
                                dr[0] = path;
                                dr[1] = dir.Replace(path, "");
                                dr[2] = fi.DirectoryName.Replace(path, "");
                                dr[3] = fi.Name;
                                dr[4] = fi.Extension.ToLower();
                                dr[5] = fi.Length;
                                dr[6] = fi.FullName;
                                dt.Rows.Add(dr);
                            }
                        }
                    }

                UpdateMovieListBinding();
                MessageBox.Show("Loaded!");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            db.SearchPaths.ToList().ForEach(m => { lstDirList.Items.Add(m.Directory); });
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            db.SearchPaths.RemoveRange(db.SearchPaths);
            db.SaveChanges();

            foreach (String path in lstDirList.Items)
            {
                da.AddDirectory(path);
            }
            db.SaveChanges();
        }



        private void btnAddDirectory_Click(object sender, EventArgs e)
        {
            String lstItem = da.AddDirectory();
            if (!String.IsNullOrEmpty(lstItem))
            {
                lstDirList.Items.Add(lstItem);
            }
            lstDirList.Sorted = true;
        }

        private void btnClearDirList_Click(object sender, EventArgs e)
        {
            ClearDirList();
        }

        private void btnClearMovieList_Click(object sender, EventArgs e)
        {
            ClearMovieList();
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
            Object item = lstDirList.SelectedItem;
            if (item != null) lstDirList.Items.Remove(da.RemoveDirectory(item.ToString()));
        }

        private void Add_DirList_MenuItem_Click(object sender, EventArgs e)
        {
            String lstItem = da.AddDirectory();
            if (!String.IsNullOrEmpty(lstItem))
            {
                lstDirList.Items.Add(lstItem);
            }
        }

        private void ClearAll_DirList_MenuItem_Click(object sender, EventArgs e)
        {
            ClearDirList();
        }

        private void chkRemovePath_CheckedChanged(object sender, EventArgs e)
        {
            UpdateMovieListBinding();
        }

        private void chkShowFiles_CheckedChanged(object sender, EventArgs e)
        {
            UpdateMovieListBinding();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            DataTable dtFullPath = dt.Clone();
            dtFullPath = dt.Copy();

            //dtFullPath.Columns.Remove("RootDirectoryName");

            //dtFullPath.Columns.Remove("DirectoryName");
            //dtFullPath.Columns.Remove("FileName");
            //dtFullPath.Columns.Remove("Extension");
            //dtFullPath.Columns.Remove("FileSize");
            dtFullPath.DefaultView.Sort = "FileName";
            dtFullPath = dtFullPath.DefaultView.ToTable();

            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "json(*.json)|*.json|txt(*.txt)|*.txt";            
            saveFile.ShowDialog();

            FileInfo fi = new FileInfo(saveFile.FileName);
            if (fi.Extension.ToLower() == ".txt")
            {

                using (StreamWriter sw = new StreamWriter(saveFile.FileName))
                {
                    foreach (DataRow dr in dtFullPath.Rows)
                    {
                        //sw.WriteLine(dr["ParentDirectoryName"]);
                        sw.WriteLine(dr["FileName"]);
                    }
                }
            }
            else if (fi.Extension.ToLower() == ".json")
            {
                string JSONresults = JsonConvert.SerializeObject(dtFullPath, Formatting.Indented);

                if (saveFile.FileName != String.Empty)
                {
                    StreamWriter sw = new StreamWriter(saveFile.FileName);
                    sw.WriteLine(JSONresults);
                    sw.Close();
                }
            }
        }
    }
}