namespace HMS_Presentation.Controls
{
    partial class ctrlClient
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
            this.tpAddClient = new System.Windows.Forms.TabPage();
            this.txtAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNational = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtFName = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tpSearchClient = new System.Windows.Forms.TabPage();
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.txtSearchNationalID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tpUpdateClient = new System.Windows.Forms.TabPage();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.txtAddress2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNational2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPhone2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtLName2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtFName2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tpAddClient.SuspendLayout();
            this.tpSearchClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            this.tpUpdateClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tpAddClient);
            this.tabControl1.Controls.Add(this.tpSearchClient);
            this.tabControl1.Controls.Add(this.tpUpdateClient);
            this.tabControl1.Location = new System.Drawing.Point(20, 26);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1042, 456);
            this.tabControl1.TabIndex = 0;
            // 
            // tpAddClient
            // 
            this.tpAddClient.Controls.Add(this.txtAddress);
            this.tpAddClient.Controls.Add(this.label6);
            this.tpAddClient.Controls.Add(this.txtNational);
            this.tpAddClient.Controls.Add(this.txtPhone);
            this.tpAddClient.Controls.Add(this.label4);
            this.tpAddClient.Controls.Add(this.label5);
            this.tpAddClient.Controls.Add(this.label1);
            this.tpAddClient.Controls.Add(this.txtLName);
            this.tpAddClient.Controls.Add(this.txtFName);
            this.tpAddClient.Controls.Add(this.btnAdd);
            this.tpAddClient.Controls.Add(this.label3);
            this.tpAddClient.Controls.Add(this.label2);
            this.tpAddClient.Location = new System.Drawing.Point(4, 4);
            this.tpAddClient.Margin = new System.Windows.Forms.Padding(4);
            this.tpAddClient.Name = "tpAddClient";
            this.tpAddClient.Padding = new System.Windows.Forms.Padding(4);
            this.tpAddClient.Size = new System.Drawing.Size(1034, 426);
            this.tpAddClient.TabIndex = 0;
            this.tpAddClient.Text = "Add Client";
            this.tpAddClient.UseVisualStyleBackColor = true;
            this.tpAddClient.Leave += new System.EventHandler(this.tpAddClient_Leave);
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.DefaultText = "";
            this.txtAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.DisabledState.Parent = this.txtAddress;
            this.txtAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.FocusedState.Parent = this.txtAddress;
            this.txtAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.HoverState.Parent = this.txtAddress;
            this.txtAddress.Location = new System.Drawing.Point(182, 291);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.PlaceholderText = "";
            this.txtAddress.SelectedText = "";
            this.txtAddress.ShadowDecoration.Parent = this.txtAddress;
            this.txtAddress.Size = new System.Drawing.Size(675, 90);
            this.txtAddress.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(178, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Address";
            // 
            // txtNational
            // 
            this.txtNational.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNational.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNational.DefaultText = "";
            this.txtNational.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNational.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNational.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNational.DisabledState.Parent = this.txtNational;
            this.txtNational.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNational.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNational.FocusedState.Parent = this.txtNational;
            this.txtNational.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNational.HoverState.Parent = this.txtNational;
            this.txtNational.Location = new System.Drawing.Point(561, 188);
            this.txtNational.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.txtNational.Name = "txtNational";
            this.txtNational.PasswordChar = '\0';
            this.txtNational.PlaceholderText = "";
            this.txtNational.SelectedText = "";
            this.txtNational.ShadowDecoration.Parent = this.txtNational;
            this.txtNational.Size = new System.Drawing.Size(296, 33);
            this.txtNational.TabIndex = 4;
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.DefaultText = "";
            this.txtPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhone.DisabledState.Parent = this.txtPhone;
            this.txtPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhone.FocusedState.Parent = this.txtPhone;
            this.txtPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhone.HoverState.Parent = this.txtPhone;
            this.txtPhone.Location = new System.Drawing.Point(182, 188);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.PlaceholderText = "";
            this.txtPhone.SelectedText = "";
            this.txtPhone.ShadowDecoration.Parent = this.txtPhone;
            this.txtPhone.Size = new System.Drawing.Size(296, 33);
            this.txtPhone.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(557, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "National ID";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(178, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Phone";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Client:";
            // 
            // txtLName
            // 
            this.txtLName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLName.DefaultText = "";
            this.txtLName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLName.DisabledState.Parent = this.txtLName;
            this.txtLName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLName.FocusedState.Parent = this.txtLName;
            this.txtLName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLName.HoverState.Parent = this.txtLName;
            this.txtLName.Location = new System.Drawing.Point(561, 81);
            this.txtLName.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtLName.Name = "txtLName";
            this.txtLName.PasswordChar = '\0';
            this.txtLName.PlaceholderText = "";
            this.txtLName.SelectedText = "";
            this.txtLName.ShadowDecoration.Parent = this.txtLName;
            this.txtLName.Size = new System.Drawing.Size(296, 33);
            this.txtLName.TabIndex = 2;
            // 
            // txtFName
            // 
            this.txtFName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFName.DefaultText = "";
            this.txtFName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFName.DisabledState.Parent = this.txtFName;
            this.txtFName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFName.FocusedState.Parent = this.txtFName;
            this.txtFName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFName.HoverState.Parent = this.txtFName;
            this.txtFName.Location = new System.Drawing.Point(182, 81);
            this.txtFName.Margin = new System.Windows.Forms.Padding(5);
            this.txtFName.Name = "txtFName";
            this.txtFName.PasswordChar = '\0';
            this.txtFName.PlaceholderText = "";
            this.txtFName.SelectedText = "";
            this.txtFName.ShadowDecoration.Parent = this.txtFName;
            this.txtFName.Size = new System.Drawing.Size(296, 33);
            this.txtFName.TabIndex = 1;
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
            this.btnAdd.Location = new System.Drawing.Point(893, 374);
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
            this.label3.Location = new System.Drawing.Point(557, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "LastName";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(178, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "FirstName";
            // 
            // tpSearchClient
            // 
            this.tpSearchClient.Controls.Add(this.dgvClients);
            this.tpSearchClient.Controls.Add(this.txtSearchNationalID);
            this.tpSearchClient.Controls.Add(this.label7);
            this.tpSearchClient.Controls.Add(this.label8);
            this.tpSearchClient.Location = new System.Drawing.Point(4, 4);
            this.tpSearchClient.Margin = new System.Windows.Forms.Padding(4);
            this.tpSearchClient.Name = "tpSearchClient";
            this.tpSearchClient.Padding = new System.Windows.Forms.Padding(4);
            this.tpSearchClient.Size = new System.Drawing.Size(1034, 426);
            this.tpSearchClient.TabIndex = 1;
            this.tpSearchClient.Text = "Search Client";
            this.tpSearchClient.UseVisualStyleBackColor = true;
            this.tpSearchClient.Enter += new System.EventHandler(this.tpSearchClient_Enter);
            // 
            // dgvClients
            // 
            this.dgvClients.AllowUserToAddRows = false;
            this.dgvClients.AllowUserToDeleteRows = false;
            this.dgvClients.AllowUserToOrderColumns = true;
            this.dgvClients.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClients.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvClients.Location = new System.Drawing.Point(27, 149);
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.ReadOnly = true;
            this.dgvClients.Size = new System.Drawing.Size(980, 248);
            this.dgvClients.TabIndex = 2;
            this.dgvClients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClients_CellClick);
            // 
            // txtSearchNationalID
            // 
            this.txtSearchNationalID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearchNationalID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchNationalID.DefaultText = "";
            this.txtSearchNationalID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchNationalID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchNationalID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchNationalID.DisabledState.Parent = this.txtSearchNationalID;
            this.txtSearchNationalID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchNationalID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchNationalID.FocusedState.Parent = this.txtSearchNationalID;
            this.txtSearchNationalID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchNationalID.HoverState.Parent = this.txtSearchNationalID;
            this.txtSearchNationalID.Location = new System.Drawing.Point(212, 76);
            this.txtSearchNationalID.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtSearchNationalID.Name = "txtSearchNationalID";
            this.txtSearchNationalID.PasswordChar = '\0';
            this.txtSearchNationalID.PlaceholderText = "";
            this.txtSearchNationalID.SelectedText = "";
            this.txtSearchNationalID.ShadowDecoration.Parent = this.txtSearchNationalID;
            this.txtSearchNationalID.Size = new System.Drawing.Size(326, 33);
            this.txtSearchNationalID.TabIndex = 1;
            this.txtSearchNationalID.TextChanged += new System.EventHandler(this.txtSearchNationalID_TextChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(208, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "National ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label8.Location = new System.Drawing.Point(3, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "Search Client:";
            // 
            // tpUpdateClient
            // 
            this.tpUpdateClient.Controls.Add(this.btnDelete);
            this.tpUpdateClient.Controls.Add(this.btnUpdate);
            this.tpUpdateClient.Controls.Add(this.txtAddress2);
            this.tpUpdateClient.Controls.Add(this.label9);
            this.tpUpdateClient.Controls.Add(this.txtNational2);
            this.tpUpdateClient.Controls.Add(this.txtPhone2);
            this.tpUpdateClient.Controls.Add(this.label10);
            this.tpUpdateClient.Controls.Add(this.label11);
            this.tpUpdateClient.Controls.Add(this.label12);
            this.tpUpdateClient.Controls.Add(this.txtLName2);
            this.tpUpdateClient.Controls.Add(this.txtFName2);
            this.tpUpdateClient.Controls.Add(this.label13);
            this.tpUpdateClient.Controls.Add(this.label14);
            this.tpUpdateClient.Location = new System.Drawing.Point(4, 4);
            this.tpUpdateClient.Name = "tpUpdateClient";
            this.tpUpdateClient.Padding = new System.Windows.Forms.Padding(3);
            this.tpUpdateClient.Size = new System.Drawing.Size(1034, 426);
            this.tpUpdateClient.TabIndex = 2;
            this.tpUpdateClient.Text = "Update or Delete Client";
            this.tpUpdateClient.UseVisualStyleBackColor = true;
            this.tpUpdateClient.Leave += new System.EventHandler(this.tpUpdateClient_Leave);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.BorderRadius = 5;
            this.btnDelete.CheckedState.Parent = this.btnDelete;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.CustomImages.Parent = this.btnDelete;
            this.btnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.btnDelete.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.HoverState.Parent = this.btnDelete;
            this.btnDelete.Location = new System.Drawing.Point(894, 374);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.btnDelete.ShadowDecoration.Parent = this.btnDelete;
            this.btnDelete.Size = new System.Drawing.Size(134, 45);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.btnUpdate.Location = new System.Drawing.Point(735, 374);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.btnUpdate.ShadowDecoration.Parent = this.btnUpdate;
            this.btnUpdate.Size = new System.Drawing.Size(134, 45);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtAddress2
            // 
            this.txtAddress2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAddress2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress2.DefaultText = "";
            this.txtAddress2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddress2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddress2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress2.DisabledState.Parent = this.txtAddress2;
            this.txtAddress2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress2.FocusedState.Parent = this.txtAddress2;
            this.txtAddress2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress2.HoverState.Parent = this.txtAddress2;
            this.txtAddress2.Location = new System.Drawing.Point(125, 274);
            this.txtAddress2.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.PasswordChar = '\0';
            this.txtAddress2.PlaceholderText = "";
            this.txtAddress2.SelectedText = "";
            this.txtAddress2.ShadowDecoration.Parent = this.txtAddress2;
            this.txtAddress2.Size = new System.Drawing.Size(699, 88);
            this.txtAddress2.TabIndex = 5;
            this.txtAddress2.Validating += new System.ComponentModel.CancelEventHandler(this.txtBox_Validating);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(121, 241);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 21);
            this.label9.TabIndex = 0;
            this.label9.Text = "Address";
            // 
            // txtNational2
            // 
            this.txtNational2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNational2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNational2.DefaultText = "";
            this.txtNational2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNational2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNational2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNational2.DisabledState.Parent = this.txtNational2;
            this.txtNational2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNational2.Enabled = false;
            this.txtNational2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNational2.FocusedState.Parent = this.txtNational2;
            this.txtNational2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNational2.HoverState.Parent = this.txtNational2;
            this.txtNational2.Location = new System.Drawing.Point(504, 176);
            this.txtNational2.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.txtNational2.Name = "txtNational2";
            this.txtNational2.PasswordChar = '\0';
            this.txtNational2.PlaceholderText = "";
            this.txtNational2.SelectedText = "";
            this.txtNational2.ShadowDecoration.Parent = this.txtNational2;
            this.txtNational2.Size = new System.Drawing.Size(320, 33);
            this.txtNational2.TabIndex = 4;
            this.txtNational2.Validating += new System.ComponentModel.CancelEventHandler(this.txtBox_Validating);
            // 
            // txtPhone2
            // 
            this.txtPhone2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPhone2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone2.DefaultText = "";
            this.txtPhone2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPhone2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPhone2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhone2.DisabledState.Parent = this.txtPhone2;
            this.txtPhone2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhone2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhone2.FocusedState.Parent = this.txtPhone2;
            this.txtPhone2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhone2.HoverState.Parent = this.txtPhone2;
            this.txtPhone2.Location = new System.Drawing.Point(125, 176);
            this.txtPhone2.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.txtPhone2.Name = "txtPhone2";
            this.txtPhone2.PasswordChar = '\0';
            this.txtPhone2.PlaceholderText = "";
            this.txtPhone2.SelectedText = "";
            this.txtPhone2.ShadowDecoration.Parent = this.txtPhone2;
            this.txtPhone2.Size = new System.Drawing.Size(320, 33);
            this.txtPhone2.TabIndex = 3;
            this.txtPhone2.Validating += new System.ComponentModel.CancelEventHandler(this.txtBox_Validating);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(500, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 21);
            this.label10.TabIndex = 0;
            this.label10.Text = "National ID";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(121, 137);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 21);
            this.label11.TabIndex = 0;
            this.label11.Text = "Phone";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label12.Location = new System.Drawing.Point(3, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(227, 24);
            this.label12.TabIndex = 0;
            this.label12.Text = "Update or Delete Client:";
            // 
            // txtLName2
            // 
            this.txtLName2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLName2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLName2.DefaultText = "";
            this.txtLName2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLName2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLName2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLName2.DisabledState.Parent = this.txtLName2;
            this.txtLName2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLName2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLName2.FocusedState.Parent = this.txtLName2;
            this.txtLName2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLName2.HoverState.Parent = this.txtLName2;
            this.txtLName2.Location = new System.Drawing.Point(504, 72);
            this.txtLName2.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.txtLName2.Name = "txtLName2";
            this.txtLName2.PasswordChar = '\0';
            this.txtLName2.PlaceholderText = "";
            this.txtLName2.SelectedText = "";
            this.txtLName2.ShadowDecoration.Parent = this.txtLName2;
            this.txtLName2.Size = new System.Drawing.Size(320, 33);
            this.txtLName2.TabIndex = 2;
            this.txtLName2.Validating += new System.ComponentModel.CancelEventHandler(this.txtBox_Validating);
            // 
            // txtFName2
            // 
            this.txtFName2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFName2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFName2.DefaultText = "";
            this.txtFName2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFName2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFName2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFName2.DisabledState.Parent = this.txtFName2;
            this.txtFName2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFName2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFName2.FocusedState.Parent = this.txtFName2;
            this.txtFName2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFName2.HoverState.Parent = this.txtFName2;
            this.txtFName2.Location = new System.Drawing.Point(125, 72);
            this.txtFName2.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtFName2.Name = "txtFName2";
            this.txtFName2.PasswordChar = '\0';
            this.txtFName2.PlaceholderText = "";
            this.txtFName2.SelectedText = "";
            this.txtFName2.ShadowDecoration.Parent = this.txtFName2;
            this.txtFName2.Size = new System.Drawing.Size(320, 33);
            this.txtFName2.TabIndex = 1;
            this.txtFName2.Validating += new System.ComponentModel.CancelEventHandler(this.txtBox_Validating);
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(500, 35);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 21);
            this.label13.TabIndex = 0;
            this.label13.Text = "LastName";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(121, 35);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 21);
            this.label14.TabIndex = 0;
            this.label14.Text = "FirstName";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 48);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::HMS_Presentation.Properties.Resources.close__2_;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // ctrlClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ctrlClient";
            this.Size = new System.Drawing.Size(1082, 509);
            this.tabControl1.ResumeLayout(false);
            this.tpAddClient.ResumeLayout(false);
            this.tpAddClient.PerformLayout();
            this.tpSearchClient.ResumeLayout(false);
            this.tpSearchClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            this.tpUpdateClient.ResumeLayout(false);
            this.tpUpdateClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpAddClient;
        private System.Windows.Forms.TabPage tpSearchClient;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtLName;
        private Guna.UI2.WinForms.Guna2TextBox txtFName;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtNational;
        private Guna.UI2.WinForms.Guna2TextBox txtPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvClients;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchNationalID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tpUpdateClient;
        private Guna.UI2.WinForms.Guna2TextBox txtAddress2;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox txtNational2;
        private Guna.UI2.WinForms.Guna2TextBox txtPhone2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2TextBox txtLName2;
        private Guna.UI2.WinForms.Guna2TextBox txtFName2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}
