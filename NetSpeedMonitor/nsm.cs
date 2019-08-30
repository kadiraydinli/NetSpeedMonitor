using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using Echevil;

namespace NetSpeedMonitor
{
    public partial class nsm : Form
    {
        public nsm()
        {
            InitializeComponent();
        }

        private NetworkAdapter[] adapters;
        private NetworkMonitor monitor;

        RegistryKey register = Registry.CurrentUser.OpenSubKey("Software", true);

        bool allBool = false;

        private void nsm_Load(object sender, EventArgs e)
        {
            cursorTimer.Start();
            try
            {
                int x = Screen.PrimaryScreen.WorkingArea.Right - this.Width;
                int y = Screen.PrimaryScreen.WorkingArea.Bottom - this.Height;
                Location = new Point(x, y);

                monitor = new NetworkMonitor();
                adapters = monitor.Adapters;
                if (adapters.Length == 0)
                {
                    list.Enabled = false;
                    MessageBox.Show("No network adapters found on this computer.");
                    return;
                }

                list.Items.AddRange(adapters);
                list.SelectedIndex = Convert.ToInt16(Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("KadirAydinli").GetValue("network"));
            }
            catch
            {
                register.CreateSubKey("KadirAydinli").SetValue("start", 1);
            }
        }
        double down, up; string downS, upS;
        private void download_Paint(object sender, PaintEventArgs e)
        {
            down = Convert.ToDouble(download.Text);
            downS = download.Text;
            if (down <=2.0)
                download.ForeColor = System.Drawing.Color.Red;
            else if (down >= 2.0 && down <= 3.9)
                download.ForeColor = System.Drawing.Color.DarkOrange;
            else if (down >= 4.0 && down <= 4.9)
                download.ForeColor = System.Drawing.Color.Gold;
            else if (down >= 5.0)
                download.ForeColor = System.Drawing.Color.Lime;

            if (download.Text.Length == 5)
            {
                download.Font = new Font("OCR A Extended", 20, FontStyle.Bold);
                download.Location = new System.Drawing.Point(-1, 21);
                txt.Text = "kbps/s";
            }
            else if (download.Text.Length == 6)
            {
                download.Font = new Font("OCR A Extended", 15, FontStyle.Bold);
                download.Location = new System.Drawing.Point(-1, 26);
                txt.Text = "kbps/s";
            }
            else if (download.Text.Length >= 7)
            {
                download.Font = new Font("OCR A Extended", 15, FontStyle.Bold);
                download.Location = new System.Drawing.Point(-1, 16);
                txt.Text = "mbps/s";
                download.Text = downS.Substring(0, 4);
            }
            else
            {
                download.Font = new Font("OCR A Extended", 25, FontStyle.Bold);
                download.Location = new System.Drawing.Point(-1, 16);
                txt.Text = "kbps/s";
            }  
        }

        private void upload_Paint(object sender, PaintEventArgs e)
        {
            upS = upload.Text;
            up = Convert.ToDouble(upload.Text);
            if (up <= 2.0)
                upload.ForeColor = System.Drawing.Color.Red;
            else if (up >= 2.0 && up <= 3.9)
                upload.ForeColor = System.Drawing.Color.DarkOrange;
            else if (up >= 4.0 && up <= 4.9)
                upload.ForeColor = System.Drawing.Color.Gold;
            else if (up >= 5.0)
                upload.ForeColor = System.Drawing.Color.Lime;

            if (upload.Text.Length == 5)
            {
                upload.Font = new Font("OCR A Extended", 20, FontStyle.Bold);
                upload.Location = new System.Drawing.Point(-1, 78);
            }
            else if (upload.Text.Length == 6)
            {
                upload.Font = new Font("OCR A Extended", 15, FontStyle.Bold);
                upload.Location = new System.Drawing.Point(-1, 83);
            }
            else if (upload.Text.Length >= 7)
            {
                upload.Font = new Font("OCR A Extended", 15, FontStyle.Bold);
                upload.Location = new System.Drawing.Point(-1, 73);
                upload.Text = upS.Substring(0, 4);
                txt1.Text = "mbps/s";
            }
            else
            {
                upload.Font = new Font("OCR A Extended", 25, FontStyle.Bold);
                upload.Location = new System.Drawing.Point(-1, 73);
            }
        }
        double d = 0, u = 0;

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ben_MouseHover(object sender, EventArgs e)
        {
            Opacity = 1D;
            exit.Visible = false;
            aboutPanel.Visible = true;
            homePanel.Visible = false;
        }

        private void ben_MouseLeave(object sender, EventArgs e)
        {
            exit.Visible = true;
            aboutPanel.Visible = false;
            homePanel.Visible = true;
        }

        private void homePanel_MouseHover(object sender, EventArgs e)
        {
            Opacity = 1D;
            exit.Visible = true;
            hoverPanel.Visible = true;
            //homePanel.Visible = true;
        }

        private void hoverPanel_MouseLeave(object sender, EventArgs e)
        {
            hoverPanel.Visible = false;
            homePanel.Visible = true;
        }

        private void cursorTimer_Tick(object sender, EventArgs e)
        {
            if ((Cursor.Position.X >= Location.X && Cursor.Position.X <= Location.X + 200) && Cursor.Position.Y >= Location.Y && Cursor.Position.Y <= Location.Y + 125)
            {
                Opacity = 1D;
                exit.Visible = true;
                nextB.Visible = true;
            }
            else
            {
                Opacity = 0.7D;
                i = 0;
                exit.Visible = false;
                homePanel.Visible = true;
                hoverPanel.Visible = false;
                nextB.Visible = false;
                aboutPanel.Visible = false;
                backB.Visible = false;
                networksPanel.Visible = false;
                centerB.Visible = false;
            }
        }
        bool dragging; Point offset;
        private void nsm_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            offset = e.Location;
        }

        private void nsm_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
            if (Location.X <= 0)
            {
                Location = new Point(0, Location.Y);
            }
            else if (Location.X + 200 >= Screen.PrimaryScreen.Bounds.Width)
            {
                Location = new Point(Screen.PrimaryScreen.Bounds.Width - 200, Location.Y);
            }
            else if (Location.Y <= 0)
            {
                Location = new Point(Location.X, 0);
            }
            else if ((Location.X <= 40 && Location.Y <= 40) || (Location.X <= 0 || Location.Y <= 0)) 
            {
                Location = new Point(0, 0);
            }
        }

        private void nsm_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new
                Point(currentScreenPos.X - offset.X,
                currentScreenPos.Y - offset.Y);
                register.CreateSubKey("KadirAydinli").SetValue("LocX", Location.X);
                register.CreateSubKey("KadirAydinli").SetValue("LocY", Location.Y);
            }
           
        }
        byte i = 0;
        private void nextB_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                homePanel.Visible = false;
                hoverPanel.Visible = true;
                centerB.Visible = true;
                backB.Visible = true;
                centerB.Text = "RESET";
                allBool = true;
                i++;
            }
            else if (i == 1)
            {
                hoverPanel.Visible = false;
                networksPanel.Visible = true;
                centerB.Text = "HOME";
                allBool = false;
                i++;
            }
            else if (i == 2)
            {
                networksPanel.Visible = false;
                aboutPanel.Visible = true;
                centerB.Visible = false;
                i++;
            }
            else if (i == 3)
            {
                aboutPanel.Visible = false;
                backB.Visible = false;
                homePanel.Visible = true;
                i = 0;
            }
        }

        private void centerB_Click(object sender, EventArgs e)
        {
            if (centerB.Text == "RESET")
            {
                register.CreateSubKey("KadirAydinli").SetValue("download", 0);
                register.CreateSubKey("KadirAydinli").SetValue("upload", 0);
                MessageBox.Show("");
            }
            else if (centerB.Text == "HOME")
            {
                centerB.Visible = false;
                backB.Visible = false;
                networksPanel.Visible = false;
                homePanel.Visible = true;
                i = 0;
            }
        }

        private void backB_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                homePanel.Visible = false;
                hoverPanel.Visible = true;
                centerB.Visible = true;
                backB.Visible = true;
                i++;
            }
            else if (i == 1)
            {
                hoverPanel.Visible = false;
                centerB.Visible = false;
                homePanel.Visible = true;
                backB.Visible = false;
                allBool = false;
                i--;
            }
            else if (i == 2)
            {
                networksPanel.Visible = false;
                hoverPanel.Visible = true;
                centerB.Visible = true;
                centerB.Text = "RESET";
                allBool = true;
                i--;
            }
            else if (i == 3)
            {
                aboutPanel.Visible = false;
                networksPanel.Visible = true;
                centerB.Text = "HOME";
                centerB.Visible = true;
                allBool = false;
                i--;
            }
        }

        private void time_Tick(object sender, EventArgs e)
        {
            NetworkAdapter adapter = adapters[list.SelectedIndex];
            //d += adapter.DownloadSpeedKbps;
            //u += adapter.UploadSpeedKbps;
            download.Text = String.Format("{0:n}", adapter.DownloadSpeedKbps);
            upload.Text = String.Format("{0:n}", adapter.UploadSpeedKbps);
            d += Convert.ToDouble(download.Text);
            u += Convert.ToDouble(upload.Text);
            register.CreateSubKey("KadirAydinli").SetValue("download", d);
            register.CreateSubKey("KadirAydinli").SetValue("upload", u);
            if (allBool == true)
            {
                allD.Text = register.CreateSubKey("KadirAydinli").GetValue("download").ToString();
                allU.Text = register.CreateSubKey("KadirAydinli").GetValue("upload").ToString();
            }
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            monitor.StopMonitoring();
            monitor.StartMonitoring(adapters[list.SelectedIndex]);
            register.CreateSubKey("KadirAydinli").SetValue("network", list.SelectedIndex);
            time.Start();
        }
    }
}
