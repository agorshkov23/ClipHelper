using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace ClipHelper
{
    public partial class ClipHelperForm : Form
    {
        public ClipHelperForm()
        {
            InitializeComponent();
            UpdateStringListControl();
        }

        private void CopySelectedString()
        {
            if (StringListControl.SelectedItem is String selected)
            {
                Clipboard.SetText(selected);
            }
        }

        private void OpenSelectedString()
        {
            if (StringListControl.SelectedItem is String selected)
            {
                PreviewControl.Text = selected;
            }
        }

        private void UpdateStringListControl()
        {
            StringListControl.Items.Clear();
            if (!Directory.Exists(@".\strings"))
            {
                Directory.CreateDirectory(@".\strings");
            }
            foreach (var path in Directory.EnumerateFiles(@".\strings"))
            {
                if (path.ToLowerInvariant().EndsWith(".txt"))
                {
                    var content = File.ReadAllText(path);
                    StringListControl.Items.Add(content);
                }
            }
        }

        private void CreateNewFileMenuItem_Click(object sender, EventArgs e)
        {
            var path = @".\strings\" + DateTime.Now.ToString("yyyy-dd-MM HH-mm-ss") + ".txt";
            using (File.CreateText(path))
            {
            };
            Process.Start(path);
        }

        private void OpenDirectoryMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(@".\strings");
            UpdateStringListControl();
        }

        private void StringListControl_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            CopySelectedString();
        }

        private void StringListControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            OpenSelectedString();
        }

        private void UpdateMenuItem_Click(object sender, EventArgs e)
        {
            UpdateStringListControl();
        }
    }
}
