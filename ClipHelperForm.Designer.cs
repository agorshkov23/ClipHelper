namespace ClipHelper
{
    partial class ClipHelperForm
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
            this.components = new System.ComponentModel.Container();
            this.StringListControl = new System.Windows.Forms.ListBox();
            this.GroupBox = new System.Windows.Forms.GroupBox();
            this.PreviewControl = new System.Windows.Forms.TextBox();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.UpdateMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenDirectoryMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.CreateNewFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GroupBox.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // StringListControl
            // 
            this.StringListControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.StringListControl.FormattingEnabled = true;
            this.StringListControl.Location = new System.Drawing.Point(12, 27);
            this.StringListControl.Name = "StringListControl";
            this.StringListControl.Size = new System.Drawing.Size(338, 381);
            this.StringListControl.TabIndex = 0;
            this.StringListControl.SelectedIndexChanged += new System.EventHandler(this.StringListControl_SelectedIndexChanged);
            this.StringListControl.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.StringListControl_MouseDoubleClick);
            // 
            // GroupBox
            // 
            this.GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox.Controls.Add(this.PreviewControl);
            this.GroupBox.Location = new System.Drawing.Point(356, 27);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(351, 381);
            this.GroupBox.TabIndex = 1;
            this.GroupBox.TabStop = false;
            this.GroupBox.Text = "Предпросмотр";
            // 
            // PreviewControl
            // 
            this.PreviewControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PreviewControl.Location = new System.Drawing.Point(6, 19);
            this.PreviewControl.Multiline = true;
            this.PreviewControl.Name = "PreviewControl";
            this.PreviewControl.ReadOnly = true;
            this.PreviewControl.Size = new System.Drawing.Size(339, 356);
            this.PreviewControl.TabIndex = 0;
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UpdateMenuItem,
            this.OpenDirectoryMenuItem,
            this.CreateNewFileMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(719, 24);
            this.MenuStrip.TabIndex = 2;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // UpdateMenuItem
            // 
            this.UpdateMenuItem.Name = "UpdateMenuItem";
            this.UpdateMenuItem.Size = new System.Drawing.Size(73, 20);
            this.UpdateMenuItem.Text = "Обновить";
            this.UpdateMenuItem.Click += new System.EventHandler(this.UpdateMenuItem_Click);
            // 
            // OpenDirectoryMenuItem
            // 
            this.OpenDirectoryMenuItem.Name = "OpenDirectoryMenuItem";
            this.OpenDirectoryMenuItem.Size = new System.Drawing.Size(111, 20);
            this.OpenDirectoryMenuItem.Text = "Открыть каталог";
            this.OpenDirectoryMenuItem.Click += new System.EventHandler(this.OpenDirectoryMenuItem_Click);
            // 
            // NotifyIcon
            // 
            this.NotifyIcon.Text = "notifyIcon1";
            this.NotifyIcon.Visible = true;
            // 
            // CreateNewFileMenuItem
            // 
            this.CreateNewFileMenuItem.Name = "CreateNewFileMenuItem";
            this.CreateNewFileMenuItem.Size = new System.Drawing.Size(133, 20);
            this.CreateNewFileMenuItem.Text = "Создать новый файл";
            this.CreateNewFileMenuItem.Click += new System.EventHandler(this.CreateNewFileMenuItem_Click);
            // 
            // ClipHelperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 420);
            this.Controls.Add(this.GroupBox);
            this.Controls.Add(this.StringListControl);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "ClipHelperForm";
            this.Text = "ClipHelper";
            this.GroupBox.ResumeLayout(false);
            this.GroupBox.PerformLayout();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox StringListControl;
        private System.Windows.Forms.GroupBox GroupBox;
        private System.Windows.Forms.TextBox PreviewControl;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem UpdateMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenDirectoryMenuItem;
        private System.Windows.Forms.NotifyIcon NotifyIcon;
        private System.Windows.Forms.ToolStripMenuItem CreateNewFileMenuItem;
    }
}

