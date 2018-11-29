using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using Text_Raffle.Properties;
using System.Media;

namespace Text_Raffle
{
    public partial class frmMain : Form
    {
        private List<string> entries, won;
        private bool jrun = false;
        private Random randomizer = new Random();
        private object syncL = new object();
        SoundPlayer ding = new SoundPlayer(Application.StartupPath + "\\sounds\\ding.wav");
        SoundPlayer cheer = new SoundPlayer(Application.StartupPath + "\\sounds\\cheer.wav");

        public frmMain()
        {
            InitializeComponent();
        }

        // Method for prompting won entries.
        private void queryMark()
        {
            if (jrun)
            {
                if (MessageBox.Show(this, "Mark entry as won?", "Winner", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    won.Add(lblWinner.Text);
                }
                jrun = false;
            }
        }

        // Loads a file to a list.
        private void loadFile()
        {
            entries = new List<string>();

            StreamReader reader = new StreamReader(@"C:\Raffle\Main.csv");
            string line = "";

            while (!reader.EndOfStream)
            {
                line = reader.ReadLine().Trim();
                if (line == "" || line.Contains("name") || line.Contains("Name"))
                {
                    continue;
                }

                var delimitedLine = line.Split(',');

                if ((delimitedLine[4].ToLower() == "yes") && (delimitedLine[1] != " " && delimitedLine[1] != "" && delimitedLine[1] != string.Empty) && (delimitedLine[2] != " " && delimitedLine[2] != "" && delimitedLine[2] != string.Empty))
                {
                    entries.Add(delimitedLine[1] + " " + delimitedLine[2]);
                }
            }

            txtSource.Text = "C:\\Raffle\\Main.csv";
            lblNumEntries.Text = entries.Count.ToString();
            btnStart.Enabled = true;
            btnStart.Visible = true;
        }

        // Random number generator
        public int randomNumber(int min, int max)
        {
            lock (syncL)
            {
                return randomizer.Next(min, max);
            }
        }

        // Handles the Load event of the frmMain control.
        // Turns the window into full screen, loads the saved settings, and initializes the main lists.
        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Bounds = Screen.PrimaryScreen.Bounds;
            won = new List<string>();
            if (!(Settings.Default["Won"] == null))
            {
                won = new List<string>(((string)Settings.Default["Won"]).Split('|'));
            }
            entries = new List<string>();

            btnStart.Enabled = false;
            btnStart.Visible = false;

            loadFile();
        }

        // Handles the Click event of the btnExit control. Exits the application.
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Handles the Click event of the btnStart control.
        private void btnStart_Click(object sender, EventArgs e)
        {
            queryMark();
            if (entries.Count < 2)
            {
                return;
            }

            tmMain.Interval = 10;
            tmMain.Enabled = true;
        }

        // Main timer that randomizes the names.
        private void tmMain_Tick(object sender, EventArgs e)
        {
            string entry = "";
            entry = entries[randomNumber(0, entries.Count)];
            while (won.Contains(entry, StringComparer.Ordinal) && won.Count > 1)
            {
                entry = entries[randomNumber(0, entries.Count)];
            }
            lblWinner.Text = entry;
            lblWinner.ForeColor = Color.Red;
            ding.Play();

            tmMain.Interval += 20;
            if (tmMain.Interval >= 550)
            {
                tmCtrl.Enabled = true;
            }
        }

        // Stopping timer, gradually slows (increases interval) randomizing.
        private void tmCtrl_Tick(object sender, EventArgs e)
        {
            cheer.Play();

            lblWinner.ForeColor = Color.Green;
            tmMain.Enabled = false;
            tmCtrl.Enabled = false;
            jrun = true;
        }

        // Handles the FormClosing event of the frmMain control. Saves the settings before closing.
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            queryMark();
            Settings.Default["Won"] = String.Join("|", won.ToArray());
            Settings.Default.Save();
        }

        private void btnStart_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, btnStart.ClientRectangle,
                                    SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
                                    SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
                                    SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
                                    SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }

        private void gbSource_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, gbSource.ClientRectangle,
                                    SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
                                    SystemColors.ControlLightLight, 0, ButtonBorderStyle.Outset,
                                    SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
                                    SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }

        // Opens up the won entry list.
        private void llView_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            queryMark();
            frmWon wonFrm = new frmWon();
            wonFrm.loadList(won);
            wonFrm.ShowDialog();
            won = new List<string>();
            won = wonFrm.updateList();
        }
    }
}
