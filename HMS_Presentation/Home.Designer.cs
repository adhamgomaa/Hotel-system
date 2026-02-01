namespace HMS_Presentation
{
    partial class Home
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelSide = new System.Windows.Forms.Panel();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnReserve = new System.Windows.Forms.Button();
            this.btnRoom = new System.Windows.Forms.Button();
            this.btnClient = new System.Windows.Forms.Button();
            this.btnBoard = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel6 = new System.Windows.Forms.Panel();
            this.ctrlDashboard1 = new HMS_Presentation.Controls.ctrlDashboard();
            this.ctrlClient1 = new HMS_Presentation.Controls.ctrlClient();
            this.ctrlRoom1 = new HMS_Presentation.Controls.ctrlRoom();
            this.ctrlReservation1 = new HMS_Presentation.Controls.ctrlReservation();
            this.ctrlSettings1 = new HMS_Presentation.Controls.ctrlSettings();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.panel1.Controls.Add(this.panelSide);
            this.panel1.Controls.Add(this.btnSetting);
            this.panel1.Controls.Add(this.btnReserve);
            this.panel1.Controls.Add(this.btnRoom);
            this.panel1.Controls.Add(this.btnClient);
            this.panel1.Controls.Add(this.btnBoard);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 714);
            this.panel1.TabIndex = 1;
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.White;
            this.panelSide.Location = new System.Drawing.Point(10, 197);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(10, 45);
            this.panelSide.TabIndex = 8;
            // 
            // btnSetting
            // 
            this.btnSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.Image = global::HMS_Presentation.Properties.Resources.setting__1_;
            this.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.Location = new System.Drawing.Point(24, 432);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(286, 54);
            this.btnSetting.TabIndex = 7;
            this.btnSetting.Text = "Settings";
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnReserve
            // 
            this.btnReserve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReserve.FlatAppearance.BorderSize = 0;
            this.btnReserve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReserve.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReserve.Image = global::HMS_Presentation.Properties.Resources.reserved__1_;
            this.btnReserve.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReserve.Location = new System.Drawing.Point(24, 372);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(286, 54);
            this.btnReserve.TabIndex = 6;
            this.btnReserve.Text = "Reservations";
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // btnRoom
            // 
            this.btnRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRoom.FlatAppearance.BorderSize = 0;
            this.btnRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoom.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoom.Image = global::HMS_Presentation.Properties.Resources.room__1_;
            this.btnRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoom.Location = new System.Drawing.Point(24, 312);
            this.btnRoom.Name = "btnRoom";
            this.btnRoom.Size = new System.Drawing.Size(286, 54);
            this.btnRoom.TabIndex = 5;
            this.btnRoom.Text = "Rooms";
            this.btnRoom.UseVisualStyleBackColor = true;
            this.btnRoom.Click += new System.EventHandler(this.btnRoom_Click);
            // 
            // btnClient
            // 
            this.btnClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClient.FlatAppearance.BorderSize = 0;
            this.btnClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClient.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClient.Image = global::HMS_Presentation.Properties.Resources.user__3_;
            this.btnClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClient.Location = new System.Drawing.Point(24, 252);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(286, 54);
            this.btnClient.TabIndex = 4;
            this.btnClient.Text = "Clients";
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // btnBoard
            // 
            this.btnBoard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBoard.FlatAppearance.BorderSize = 0;
            this.btnBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBoard.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoard.Image = global::HMS_Presentation.Properties.Resources.dashboard__2_;
            this.btnBoard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBoard.Location = new System.Drawing.Point(24, 192);
            this.btnBoard.Name = "btnBoard";
            this.btnBoard.Size = new System.Drawing.Size(286, 54);
            this.btnBoard.TabIndex = 3;
            this.btnBoard.Text = "Dashboard";
            this.btnBoard.UseVisualStyleBackColor = true;
            this.btnBoard.Click += new System.EventHandler(this.btnBoard_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(310, 182);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 61);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hotel Management System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HMS_Presentation.Properties.Resources.home__2_;
            this.pictureBox2.Location = new System.Drawing.Point(106, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(105, 98);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.panel4.Controls.Add(this.lblUsername);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(310, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(921, 182);
            this.panel4.TabIndex = 3;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(33, 116);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(128, 26);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Welcome: ?";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.lblDate);
            this.panel5.Controls.Add(this.linkLabel1);
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(921, 74);
            this.panel5.TabIndex = 0;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.lblDate.Location = new System.Drawing.Point(16, 38);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(24, 26);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "?";
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.linkLabel1.Location = new System.Drawing.Point(810, 35);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(79, 26);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Logout";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HMS_Presentation.Properties.Resources.user_logout;
            this.pictureBox1.Location = new System.Drawing.Point(739, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.ctrlDashboard1);
            this.panel6.Controls.Add(this.ctrlClient1);
            this.panel6.Controls.Add(this.ctrlRoom1);
            this.panel6.Controls.Add(this.ctrlReservation1);
            this.panel6.Controls.Add(this.ctrlSettings1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(310, 182);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(921, 532);
            this.panel6.TabIndex = 4;
            // 
            // ctrlDashboard1
            // 
            this.ctrlDashboard1.BackColor = System.Drawing.Color.White;
            this.ctrlDashboard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlDashboard1.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlDashboard1.Location = new System.Drawing.Point(0, 0);
            this.ctrlDashboard1.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlDashboard1.Name = "ctrlDashboard1";
            this.ctrlDashboard1.Size = new System.Drawing.Size(921, 532);
            this.ctrlDashboard1.TabIndex = 0;
            // 
            // ctrlClient1
            // 
            this.ctrlClient1.BackColor = System.Drawing.Color.White;
            this.ctrlClient1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlClient1.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlClient1.ForeColor = System.Drawing.Color.Black;
            this.ctrlClient1.Location = new System.Drawing.Point(0, 0);
            this.ctrlClient1.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlClient1.Name = "ctrlClient1";
            this.ctrlClient1.Size = new System.Drawing.Size(921, 532);
            this.ctrlClient1.TabIndex = 0;
            this.ctrlClient1.Visible = false;
            // 
            // ctrlRoom1
            // 
            this.ctrlRoom1.BackColor = System.Drawing.Color.White;
            this.ctrlRoom1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlRoom1.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlRoom1.ForeColor = System.Drawing.Color.Black;
            this.ctrlRoom1.Location = new System.Drawing.Point(0, 0);
            this.ctrlRoom1.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlRoom1.Name = "ctrlRoom1";
            this.ctrlRoom1.Size = new System.Drawing.Size(921, 532);
            this.ctrlRoom1.TabIndex = 0;
            this.ctrlRoom1.Visible = false;
            // 
            // ctrlReservation1
            // 
            this.ctrlReservation1.BackColor = System.Drawing.Color.White;
            this.ctrlReservation1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlReservation1.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlReservation1.ForeColor = System.Drawing.Color.Black;
            this.ctrlReservation1.Location = new System.Drawing.Point(0, 0);
            this.ctrlReservation1.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlReservation1.Name = "ctrlReservation1";
            this.ctrlReservation1.Size = new System.Drawing.Size(921, 532);
            this.ctrlReservation1.TabIndex = 0;
            this.ctrlReservation1.Visible = false;
            // 
            // ctrlSettings1
            // 
            this.ctrlSettings1.BackColor = System.Drawing.Color.White;
            this.ctrlSettings1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlSettings1.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlSettings1.ForeColor = System.Drawing.Color.Black;
            this.ctrlSettings1.Location = new System.Drawing.Point(0, 0);
            this.ctrlSettings1.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlSettings1.Name = "ctrlSettings1";
            this.ctrlSettings1.Size = new System.Drawing.Size(921, 532);
            this.ctrlSettings1.TabIndex = 0;
            this.ctrlSettings1.Visible = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 714);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnBoard;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Button btnRoom;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel6;
        private Controls.ctrlSettings ctrlSettings1;
        private Controls.ctrlReservation ctrlReservation1;
        private Controls.ctrlRoom ctrlRoom1;
        private Controls.ctrlClient ctrlClient1;
        private Controls.ctrlDashboard ctrlDashboard1;
    }
}

