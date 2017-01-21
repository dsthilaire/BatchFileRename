using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatchFileRename
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbFiles_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void lbFiles_DragDrop(object sender, DragEventArgs e)
        {
            // Ensure that the list item index is contained in the data. 
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                var files = e.Data.GetData(DataFormats.FileDrop) as string[];
                lbFiles.Items.AddRange(files.Distinct().Where(f => !lbFiles.Items.Contains(f)).ToArray());
                lbFiles.TopIndex = lbFiles.Items.Count - 1;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                lbFiles.BeginUpdate();
                for (int i = lbFiles.SelectedItems.Count - 1; i >= 0; i--)
                    lbFiles.Items.Remove(lbFiles.SelectedItems[i]);
            }
            finally
            {
                lbFiles.EndUpdate();
            }
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            lbFiles.Items.Clear();
        }

        private bool GoodToGo()
        {
            if (txtFind.Text.Length == 0)
            {
                MessageBox.Show("No search string entered.");
                return false;
            }
            if (lbFiles.Items.Count == 0)
            {
                MessageBox.Show("No Input Files have been added.");
                return false;
            }
            return true;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (!GoodToGo())
                return;
            var find = txtFind.Text;
            var replace = txtReplace.Text;
            var removed = new List<string>();
            foreach (var path in lbFiles.Items.Cast<string>())
            {
                var filename = Path.GetFileNameWithoutExtension(path);
                var newName = "";
                if (find[0] == '/')
                {
                    // if starts with slash, treat as regex
                    var rx = new Regex(find.Substring(1));
                    newName = rx.Replace(filename, replace);
                }
                else
                {
                    newName = filename.Replace(find, replace);
                }
                var newPath = path.Replace(filename, newName);
                if (path != newPath)
                {
                    File.Move(path, newPath);
                    removed.Add(path);
                }
            }

            foreach (var path in removed)
            {
                lbFiles.Items.Remove(path);
            }
        }
    }
}
