namespace NetSpeedMonitor
{
    partial class nsm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nsm));
            this.download = new System.Windows.Forms.Label();
            this.list = new System.Windows.Forms.ListBox();
            this.upload = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Timer(this.components);
            this.netT = new System.Windows.Forms.Label();
            this.downloadT = new System.Windows.Forms.Label();
            this.uploadT = new System.Windows.Forms.Label();
            this.txt = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.Label();
            this.homePanel = new System.Windows.Forms.Panel();
            this.networksPanel = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.Button();
            this.aboutPanel = new System.Windows.Forms.Panel();
            this.hoverPanel = new System.Windows.Forms.Panel();
            this.allTimeTxt = new System.Windows.Forms.Label();
            this.allDT = new System.Windows.Forms.Label();
            this.allD = new System.Windows.Forms.Label();
            this.allU = new System.Windows.Forms.Label();
            this.txt3 = new System.Windows.Forms.Label();
            this.allUT = new System.Windows.Forms.Label();
            this.txt2 = new System.Windows.Forms.Label();
            this.centerB = new System.Windows.Forms.Button();
            this.cursorTimer = new System.Windows.Forms.Timer(this.components);
            this.nextB = new System.Windows.Forms.Button();
            this.backB = new System.Windows.Forms.Button();
            this.homePanel.SuspendLayout();
            this.networksPanel.SuspendLayout();
            this.hoverPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // download
            // 
            this.download.AutoSize = true;
            this.download.Font = new System.Drawing.Font("OCR A Extended", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.download.ForeColor = System.Drawing.Color.Lime;
            this.download.Location = new System.Drawing.Point(15, 17);
            this.download.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.download.Name = "download";
            this.download.Size = new System.Drawing.Size(105, 37);
            this.download.TabIndex = 0;
            this.download.Text = "0,00";
            this.download.Paint += new System.Windows.Forms.PaintEventHandler(this.download_Paint);
            this.download.MouseDown += new System.Windows.Forms.MouseEventHandler(this.nsm_MouseDown);
            this.download.MouseMove += new System.Windows.Forms.MouseEventHandler(this.nsm_MouseMove);
            this.download.MouseUp += new System.Windows.Forms.MouseEventHandler(this.nsm_MouseUp);
            // 
            // list
            // 
            this.list.BackColor = System.Drawing.Color.Black;
            this.list.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.list.Cursor = System.Windows.Forms.Cursors.Default;
            this.list.ForeColor = System.Drawing.SystemColors.Window;
            this.list.FormattingEnabled = true;
            this.list.HorizontalScrollbar = true;
            this.list.Location = new System.Drawing.Point(2, 22);
            this.list.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(186, 54);
            this.list.TabIndex = 1;
            this.list.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.list.MouseDown += new System.Windows.Forms.MouseEventHandler(this.nsm_MouseDown);
            this.list.MouseMove += new System.Windows.Forms.MouseEventHandler(this.nsm_MouseMove);
            this.list.MouseUp += new System.Windows.Forms.MouseEventHandler(this.nsm_MouseUp);
            // 
            // upload
            // 
            this.upload.AutoSize = true;
            this.upload.Font = new System.Drawing.Font("OCR A Extended", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upload.ForeColor = System.Drawing.Color.Red;
            this.upload.Location = new System.Drawing.Point(15, 73);
            this.upload.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.upload.Name = "upload";
            this.upload.Size = new System.Drawing.Size(95, 35);
            this.upload.TabIndex = 2;
            this.upload.Text = "0,00";
            this.upload.Paint += new System.Windows.Forms.PaintEventHandler(this.upload_Paint);
            this.upload.MouseDown += new System.Windows.Forms.MouseEventHandler(this.nsm_MouseDown);
            this.upload.MouseMove += new System.Windows.Forms.MouseEventHandler(this.nsm_MouseMove);
            this.upload.MouseUp += new System.Windows.Forms.MouseEventHandler(this.nsm_MouseUp);
            // 
            // time
            // 
            this.time.Interval = 1000;
            this.time.Tick += new System.EventHandler(this.time_Tick);
            // 
            // netT
            // 
            this.netT.AutoSize = true;
            this.netT.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.netT.ForeColor = System.Drawing.Color.Gold;
            this.netT.Location = new System.Drawing.Point(-3, 5);
            this.netT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.netT.Name = "netT";
            this.netT.Size = new System.Drawing.Size(71, 13);
            this.netT.TabIndex = 3;
            this.netT.Text = "NETWORKS";
            this.netT.MouseDown += new System.Windows.Forms.MouseEventHandler(this.nsm_MouseDown);
            this.netT.MouseMove += new System.Windows.Forms.MouseEventHandler(this.nsm_MouseMove);
            this.netT.MouseUp += new System.Windows.Forms.MouseEventHandler(this.nsm_MouseUp);
            // 
            // downloadT
            // 
            this.downloadT.AutoSize = true;
            this.downloadT.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadT.ForeColor = System.Drawing.Color.Chocolate;
            this.downloadT.Location = new System.Drawing.Point(18, 0);
            this.downloadT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.downloadT.Name = "downloadT";
            this.downloadT.Size = new System.Drawing.Size(88, 17);
            this.downloadT.TabIndex = 4;
            this.downloadT.Text = "DOWNLOAD";
            this.downloadT.MouseDown += new System.Windows.Forms.MouseEventHandler(this.nsm_MouseDown);
            this.downloadT.MouseMove += new System.Windows.Forms.MouseEventHandler(this.nsm_MouseMove);
            this.downloadT.MouseUp += new System.Windows.Forms.MouseEventHandler(this.nsm_MouseUp);
            // 
            // uploadT
            // 
            this.uploadT.AutoSize = true;
            this.uploadT.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadT.ForeColor = System.Drawing.Color.ForestGreen;
            this.uploadT.Location = new System.Drawing.Point(18, 57);
            this.uploadT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uploadT.Name = "uploadT";
            this.uploadT.Size = new System.Drawing.Size(68, 17);
            this.uploadT.TabIndex = 5;
            this.uploadT.Text = "UPLOAD";
            this.uploadT.MouseDown += new System.Windows.Forms.MouseEventHandler(this.nsm_MouseDown);
            this.uploadT.MouseMove += new System.Windows.Forms.MouseEventHandler(this.nsm_MouseMove);
            this.uploadT.MouseUp += new System.Windows.Forms.MouseEventHandler(this.nsm_MouseUp);
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt.ForeColor = System.Drawing.SystemColors.Control;
            this.txt.Location = new System.Drawing.Point(116, 32);
            this.txt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(55, 13);
            this.txt.TabIndex = 6;
            this.txt.Text = "kbps/s";
            this.txt.MouseDown += new System.Windows.Forms.MouseEventHandler(this.nsm_MouseDown);
            this.txt.MouseMove += new System.Windows.Forms.MouseEventHandler(this.nsm_MouseMove);
            this.txt.MouseUp += new System.Windows.Forms.MouseEventHandler(this.nsm_MouseUp);
            // 
            // txt1
            // 
            this.txt1.AutoSize = true;
            this.txt1.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1.ForeColor = System.Drawing.SystemColors.Control;
            this.txt1.Location = new System.Drawing.Point(116, 87);
            this.txt1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(55, 13);
            this.txt1.TabIndex = 7;
            this.txt1.Text = "kbps/s";
            this.txt1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.nsm_MouseDown);
            this.txt1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.nsm_MouseMove);
            this.txt1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.nsm_MouseUp);
            // 
            // homePanel
            // 
            this.homePanel.Controls.Add(this.downloadT);
            this.homePanel.Controls.Add(this.download);
            this.homePanel.Controls.Add(this.upload);
            this.homePanel.Controls.Add(this.txt1);
            this.homePanel.Controls.Add(this.uploadT);
            this.homePanel.Controls.Add(this.txt);
            this.homePanel.Location = new System.Drawing.Point(8, 9);
            this.homePanel.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(190, 120);
            this.homePanel.TabIndex = 10;
            this.homePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.nsm_MouseDown);
            this.homePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.nsm_MouseMove);
            this.homePanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.nsm_MouseUp);
            // 
            // networksPanel
            // 
            this.networksPanel.Controls.Add(this.netT);
            this.networksPanel.Controls.Add(this.list);
            this.networksPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.networksPanel.Location = new System.Drawing.Point(8, 9);
            this.networksPanel.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.networksPanel.Name = "networksPanel";
            this.networksPanel.Size = new System.Drawing.Size(190, 80);
            this.networksPanel.TabIndex = 11;
            this.networksPanel.Visible = false;
            this.networksPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.nsm_MouseDown);
            this.networksPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.nsm_MouseMove);
            this.networksPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.nsm_MouseUp);
            // 
            // exit
            // 
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.exit.ForeColor = System.Drawing.Color.Red;
            this.exit.Location = new System.Drawing.Point(180, 0);
            this.exit.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(20, 20);
            this.exit.TabIndex = 100;
            this.exit.Text = "X";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Visible = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            this.exit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.nsm_MouseDown);
            this.exit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.nsm_MouseMove);
            this.exit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.nsm_MouseUp);
            // 
            // aboutPanel
            // 
            this.aboutPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("aboutPanel.BackgroundImage")));
            this.aboutPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.aboutPanel.Location = new System.Drawing.Point(8, 9);
            this.aboutPanel.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.aboutPanel.Name = "aboutPanel";
            this.aboutPanel.Size = new System.Drawing.Size(190, 80);
            this.aboutPanel.TabIndex = 15;
            this.aboutPanel.Visible = false;
            this.aboutPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.nsm_MouseDown);
            this.aboutPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.nsm_MouseMove);
            this.aboutPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.nsm_MouseUp);
            // 
            // hoverPanel
            // 
            this.hoverPanel.Controls.Add(this.allTimeTxt);
            this.hoverPanel.Controls.Add(this.allDT);
            this.hoverPanel.Controls.Add(this.allD);
            this.hoverPanel.Controls.Add(this.allU);
            this.hoverPanel.Controls.Add(this.txt3);
            this.hoverPanel.Controls.Add(this.allUT);
            this.hoverPanel.Controls.Add(this.txt2);
            this.hoverPanel.Location = new System.Drawing.Point(8, 9);
            this.hoverPanel.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.hoverPanel.Name = "hoverPanel";
            this.hoverPanel.Size = new System.Drawing.Size(190, 80);
            this.hoverPanel.TabIndex = 16;
            this.hoverPanel.Visible = false;
            this.hoverPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.nsm_MouseDown);
            this.hoverPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.nsm_MouseMove);
            this.hoverPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.nsm_MouseUp);
            // 
            // allTimeTxt
            // 
            this.allTimeTxt.AutoSize = true;
            this.allTimeTxt.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allTimeTxt.ForeColor = System.Drawing.Color.Beige;
            this.allTimeTxt.Location = new System.Drawing.Point(65, 0);
            this.allTimeTxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.allTimeTxt.Name = "allTimeTxt";
            this.allTimeTxt.Size = new System.Drawing.Size(61, 12);
            this.allTimeTxt.TabIndex = 20;
            this.allTimeTxt.Text = "ALL TIME";
            this.allTimeTxt.MouseDown += new System.Windows.Forms.MouseEventHandler(this.nsm_MouseDown);
            this.allTimeTxt.MouseMove += new System.Windows.Forms.MouseEventHandler(this.nsm_MouseMove);
            this.allTimeTxt.MouseUp += new System.Windows.Forms.MouseEventHandler(this.nsm_MouseUp);
            // 
            // allDT
            // 
            this.allDT.AutoSize = true;
            this.allDT.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allDT.ForeColor = System.Drawing.Color.Chocolate;
            this.allDT.Location = new System.Drawing.Point(17, 17);
            this.allDT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.allDT.Name = "allDT";
            this.allDT.Size = new System.Drawing.Size(61, 12);
            this.allDT.TabIndex = 16;
            this.allDT.Text = "DOWNLOAD";
            this.allDT.MouseDown += new System.Windows.Forms.MouseEventHandler(this.nsm_MouseDown);
            this.allDT.MouseMove += new System.Windows.Forms.MouseEventHandler(this.nsm_MouseMove);
            this.allDT.MouseUp += new System.Windows.Forms.MouseEventHandler(this.nsm_MouseUp);
            // 
            // allD
            // 
            this.allD.AutoSize = true;
            this.allD.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allD.ForeColor = System.Drawing.Color.Lime;
            this.allD.Location = new System.Drawing.Point(9, 32);
            this.allD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.allD.Name = "allD";
            this.allD.Size = new System.Drawing.Size(77, 29);
            this.allD.TabIndex = 14;
            this.allD.Text = "0,00";
            this.allD.MouseDown += new System.Windows.Forms.MouseEventHandler(this.nsm_MouseDown);
            this.allD.MouseMove += new System.Windows.Forms.MouseEventHandler(this.nsm_MouseMove);
            this.allD.MouseUp += new System.Windows.Forms.MouseEventHandler(this.nsm_MouseUp);
            // 
            // allU
            // 
            this.allU.AutoSize = true;
            this.allU.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allU.ForeColor = System.Drawing.Color.Red;
            this.allU.Location = new System.Drawing.Point(105, 32);
            this.allU.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.allU.Name = "allU";
            this.allU.Size = new System.Drawing.Size(77, 29);
            this.allU.TabIndex = 15;
            this.allU.Text = "0,00";
            this.allU.MouseDown += new System.Windows.Forms.MouseEventHandler(this.nsm_MouseDown);
            this.allU.MouseMove += new System.Windows.Forms.MouseEventHandler(this.nsm_MouseMove);
            this.allU.MouseUp += new System.Windows.Forms.MouseEventHandler(this.nsm_MouseUp);
            // 
            // txt3
            // 
            this.txt3.AutoSize = true;
            this.txt3.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt3.ForeColor = System.Drawing.SystemColors.Control;
            this.txt3.Location = new System.Drawing.Point(120, 61);
            this.txt3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(47, 12);
            this.txt3.TabIndex = 19;
            this.txt3.Text = "kbps/s";
            this.txt3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.nsm_MouseDown);
            this.txt3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.nsm_MouseMove);
            this.txt3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.nsm_MouseUp);
            // 
            // allUT
            // 
            this.allUT.AutoSize = true;
            this.allUT.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allUT.ForeColor = System.Drawing.Color.ForestGreen;
            this.allUT.Location = new System.Drawing.Point(120, 17);
            this.allUT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.allUT.Name = "allUT";
            this.allUT.Size = new System.Drawing.Size(47, 12);
            this.allUT.TabIndex = 17;
            this.allUT.Text = "UPLOAD";
            this.allUT.MouseDown += new System.Windows.Forms.MouseEventHandler(this.nsm_MouseDown);
            this.allUT.MouseMove += new System.Windows.Forms.MouseEventHandler(this.nsm_MouseMove);
            this.allUT.MouseUp += new System.Windows.Forms.MouseEventHandler(this.nsm_MouseUp);
            // 
            // txt2
            // 
            this.txt2.AutoSize = true;
            this.txt2.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt2.ForeColor = System.Drawing.SystemColors.Control;
            this.txt2.Location = new System.Drawing.Point(24, 61);
            this.txt2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(47, 12);
            this.txt2.TabIndex = 18;
            this.txt2.Text = "kbps/s";
            this.txt2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.nsm_MouseDown);
            this.txt2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.nsm_MouseMove);
            this.txt2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.nsm_MouseUp);
            // 
            // centerB
            // 
            this.centerB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.centerB.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.centerB.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.centerB.Location = new System.Drawing.Point(24, 95);
            this.centerB.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.centerB.Name = "centerB";
            this.centerB.Size = new System.Drawing.Size(151, 30);
            this.centerB.TabIndex = 13;
            this.centerB.Text = "RESET";
            this.centerB.UseVisualStyleBackColor = true;
            this.centerB.Visible = false;
            this.centerB.Click += new System.EventHandler(this.centerB_Click);
            this.centerB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.nsm_MouseDown);
            this.centerB.MouseMove += new System.Windows.Forms.MouseEventHandler(this.nsm_MouseMove);
            this.centerB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.nsm_MouseUp);
            // 
            // cursorTimer
            // 
            this.cursorTimer.Interval = 10;
            this.cursorTimer.Tick += new System.EventHandler(this.cursorTimer_Tick);
            // 
            // nextB
            // 
            this.nextB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextB.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nextB.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.nextB.Location = new System.Drawing.Point(180, 95);
            this.nextB.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.nextB.Name = "nextB";
            this.nextB.Size = new System.Drawing.Size(20, 30);
            this.nextB.TabIndex = 103;
            this.nextB.Text = ">";
            this.nextB.UseVisualStyleBackColor = true;
            this.nextB.Visible = false;
            this.nextB.Click += new System.EventHandler(this.nextB_Click);
            this.nextB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.nsm_MouseDown);
            this.nextB.MouseMove += new System.Windows.Forms.MouseEventHandler(this.nsm_MouseMove);
            this.nextB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.nsm_MouseUp);
            // 
            // backB
            // 
            this.backB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backB.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.backB.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.backB.Location = new System.Drawing.Point(0, 95);
            this.backB.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.backB.Name = "backB";
            this.backB.Size = new System.Drawing.Size(20, 30);
            this.backB.TabIndex = 104;
            this.backB.Text = "<";
            this.backB.UseVisualStyleBackColor = true;
            this.backB.Visible = false;
            this.backB.Click += new System.EventHandler(this.backB_Click);
            this.backB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.nsm_MouseDown);
            this.backB.MouseMove += new System.Windows.Forms.MouseEventHandler(this.nsm_MouseMove);
            this.backB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.nsm_MouseUp);
            // 
            // nsm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(200, 125);
            this.Controls.Add(this.nextB);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.backB);
            this.Controls.Add(this.centerB);
            this.Controls.Add(this.hoverPanel);
            this.Controls.Add(this.aboutPanel);
            this.Controls.Add(this.networksPanel);
            this.Controls.Add(this.homePanel);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(500, 500);
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "nsm";
            this.Opacity = 0.7D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "NSM";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.nsm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.nsm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.nsm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.nsm_MouseUp);
            this.homePanel.ResumeLayout(false);
            this.homePanel.PerformLayout();
            this.networksPanel.ResumeLayout(false);
            this.networksPanel.PerformLayout();
            this.hoverPanel.ResumeLayout(false);
            this.hoverPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label download;
        private System.Windows.Forms.ListBox list;
        private System.Windows.Forms.Label upload;
        private System.Windows.Forms.Timer time;
        private System.Windows.Forms.Label netT;
        private System.Windows.Forms.Label downloadT;
        private System.Windows.Forms.Label uploadT;
        private System.Windows.Forms.Label txt;
        private System.Windows.Forms.Label txt1;
        private System.Windows.Forms.Panel homePanel;
        private System.Windows.Forms.Panel networksPanel;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Panel aboutPanel;
        private System.Windows.Forms.Panel hoverPanel;
        private System.Windows.Forms.Label allDT;
        private System.Windows.Forms.Label allD;
        private System.Windows.Forms.Label allU;
        private System.Windows.Forms.Label txt3;
        private System.Windows.Forms.Label allUT;
        private System.Windows.Forms.Label txt2;
        private System.Windows.Forms.Button centerB;
        private System.Windows.Forms.Label allTimeTxt;
        private System.Windows.Forms.Timer cursorTimer;
        private System.Windows.Forms.Button nextB;
        private System.Windows.Forms.Button backB;
    }
}

