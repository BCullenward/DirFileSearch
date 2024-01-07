using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MovieSearch;

public class DataAccess
{
    public String AddDirectory()
    {
        String path = "";
        using (FolderBrowserDialog fbd = new FolderBrowserDialog())
        {
            DialogResult result = fbd.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                path = fbd.SelectedPath;
                if (path.Substring(path.Length - 1) != @"\") path = path + @"\";

                using (MediaContext db = new MediaContext())
                {
                    if (db.SearchPaths.Any(x => x.Directory == path))
                        return null;
                    db.SearchPaths.Add(new SearchPaths { Directory = path });
                    db.SaveChanges();
                }
            }
        }

        return path;
    }

    public String AddDirectory(string path)
    {
        using (MediaContext db = new MediaContext())
        {
            if (db.SearchPaths.Any(x => x.Directory == path))
                return null;
            db.SearchPaths.Add(new SearchPaths { Directory = path });
            db.SaveChanges();
        }

        return path;
    }

    public String RemoveDirectory(string path)
    {
        using (MediaContext db = new MediaContext())
        {
            db.SearchPaths.RemoveRange(db.SearchPaths.Where(x => x.Directory == path));
            db.SaveChanges();
        }
        return path;
    }

    public void ClearDirectories()
    {
        using (MediaContext db = new MediaContext())
        {
            db.SearchPaths.RemoveRange(db.SearchPaths);
            db.SaveChanges();
        }
    }

    public void AddMovie(string path)
    {
        using (MediaContext db = new MediaContext())
        {
            db.Media.Add(new Media { Path = path, Title = Path.GetFileNameWithoutExtension(path) });
            db.SaveChanges();
        }
    }
}