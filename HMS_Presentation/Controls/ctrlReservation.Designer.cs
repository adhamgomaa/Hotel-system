namespace HMS_Presentation.Controls
{
    partial class ctrlReservation
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpAdd = new System.Windows.Forms.TabPage();
            this.dtOut = new System.Windows.Forms.DateTimePicker();
            this.dtIn = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbRoomNo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtClinetID = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tpSearch = new System.Windows.Forms.TabPage();
            this.dgvReservation = new System.Windows.Forms.DataGridView();
            this.txtSearchClinetID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tpUpdate = new System.Windows.Forms.TabPage();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.dtOut2 = new System.Windows.Forms.DateTimePicker();
            this.dtIn2 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbRoomNo2 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbType2 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtClientID2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tpAdd.SuspendLayout();
            this.tpSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservation)).BeginInit();
            this.tpUpdate.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tpAdd);
            this.tabControl1.Controls.Add(this.tpSearch);
            this.tabControl1.Controls.Add(this.tpUpdate);
            this.tabControl1.Location = new System.Drawing.Point(20, 26);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1042, 456);
            this.tabControl1.TabIndex = 0;
            // 
            // tpAdd
            // 
            this.tpAdd.Controls.Add(this.dtOut);
            this.tpAdd.Controls.Add(this.dtIn);
            this.tpAdd.Controls.Add(this.label6);
            this.tpAdd.Controls.Add(this.label5);
            this.tpAdd.Controls.Add(this.cbRoomNo);
            this.tpAdd.Controls.Add(this.label4);
            this.tpAdd.Controls.Add(this.cbType);
            this.tpAdd.Controls.Add(this.label1);
            this.tpAdd.Controls.Add(this.txtClinetID);
            this.tpAdd.Controls.Add(this.btnAdd);
            this.tpAdd.Controls.Add(this.label3);
            this.tpAdd.Controls.Add(this.label2);
            this.tpAdd.Location = new System.Drawing.Point(4, 4);
            this.tpAdd.Name = "tpAdd";
            this.tpAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tpAdd.Size = new System.Drawing.Size(1034, 426);
            this.tpAdd.TabIndex = 0;
            this.tpAdd.Text = "Add Reservation";
            this.tpAdd.UseVisualStyleBackColor = true;
            this.tpAdd.Leave += new System.EventHandler(this.tpAdd_Leave);
            // 
            // dtOut
            // 
            this.dtOut.Location = new System.Drawing.Point(558, 308);
            this.dtOut.MinDate = new System.DateTime(2026, 1, 30, 0, 0, 0, 0);
            this.dtOut.Name = "dtOut";
            this.dtOut.Size = new System.Drawing.Size(217, 22);
            this.dtOut.TabIndex = 5;
            // 
            // dtIn
            // 
            this.dtIn.Location = new System.Drawing.Point(222, 308);
            this.dtIn.MinDate = new System.DateTime(2026, 1, 30, 0, 0, 0, 0);
            this.dtIn.Name = "dtIn";
            this.dtIn.Size = new System.Drawing.Size(216, 22);
            this.dtIn.TabIndex = 4;
            this.dtIn.ValueChanged += new System.EventHandler(this.dtIn_ValueChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(554, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Date Out:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(218, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Date In:";
            // 
            // cbRoomNo
            // 
            this.cbRoomNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRoomNo.FormattingEnabled = true;
            this.cbRoomNo.Location = new System.Drawing.Point(558, 133);
            this.cbRoomNo.Name = "cbRoomNo";
            this.cbRoomNo.Size = new System.Drawing.Size(259, 25);
            this.cbRoomNo.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(218, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Client ID:";
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Please select...",
            "Single",
            "Double",
            "Family",
            "Suite"});
            this.cbType.Location = new System.Drawing.Point(222, 133);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(259, 25);
            this.cbType.TabIndex = 1;
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Reservation:";
            // 
            // txtClinetID
            // 
            this.txtClinetID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtClinetID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtClinetID.DefaultText = "";
            this.txtClinetID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtClinetID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtClinetID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtClinetID.DisabledState.Parent = this.txtClinetID;
            this.txtClinetID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtClinetID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtClinetID.FocusedState.Parent = this.txtClinetID;
            this.txtClinetID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtClinetID.HoverState.Parent = this.txtClinetID;
            this.txtClinetID.Location = new System.Drawing.Point(222, 217);
            this.txtClinetID.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.txtClinetID.Name = "txtClinetID";
            this.txtClinetID.PasswordChar = '\0';
            this.txtClinetID.PlaceholderText = "";
            this.txtClinetID.SelectedText = "";
            this.txtClinetID.ShadowDecoration.Parent = this.txtClinetID;
            this.txtClinetID.Size = new System.Drawing.Size(259, 31);
            this.txtClinetID.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.BorderRadius = 5;
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.CustomImages.Parent = this.btnAdd;
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.btnAdd.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.HoverState.Parent = this.btnAdd;
            this.btnAdd.Location = new System.Drawing.Point(874, 364);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(134, 45);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(554, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Room No.:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(218, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Room Type:";
            // 
            // tpSearch
            // 
            this.tpSearch.Controls.Add(this.dgvReservation);
            this.tpSearch.Controls.Add(this.txtSearchClinetID);
            this.tpSearch.Controls.Add(this.label7);
            this.tpSearch.Controls.Add(this.label8);
            this.tpSearch.Location = new System.Drawing.Point(4, 4);
            this.tpSearch.Name = "tpSearch";
            this.tpSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tpSearch.Size = new System.Drawing.Size(1034, 426);
            this.tpSearch.TabIndex = 1;
            this.tpSearch.Text = "Search Reservation";
            this.tpSearch.UseVisualStyleBackColor = true;
            this.tpSearch.Enter += new System.EventHandler(this.tpSearch_Enter);
            // 
            // dgvReservation
            // 
            this.dgvReservation.AllowUserToAddRows = false;
            this.dgvReservation.AllowUserToDeleteRows = false;
            this.dgvReservation.AllowUserToOrderColumns = true;
            this.dgvReservation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvReservation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReservation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservation.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvReservation.Location = new System.Drawing.Point(27, 148);
            this.dgvReservation.Name = "dgvReservation";
            this.dgvReservation.ReadOnly = true;
            this.dgvReservation.Size = new System.Drawing.Size(980, 248);
            this.dgvReservation.TabIndex = 2;
            this.dgvReservation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReservation_CellClick);
            // 
            // txtSearchClinetID
            // 
            this.txtSearchClinetID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearchClinetID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchClinetID.DefaultText = "";
            this.txtSearchClinetID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchClinetID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchClinetID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchClinetID.DisabledState.Parent = this.txtSearchClinetID;
            this.txtSearchClinetID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchClinetID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchClinetID.FocusedState.Parent = this.txtSearchClinetID;
            this.txtSearchClinetID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchClinetID.HoverState.Parent = this.txtSearchClinetID;
            this.txtSearchClinetID.Location = new System.Drawing.Point(212, 74);
            this.txtSearchClinetID.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.txtSearchClinetID.Name = "txtSearchClinetID";
            this.txtSearchClinetID.PasswordChar = '\0';
            this.txtSearchClinetID.PlaceholderText = "";
            this.txtSearchClinetID.SelectedText = "";
            this.txtSearchClinetID.ShadowDecoration.Parent = this.txtSearchClinetID;
            this.txtSearchClinetID.Size = new System.Drawing.Size(252, 34);
            this.txtSearchClinetID.TabIndex = 1;
            this.txtSearchClinetID.TextChanged += new System.EventHandler(this.txtSearchClinetID_TextChanged);
            this.txtSearchClinetID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchClinetID_KeyPress);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(208, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "Client ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label8.Location = new System.Drawing.Point(3, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(191, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "Search Reservation:";
            // 
            // tpUpdate
            // 
            this.tpUpdate.Controls.Add(this.btnCancel);
            this.tpUpdate.Controls.Add(this.btnUpdate);
            this.tpUpdate.Controls.Add(this.dtOut2);
            this.tpUpdate.Controls.Add(this.dtIn2);
            this.tpUpdate.Controls.Add(this.label9);
            this.tpUpdate.Controls.Add(this.label10);
            this.tpUpdate.Controls.Add(this.cbRoomNo2);
            this.tpUpdate.Controls.Add(this.label11);
            this.tpUpdate.Controls.Add(this.cbType2);
            this.tpUpdate.Controls.Add(this.label12);
            this.tpUpdate.Controls.Add(this.txtClientID2);
            this.tpUpdate.Controls.Add(this.label13);
            this.tpUpdate.Controls.Add(this.label14);
            this.tpUpdate.Location = new System.Drawing.Point(4, 4);
            this.tpUpdate.Name = "tpUpdate";
            this.tpUpdate.Padding = new System.Windows.Forms.Padding(3);
            this.tpUpdate.Size = new System.Drawing.Size(1034, 426);
            this.tpUpdate.TabIndex = 2;
            this.tpUpdate.Text = "Update or Cancel Reservation";
            this.tpUpdate.UseVisualStyleBackColor = true;
            this.tpUpdate.Leave += new System.EventHandler(this.tpUpdate_Leave);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.BorderRadius = 5;
            this.btnCancel.CheckedState.Parent = this.btnCancel;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.CustomImages.Parent = this.btnCancel;
            this.btnCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.btnCancel.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.HoverState.Parent = this.btnCancel;
            this.btnCancel.Location = new System.Drawing.Point(887, 366);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.btnCancel.ShadowDecoration.Parent = this.btnCancel;
            this.btnCancel.Size = new System.Drawing.Size(134, 45);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdate.BorderRadius = 5;
            this.btnUpdate.CheckedState.Parent = this.btnUpdate;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.CustomImages.Parent = this.btnUpdate;
            this.btnUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.btnUpdate.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.HoverState.Parent = this.btnUpdate;
            this.btnUpdate.Location = new System.Drawing.Point(728, 366);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.btnUpdate.ShadowDecoration.Parent = this.btnUpdate;
            this.btnUpdate.Size = new System.Drawing.Size(134, 45);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dtOut2
            // 
            this.dtOut2.Location = new System.Drawing.Point(558, 308);
            this.dtOut2.MinDate = new System.DateTime(2026, 1, 30, 0, 0, 0, 0);
            this.dtOut2.Name = "dtOut2";
            this.dtOut2.Size = new System.Drawing.Size(221, 22);
            this.dtOut2.TabIndex = 5;
            // 
            // dtIn2
            // 
            this.dtIn2.Location = new System.Drawing.Point(222, 308);
            this.dtIn2.MinDate = new System.DateTime(2026, 1, 30, 0, 0, 0, 0);
            this.dtIn2.Name = "dtIn2";
            this.dtIn2.Size = new System.Drawing.Size(221, 22);
            this.dtIn2.TabIndex = 4;
            this.dtIn2.ValueChanged += new System.EventHandler(this.dtIn2_ValueChanged);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(554, 273);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 21);
            this.label9.TabIndex = 0;
            this.label9.Text = "Date Out:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(218, 273);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 21);
            this.label10.TabIndex = 0;
            this.label10.Text = "Date In:";
            // 
            // cbRoomNo2
            // 
            this.cbRoomNo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRoomNo2.FormattingEnabled = true;
            this.cbRoomNo2.Location = new System.Drawing.Point(558, 133);
            this.cbRoomNo2.Name = "cbRoomNo2";
            this.cbRoomNo2.Size = new System.Drawing.Size(259, 25);
            this.cbRoomNo2.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(218, 184);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 21);
            this.label11.TabIndex = 0;
            this.label11.Text = "Client ID:";
            // 
            // cbType2
            // 
            this.cbType2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType2.FormattingEnabled = true;
            this.cbType2.Items.AddRange(new object[] {
            "Please select...",
            "Single",
            "Double",
            "Family",
            "Suite"});
            this.cbType2.Location = new System.Drawing.Point(222, 133);
            this.cbType2.Name = "cbType2";
            this.cbType2.Size = new System.Drawing.Size(259, 25);
            this.cbType2.TabIndex = 1;
            this.cbType2.SelectedIndexChanged += new System.EventHandler(this.cbType2_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label12.Location = new System.Drawing.Point(3, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(283, 24);
            this.label12.TabIndex = 0;
            this.label12.Text = "Update or Cancel Reservation:";
            // 
            // txtClientID2
            // 
            this.txtClientID2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtClientID2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtClientID2.DefaultText = "";
            this.txtClientID2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtClientID2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtClientID2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtClientID2.DisabledState.Parent = this.txtClientID2;
            this.txtClientID2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtClientID2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtClientID2.FocusedState.Parent = this.txtClientID2;
            this.txtClientID2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtClientID2.HoverState.Parent = this.txtClientID2;
            this.txtClientID2.Location = new System.Drawing.Point(222, 217);
            this.txtClientID2.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.txtClientID2.Name = "txtClientID2";
            this.txtClientID2.PasswordChar = '\0';
            this.txtClientID2.PlaceholderText = "";
            this.txtClientID2.SelectedText = "";
            this.txtClientID2.ShadowDecoration.Parent = this.txtClientID2;
            this.txtClientID2.Size = new System.Drawing.Size(259, 31);
            this.txtClientID2.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(554, 97);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 21);
            this.label13.TabIndex = 0;
            this.label13.Text = "Room No.:";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(218, 97);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 21);
            this.label14.TabIndex = 0;
            this.label14.Text = "Room Type:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cancelToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 48);
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Image = global::HMS_Presentation.Properties.Resources.close__2_;
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cancelToolStripMenuItem.Text = "Cancel";
            this.cancelToolStripMenuItem.Click += new System.EventHandler(this.cancelToolStripMenuItem_Click);
            // 
            // ctrlReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ctrlReservation";
            this.Size = new System.Drawing.Size(1082, 509);
            this.Load += new System.EventHandler(this.ctrlReservation_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpAdd.ResumeLayout(false);
            this.tpAdd.PerformLayout();
            this.tpSearch.ResumeLayout(false);
            this.tpSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservation)).EndInit();
            this.tpUpdate.ResumeLayout(false);
            this.tpUpdate.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpAdd;
        private System.Windows.Forms.TabPage tpSearch;
        private System.Windows.Forms.TabPage tpUpdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbRoomNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtClinetID;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtOut;
        private System.Windows.Forms.DateTimePicker dtIn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvReservation;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchClinetID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtOut2;
        private System.Windows.Forms.DateTimePicker dtIn2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbRoomNo2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbType2;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2TextBox txtClientID2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
    }
}
