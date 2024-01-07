using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Windows.Forms;

namespace MovieSearch;

public partial class Form1 : Form
{
    private DataTable dt = new();
    private MediaContext db = new();
    private DataAccess da = new();

    private enum ScanType
    {
        Directories,
        Files
    }

    public Form1()
    {
        InitializeComponent();
        dt.Columns.Add(new DataColumn("MovieTitle"));
        dt.DefaultView.Sort = "MovieTitle asc";
    }

    private void ClearDirList()
    {
        da.ClearDirectories();
        lstDirList.Items.Clear();
    }

    private void ClearMovieList()
    {
        lstMovies.DataSource = null;
        lstMovies.Items.Clear();
        lblMovies.Text = "0 Result(s)";
    }

    private void UpdateMovieListBinding()
    {
        lstMovies.DataSource = dt;
        lstMovies.ValueMember = "MovieTitle";
        lstMovies.DisplayMember = "MovieTitle";
        lblMovies.Text = String.Format("{0} Result{1}", lstMovies.Items.Count.ToString(),
                       lstMovies.Items.Count == 1 ? "" : "(s)");
    }

    private string removeFilePath(string sFileName)
    {
        try
        {
            foreach (string path in lstDirList.Items)
                if (sFileName.IndexOf(path) >= 0)
                    sFileName = sFileName.Substring(path.Length);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }

        return sFileName;
    }

    private void txtFilter_TextChanged(object sender, EventArgs e)
    {
        dt.DefaultView.RowFilter = string.Format("MovieTitle LIKE '%{0}%'", txtFilter.Text);
        UpdateMovieListBinding();

        lblMovies.Text = String.Format("{0} Result{1}", dt.DefaultView.Count.ToString(),
            lstMovies.Items.Count == 1 ? "" : "(s)");
    }

    private void btnScan_Click(object sender, EventArgs e)
    {
        ScanFolders(ScanType.Directories);
    }

    private void ScanFolders(ScanType scanType)
    {
        try
        {
            ClearMovieList();
            foreach (String path in lstDirList.Items)
                foreach (String dir in Directory.EnumerateDirectories(path))
                    if (scanType == ScanType.Files)
                    {
                        foreach (String file in Directory.EnumerateFiles(dir, "*.*", SearchOption.AllDirectories))
                        {
                            DataRow dr = dt.NewRow();
                            if (chkRemovePath.Checked)
                                dr[0] = removeFilePath(file);
                            else
                                dr[0] = file;
                            dt.Rows.Add(dr);
                        }
                    }
                    else
                    {
                        DataRow dr = dt.NewRow();
                        dr[0] = removeFilePath(dir);

                        dt.Rows.Add(dr);
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
        foreach (String path in lstDirList.Items) lstDirList.Items.Add(da.AddDirectory(path));
        db.SaveChanges();
    }

    private void btnScanTV_Click(object sender, EventArgs e)
    {
        ScanFolders(ScanType.Files);
    }

    private void btnAddDirectory_Click(object sender, EventArgs e)
    {
        String lstItem = da.AddDirectory();
        if (!String.IsNullOrEmpty(lstItem))
        {
            lstDirList.Items.Add(lstItem);
        }
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
        ClearDirList();
    }

    private void button1_Click(object sender, EventArgs e)
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
}