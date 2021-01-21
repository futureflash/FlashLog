using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Ude;
using AutoUpdaterDotNET;

namespace FlashLog
{
    public partial class FlashLogForm : Form
    {
        private Properties.Settings savedPath = Properties.Settings.Default;

        public FlashLogForm()
        {
            InitializeComponent();
            updateLogFileTimer.Tick += updateLogFileMethod;
            updateLogFileTimer.Interval = 100;
        }


        private void browseButton_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.FileName = "log.txt";
                openFileDialog1.Filter = "Text File|*.txt|Log File|*.log";
                openFileDialog1.FilterIndex = 1;
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string logFile = openFileDialog1.FileName;
                    string readLogFile = File.ReadAllText(logFile);
                    using (FileStream fs = File.OpenRead(logFile))
                    {
                        CharsetDetector cdet = new CharsetDetector();
                        cdet.Feed(fs);
                        cdet.DataEnd();
                        if (cdet.Charset != null || readLogFile.Length == 0)
                        {
                            pathTextbox.Text = logFile;
                            logTextbox.Text = readLogFile;
                            savedPath.lastUsedPath = logFile;
                            savedPath.Save();
                            updateLogFileTimer.Start();
                            this.Size = new Size(621, 576);
                            versionLabel.Location = new Point(573, 520);
                            versionLabel.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("The file you provided is not a valid text file", "Encoding Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch { }
        }

        private void updateLogFileMethod(object sender, EventArgs e)
        {
            try
            {
                if (savedPath.lastUsedPath.Length > 1 || File.Exists(savedPath.lastUsedPath))
                {
                    try
                    {
                        string logFile = savedPath.lastUsedPath;
                        string readLogFile = File.ReadAllText(logFile);
                        logTextbox.Text = readLogFile;
                        versionLabel.Enabled = true;
                    }
                    catch (IOException)
                    {
                        updateLogFileTimer.Stop();
                        MessageBox.Show("The file you're trying to access is in use or has been renamed. Click OK and browse for your file again to remove errors", "Critical Error: File In Use", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Size = new Size(621, 121);
                        versionLabel.Location = new Point(571, 65);
                        pathTextbox.Text = "Click 'Browse' and locate your log file";
                        logTextbox.BackColor = SystemColors.Info;
                        logTextbox.Cursor = Cursors.IBeam;
                        toolsToolStripMenuItem.Visible = false;
                        versionLabel.Enabled = false;
                    }
                }
            }
            catch (FileNotFoundException)
            {
                updateLogFileTimer.Stop();
                MessageBox.Show("The last log you opened was not found.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Size = new Size(621, 121);
                versionLabel.Location = new Point(571, 65);
                pathTextbox.Text = "Click 'Browse' and locate your log file";
                logTextbox.BackColor = SystemColors.Info;
                logTextbox.Cursor = Cursors.IBeam;
                toolsToolStripMenuItem.Visible = false;
                versionLabel.Enabled = false;
            }
            if (savedPath.lastUsedPath.Length < 1)
            {
                updateLogFileTimer.Stop();
            }
        }

        private void FlashLogForm_Load(object sender, EventArgs e)
        {
            AutoUpdater.Start("https://github.com/laithayoub71/FlashLog/master/Update.xml");


            if (savedPath.lastUsedPath.Length > 1 && File.Exists(savedPath.lastUsedPath))
            {
                toolsToolStripMenuItem.Visible = false;
                updateLogFileTimer.Start();
                string logFile = savedPath.lastUsedPath;
                string readLogFile = File.ReadAllText(logFile);
                pathTextbox.Text = logFile;
                logTextbox.Text = readLogFile;
                this.Size = new Size(621, 576);
                versionLabel.Location = new Point(573, 520);
                logTextbox.BackColor = SystemColors.Info;
                logTextbox.Cursor = Cursors.IBeam;
                toolsToolStripMenuItem.Visible = true;
                versionLabel.Enabled = true;
            }
            else if (savedPath.lastUsedPath.Length > 1 && !File.Exists(savedPath.lastUsedPath))
            {
                MessageBox.Show("The last log you opened was not found.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Size = new Size(621, 121);
                versionLabel.Location = new Point(571, 65);
                pathTextbox.Text = "Click 'Browse' and locate your log file";
                logTextbox.BackColor = SystemColors.Info;
                logTextbox.Cursor = Cursors.IBeam;
                toolsToolStripMenuItem.Visible = false;
                versionLabel.Enabled = false;
            }
            else
            {
                this.Size = new Size(621, 121);
                versionLabel.Location = new Point(571, 65);
                pathTextbox.Text = "Click 'Browse' and locate your log file";
                logTextbox.BackColor = SystemColors.Info;
                logTextbox.Cursor = Cursors.IBeam;
                toolsToolStripMenuItem.Visible = false;
                versionLabel.Enabled = false;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("FlashLog is a simple program that reads your log file of choice, and dynamically updates when the log file has been changed\r\n------------------------------------------------------------------------------\r\n\r\nHow to Use:\r\n\r\n1. Click 'Browse' and locate your log file. That's it lol\r\n\r\nThe program will then display your log file and will update automatically every half second\r\n\r\n------------------------------------------------------------------------------\r\n\r\nCreated by FutureFlash on 1/18/2021", "FlashLog (v1.1)", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void clearSavedPathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            savedPath.lastUsedPath = "";
            savedPath.Save();
            pathTextbox.Text = "Click 'Browse' and locate your log file";
            toolsToolStripMenuItem.Visible = false;
            this.Size = new Size(621, 121);
            versionLabel.Location = new Point(571, 65);
            versionLabel.Enabled = false;
            logTextbox.Clear();
        }

        private void logTextbox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void logTextbox_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                string readLogFile = File.ReadAllText(file);
                var ext = Path.GetExtension(file);
                using (FileStream fs = File.OpenRead(file))
                {
                    CharsetDetector cdet = new CharsetDetector();
                    cdet.Feed(fs);
                    cdet.DataEnd();
                    if (cdet.Charset != null || readLogFile.Length == 0)
                    {
                        pathTextbox.Text = file;
                        logTextbox.Text = readLogFile;
                        savedPath.lastUsedPath = file;
                        savedPath.Save();
                        updateLogFileTimer.Start();
                        this.Size = new Size(621, 576);
                        versionLabel.Location = new Point(573, 520);
                    }
                    else
                    {
                        MessageBox.Show("The file you're trying to drag is invalid. Only these extensions are supported: .txt | .log", "Invalid File Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void versionLabel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Character count: " + logTextbox.Text.Count(line => !string.IsNullOrWhiteSpace(line.ToString())) + " (spaces not included)", "Character Count", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}