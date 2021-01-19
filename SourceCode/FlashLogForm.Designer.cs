
namespace FlashLog
{
    partial class FlashLogForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlashLogForm));
            this.pathTextbox = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logTextbox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearSavedPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionLabel = new System.Windows.Forms.Label();
            this.updateLogFileTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pathTextbox
            // 
            this.pathTextbox.Location = new System.Drawing.Point(80, 43);
            this.pathTextbox.Name = "pathTextbox";
            this.pathTextbox.ReadOnly = true;
            this.pathTextbox.Size = new System.Drawing.Size(365, 20);
            this.pathTextbox.TabIndex = 0;
            this.pathTextbox.TabStop = false;
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(461, 41);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 1;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.logTextbox);
            this.panel1.Location = new System.Drawing.Point(12, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(581, 432);
            this.panel1.TabIndex = 2;
            // 
            // logTextbox
            // 
            this.logTextbox.AllowDrop = true;
            this.logTextbox.Location = new System.Drawing.Point(3, 3);
            this.logTextbox.Multiline = true;
            this.logTextbox.Name = "logTextbox";
            this.logTextbox.ReadOnly = true;
            this.logTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.logTextbox.Size = new System.Drawing.Size(575, 426);
            this.logTextbox.TabIndex = 0;
            this.logTextbox.TabStop = false;
            this.logTextbox.DragDrop += new System.Windows.Forms.DragEventHandler(this.logTextbox_DragDrop);
            this.logTextbox.DragEnter += new System.Windows.Forms.DragEventHandler(this.logTextbox_DragEnter);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(605, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.BackColor = System.Drawing.Color.Lavender;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.BackColor = System.Drawing.Color.LightCoral;
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearSavedPathToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // clearSavedPathToolStripMenuItem
            // 
            this.clearSavedPathToolStripMenuItem.Name = "clearSavedPathToolStripMenuItem";
            this.clearSavedPathToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.clearSavedPathToolStripMenuItem.Text = "Clear Saved Path";
            this.clearSavedPathToolStripMenuItem.Click += new System.EventHandler(this.clearSavedPathToolStripMenuItem_Click);
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.versionLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.versionLabel.Location = new System.Drawing.Point(573, 520);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(28, 13);
            this.versionLabel.TabIndex = 4;
            this.versionLabel.Text = "v1.0";
            this.versionLabel.Click += new System.EventHandler(this.versionLabel_Click);
            // 
            // FlashLogForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(605, 537);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.pathTextbox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FlashLogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FlashLog";
            this.Load += new System.EventHandler(this.FlashLogForm_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.logTextbox_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.logTextbox_DragEnter);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pathTextbox;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox logTextbox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearSavedPathToolStripMenuItem;
        private System.Windows.Forms.Timer updateLogFileTimer;
    }
}

