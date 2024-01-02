using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace MovieSearch
{
    public partial class Form1 : Form
    {

        private DataTable dt = new DataTable();
        private enum ScanType
        {
            Directories,
            Files
        }

        public Form1()
        {
            InitializeComponent();
        }

        //private void btnLoad_Click(object sender, EventArgs e)
        //{
        //    using (var selectFileDialog = new OpenFileDialog())
        //    {
        //        selectFileDialog.Filter = "TXT files (*.txt)|*.txt;|CSV files (*.csv)|*.csv";
        //        if (selectFileDialog.ShowDialog() == DialogResult.OK)
        //        {
        //            lblFileLoc.Text = selectFileDialog.FileName;
        //            LoadFile();
        //        }
        //    }
        //}

        //private void LoadFile()
        //{
        //    try
        //    {
        //        List<string> lines = new List<string>();
        //        EmptyMovies();
        //        using (StreamReader r = new StreamReader(lblFileLoc.Text))
        //        {
        //            string line;
        //            dt.Columns.Add(new DataColumn("MovieTitle"));

        //            while ((line = r.ReadLine()) != null)
        //            {
        //                DataRow dr = dt.NewRow();
        //                dr[0] = removeFilePath(line);

        //                dt.Rows.Add(dr);
        //            }
        //        }
        //        lstMovies.DataSource = dt;
        //        lstMovies.ValueMember = "MovieTitle";
        //        lstMovies.DisplayMember = "MovieTitle";
        //        lblMovies.Text = string.Format("{0} Movies", lstMovies.Items.Count.ToString());

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

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
                    //sFileName = Regex.Replace(sFileName, path, string.Empty, RegexOptions.IgnoreCase);
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
            lblMovies.Text = string.Format("{0} Movies", lstMovies.Items.Count.ToString());
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            ScanFolders(ScanType.Directories);
        }

        private void EmptyMovies()
        {
            List<string> empty = new List<string>();
            lstMovies.DataSource = empty;
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
                lblMovies.Text = string.Format("{0} Result(s)", lstMovies.Items.Count.ToString());
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
            lstDirList.Items.Add(@"F:\MOVIES\");
            lstDirList.Items.Add(@"H:\MOVIES\");
            lstDirList.Items.Add(@"J:\MOVIES-Sleaze\");
            lstDirList.Items.Add(@"E:\MOVIES\");
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
            lstDirList.Items.Clear();
            lstMovies.DataSource = null;
            lstMovies.Items.Clear();
            lstFiltered.Items.Clear();
        }

    }
}
