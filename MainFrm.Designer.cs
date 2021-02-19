namespace ContactList
{
    partial class mainFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainFrm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpSearch = new System.Windows.Forms.TabPage();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactListDataSet2 = new ContactList.ContactListDataSet2();
            this.tbpManage = new System.Windows.Forms.TabPage();
            this.btnRup = new System.Windows.Forms.Button();
            this.txtMid = new System.Windows.Forms.TextBox();
            this.mId = new System.Windows.Forms.Label();
            this.txtMadd = new System.Windows.Forms.TextBox();
            this.txtMemail = new System.Windows.Forms.TextBox();
            this.txtMphone = new System.Windows.Forms.TextBox();
            this.txtMbirth = new System.Windows.Forms.TextBox();
            this.txtMsex = new System.Windows.Forms.TextBox();
            this.txtMname = new System.Windows.Forms.TextBox();
            this.mAdd = new System.Windows.Forms.Label();
            this.mEmail = new System.Windows.Forms.Label();
            this.mPhone = new System.Windows.Forms.Label();
            this.mBirth = new System.Windows.Forms.Label();
            this.mSex = new System.Windows.Forms.Label();
            this.mName = new System.Windows.Forms.Label();
            this.dgvShow = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdataDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.contactListDataSet4 = new ContactList.ContactListDataSet4();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbpSystem = new System.Windows.Forms.TabPage();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblShow = new System.Windows.Forms.Label();
            this.btnAbout = new System.Windows.Forms.Button();
            this.contactBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.contactListDataSet3 = new ContactList.ContactListDataSet3();
            this.contactTableAdapter = new ContactList.ContactListDataSet2TableAdapters.ContactTableAdapter();
            this.contactTableAdapter1 = new ContactList.ContactListDataSet3TableAdapters.ContactTableAdapter();
            this.contactTableAdapter2 = new ContactList.ContactListDataSet4TableAdapters.ContactTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tbpSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactListDataSet2)).BeginInit();
            this.tbpManage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactListDataSet4)).BeginInit();
            this.tbpSystem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactListDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpSearch);
            this.tabControl1.Controls.Add(this.tbpManage);
            this.tabControl1.Controls.Add(this.tbpSystem);
            this.tabControl1.Location = new System.Drawing.Point(1, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(882, 403);
            this.tabControl1.TabIndex = 0;
            // 
            // tbpSearch
            // 
            this.tbpSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbpSearch.BackgroundImage")));
            this.tbpSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbpSearch.Controls.Add(this.lblSearch);
            this.tbpSearch.Controls.Add(this.btnShow);
            this.tbpSearch.Controls.Add(this.dgvList);
            this.tbpSearch.Location = new System.Drawing.Point(4, 22);
            this.tbpSearch.Name = "tbpSearch";
            this.tbpSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tbpSearch.Size = new System.Drawing.Size(874, 377);
            this.tbpSearch.TabIndex = 0;
            this.tbpSearch.Text = "通讯录查询";
            this.tbpSearch.UseVisualStyleBackColor = true;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSearch.Location = new System.Drawing.Point(307, 15);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(213, 33);
            this.lblSearch.TabIndex = 3;
            this.lblSearch.Text = "查询全部信息";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(386, 334);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "显示";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AutoGenerateColumns = false;
            this.dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.birthdataDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.dgvList.DataSource = this.contactBindingSource;
            this.dgvList.Location = new System.Drawing.Point(28, 63);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.Size = new System.Drawing.Size(801, 253);
            this.dgvList.TabIndex = 1;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.FillWeight = 101.7259F;
            this.nameDataGridViewTextBoxColumn.HeaderText = "姓名";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "sex";
            this.sexDataGridViewTextBoxColumn.FillWeight = 91.37056F;
            this.sexDataGridViewTextBoxColumn.HeaderText = "性别";
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            this.sexDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // birthdataDataGridViewTextBoxColumn
            // 
            this.birthdataDataGridViewTextBoxColumn.DataPropertyName = "birthdata";
            this.birthdataDataGridViewTextBoxColumn.FillWeight = 101.7259F;
            this.birthdataDataGridViewTextBoxColumn.HeaderText = "生日";
            this.birthdataDataGridViewTextBoxColumn.Name = "birthdataDataGridViewTextBoxColumn";
            this.birthdataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.FillWeight = 101.7259F;
            this.phoneDataGridViewTextBoxColumn.HeaderText = "电话";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.FillWeight = 101.7259F;
            this.emailDataGridViewTextBoxColumn.HeaderText = "邮箱";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.FillWeight = 101.7259F;
            this.addressDataGridViewTextBoxColumn.HeaderText = "地址";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contactBindingSource
            // 
            this.contactBindingSource.DataMember = "Contact";
            this.contactBindingSource.DataSource = this.contactListDataSet2;
            // 
            // contactListDataSet2
            // 
            this.contactListDataSet2.DataSetName = "ContactListDataSet2";
            this.contactListDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbpManage
            // 
            this.tbpManage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbpManage.BackgroundImage")));
            this.tbpManage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbpManage.Controls.Add(this.btnRup);
            this.tbpManage.Controls.Add(this.txtMid);
            this.tbpManage.Controls.Add(this.mId);
            this.tbpManage.Controls.Add(this.txtMadd);
            this.tbpManage.Controls.Add(this.txtMemail);
            this.tbpManage.Controls.Add(this.txtMphone);
            this.tbpManage.Controls.Add(this.txtMbirth);
            this.tbpManage.Controls.Add(this.txtMsex);
            this.tbpManage.Controls.Add(this.txtMname);
            this.tbpManage.Controls.Add(this.mAdd);
            this.tbpManage.Controls.Add(this.mEmail);
            this.tbpManage.Controls.Add(this.mPhone);
            this.tbpManage.Controls.Add(this.mBirth);
            this.tbpManage.Controls.Add(this.mSex);
            this.tbpManage.Controls.Add(this.mName);
            this.tbpManage.Controls.Add(this.dgvShow);
            this.tbpManage.Controls.Add(this.btnDelete);
            this.tbpManage.Controls.Add(this.btnUpdate);
            this.tbpManage.Controls.Add(this.btnFind);
            this.tbpManage.Controls.Add(this.btnAdd);
            this.tbpManage.Location = new System.Drawing.Point(4, 22);
            this.tbpManage.Name = "tbpManage";
            this.tbpManage.Padding = new System.Windows.Forms.Padding(3);
            this.tbpManage.Size = new System.Drawing.Size(874, 377);
            this.tbpManage.TabIndex = 1;
            this.tbpManage.Text = "通讯录管理";
            this.tbpManage.UseVisualStyleBackColor = true;
            // 
            // btnRup
            // 
            this.btnRup.Location = new System.Drawing.Point(765, 35);
            this.btnRup.Name = "btnRup";
            this.btnRup.Size = new System.Drawing.Size(75, 23);
            this.btnRup.TabIndex = 18;
            this.btnRup.Text = "更新";
            this.btnRup.UseVisualStyleBackColor = true;
            this.btnRup.Click += new System.EventHandler(this.BtnRup_Click);
            // 
            // txtMid
            // 
            this.txtMid.Location = new System.Drawing.Point(65, 291);
            this.txtMid.Name = "txtMid";
            this.txtMid.Size = new System.Drawing.Size(100, 21);
            this.txtMid.TabIndex = 17;
            // 
            // mId
            // 
            this.mId.AutoSize = true;
            this.mId.Location = new System.Drawing.Point(18, 294);
            this.mId.Name = "mId";
            this.mId.Size = new System.Drawing.Size(41, 12);
            this.mId.TabIndex = 16;
            this.mId.Text = "编号：";
            // 
            // txtMadd
            // 
            this.txtMadd.Location = new System.Drawing.Point(532, 348);
            this.txtMadd.Name = "txtMadd";
            this.txtMadd.Size = new System.Drawing.Size(100, 21);
            this.txtMadd.TabIndex = 15;
            // 
            // txtMemail
            // 
            this.txtMemail.Location = new System.Drawing.Point(532, 317);
            this.txtMemail.Name = "txtMemail";
            this.txtMemail.Size = new System.Drawing.Size(100, 21);
            this.txtMemail.TabIndex = 14;
            // 
            // txtMphone
            // 
            this.txtMphone.Location = new System.Drawing.Point(532, 284);
            this.txtMphone.Name = "txtMphone";
            this.txtMphone.Size = new System.Drawing.Size(100, 21);
            this.txtMphone.TabIndex = 13;
            // 
            // txtMbirth
            // 
            this.txtMbirth.Location = new System.Drawing.Point(287, 346);
            this.txtMbirth.Name = "txtMbirth";
            this.txtMbirth.Size = new System.Drawing.Size(100, 21);
            this.txtMbirth.TabIndex = 12;
            // 
            // txtMsex
            // 
            this.txtMsex.Location = new System.Drawing.Point(287, 317);
            this.txtMsex.Name = "txtMsex";
            this.txtMsex.Size = new System.Drawing.Size(100, 21);
            this.txtMsex.TabIndex = 11;
            // 
            // txtMname
            // 
            this.txtMname.Location = new System.Drawing.Point(287, 282);
            this.txtMname.Name = "txtMname";
            this.txtMname.Size = new System.Drawing.Size(100, 21);
            this.txtMname.TabIndex = 10;
            // 
            // mAdd
            // 
            this.mAdd.AutoSize = true;
            this.mAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mAdd.Location = new System.Drawing.Point(462, 351);
            this.mAdd.Name = "mAdd";
            this.mAdd.Size = new System.Drawing.Size(41, 12);
            this.mAdd.TabIndex = 9;
            this.mAdd.Text = "地址：";
            // 
            // mEmail
            // 
            this.mEmail.AutoSize = true;
            this.mEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mEmail.Location = new System.Drawing.Point(462, 320);
            this.mEmail.Name = "mEmail";
            this.mEmail.Size = new System.Drawing.Size(41, 12);
            this.mEmail.TabIndex = 8;
            this.mEmail.Text = "邮箱：";
            // 
            // mPhone
            // 
            this.mPhone.AutoSize = true;
            this.mPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mPhone.Location = new System.Drawing.Point(462, 287);
            this.mPhone.Name = "mPhone";
            this.mPhone.Size = new System.Drawing.Size(41, 12);
            this.mPhone.TabIndex = 7;
            this.mPhone.Text = "电话：";
            // 
            // mBirth
            // 
            this.mBirth.AutoSize = true;
            this.mBirth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mBirth.Location = new System.Drawing.Point(219, 351);
            this.mBirth.Name = "mBirth";
            this.mBirth.Size = new System.Drawing.Size(41, 12);
            this.mBirth.TabIndex = 6;
            this.mBirth.Text = "生日：";
            // 
            // mSex
            // 
            this.mSex.AutoSize = true;
            this.mSex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mSex.Location = new System.Drawing.Point(219, 320);
            this.mSex.Name = "mSex";
            this.mSex.Size = new System.Drawing.Size(41, 12);
            this.mSex.TabIndex = 5;
            this.mSex.Text = "性别：";
            // 
            // mName
            // 
            this.mName.AutoSize = true;
            this.mName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mName.Location = new System.Drawing.Point(219, 287);
            this.mName.Name = "mName";
            this.mName.Size = new System.Drawing.Size(41, 12);
            this.mName.TabIndex = 1;
            this.mName.Text = "姓名：";
            // 
            // dgvShow
            // 
            this.dgvShow.AllowUserToAddRows = false;
            this.dgvShow.AllowUserToDeleteRows = false;
            this.dgvShow.AllowUserToOrderColumns = true;
            this.dgvShow.AutoGenerateColumns = false;
            this.dgvShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nameDataGridViewTextBoxColumn1,
            this.sexDataGridViewTextBoxColumn1,
            this.birthdataDataGridViewTextBoxColumn1,
            this.phoneDataGridViewTextBoxColumn1,
            this.emailDataGridViewTextBoxColumn1,
            this.addressDataGridViewTextBoxColumn1});
            this.dgvShow.DataSource = this.contactBindingSource2;
            this.dgvShow.Location = new System.Drawing.Point(6, 19);
            this.dgvShow.Name = "dgvShow";
            this.dgvShow.ReadOnly = true;
            this.dgvShow.RowTemplate.Height = 23;
            this.dgvShow.Size = new System.Drawing.Size(742, 237);
            this.dgvShow.TabIndex = 4;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.FillWeight = 50F;
            this.id.HeaderText = "编号";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "姓名";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // sexDataGridViewTextBoxColumn1
            // 
            this.sexDataGridViewTextBoxColumn1.DataPropertyName = "sex";
            this.sexDataGridViewTextBoxColumn1.HeaderText = "性别";
            this.sexDataGridViewTextBoxColumn1.Name = "sexDataGridViewTextBoxColumn1";
            this.sexDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // birthdataDataGridViewTextBoxColumn1
            // 
            this.birthdataDataGridViewTextBoxColumn1.DataPropertyName = "birthdata";
            this.birthdataDataGridViewTextBoxColumn1.HeaderText = "生日";
            this.birthdataDataGridViewTextBoxColumn1.Name = "birthdataDataGridViewTextBoxColumn1";
            this.birthdataDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn1
            // 
            this.phoneDataGridViewTextBoxColumn1.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn1.HeaderText = "电话";
            this.phoneDataGridViewTextBoxColumn1.Name = "phoneDataGridViewTextBoxColumn1";
            this.phoneDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn1
            // 
            this.emailDataGridViewTextBoxColumn1.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn1.HeaderText = "邮箱";
            this.emailDataGridViewTextBoxColumn1.Name = "emailDataGridViewTextBoxColumn1";
            this.emailDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn1
            // 
            this.addressDataGridViewTextBoxColumn1.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn1.HeaderText = "地址";
            this.addressDataGridViewTextBoxColumn1.Name = "addressDataGridViewTextBoxColumn1";
            this.addressDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // contactBindingSource2
            // 
            this.contactBindingSource2.DataMember = "Contact";
            this.contactBindingSource2.DataSource = this.contactListDataSet4;
            // 
            // contactListDataSet4
            // 
            this.contactListDataSet4.DataSetName = "ContactListDataSet4";
            this.contactListDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(765, 284);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "删除联系人";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(765, 221);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "修改联系人";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(765, 155);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 1;
            this.btnFind.Text = "查找联系人";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.BtnFind_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(765, 94);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "添加联系人";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // tbpSystem
            // 
            this.tbpSystem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbpSystem.BackgroundImage")));
            this.tbpSystem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbpSystem.Controls.Add(this.btnHelp);
            this.tbpSystem.Controls.Add(this.btnLogout);
            this.tbpSystem.Controls.Add(this.lblShow);
            this.tbpSystem.Controls.Add(this.btnAbout);
            this.tbpSystem.Location = new System.Drawing.Point(4, 22);
            this.tbpSystem.Name = "tbpSystem";
            this.tbpSystem.Padding = new System.Windows.Forms.Padding(3);
            this.tbpSystem.Size = new System.Drawing.Size(874, 377);
            this.tbpSystem.TabIndex = 2;
            this.tbpSystem.Text = "系统管理";
            this.tbpSystem.UseVisualStyleBackColor = true;
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(544, 194);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(86, 41);
            this.btnHelp.TabIndex = 3;
            this.btnHelp.Text = "使用帮助";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.BtnHelp_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(203, 194);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(89, 41);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "退出";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // lblShow
            // 
            this.lblShow.AutoSize = true;
            this.lblShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblShow.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblShow.Location = new System.Drawing.Point(103, 53);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(0, 33);
            this.lblShow.TabIndex = 1;
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(371, 194);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(88, 42);
            this.btnAbout.TabIndex = 0;
            this.btnAbout.Text = "关于";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.BtnAbout_Click);
            // 
            // contactBindingSource1
            // 
            this.contactBindingSource1.DataMember = "Contact";
            this.contactBindingSource1.DataSource = this.contactListDataSet3;
            // 
            // contactListDataSet3
            // 
            this.contactListDataSet3.DataSetName = "ContactListDataSet3";
            this.contactListDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contactTableAdapter
            // 
            this.contactTableAdapter.ClearBeforeFill = true;
            // 
            // contactTableAdapter1
            // 
            this.contactTableAdapter1.ClearBeforeFill = true;
            // 
            // contactTableAdapter2
            // 
            this.contactTableAdapter2.ClearBeforeFill = true;
            // 
            // mainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 418);
            this.Controls.Add(this.tabControl1);
            this.Name = "mainFrm";
            this.Text = "通讯录管理系统";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbpSearch.ResumeLayout(false);
            this.tbpSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactListDataSet2)).EndInit();
            this.tbpManage.ResumeLayout(false);
            this.tbpManage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactListDataSet4)).EndInit();
            this.tbpSystem.ResumeLayout(false);
            this.tbpSystem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactListDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpSearch;
        private System.Windows.Forms.TabPage tbpManage;
        private System.Windows.Forms.TabPage tbpSystem;
        private System.Windows.Forms.DataGridView dgvList;
        private ContactListDataSet2 contactListDataSet2;
        private System.Windows.Forms.BindingSource contactBindingSource;
        private ContactListDataSet2TableAdapters.ContactTableAdapter contactTableAdapter;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvShow;
        private System.Windows.Forms.TextBox txtMadd;
        private System.Windows.Forms.TextBox txtMemail;
        private System.Windows.Forms.TextBox txtMphone;
        private System.Windows.Forms.TextBox txtMbirth;
        private System.Windows.Forms.TextBox txtMsex;
        private System.Windows.Forms.TextBox txtMname;
        private System.Windows.Forms.Label mAdd;
        private System.Windows.Forms.Label mEmail;
        private System.Windows.Forms.Label mPhone;
        private System.Windows.Forms.Label mBirth;
        private System.Windows.Forms.Label mSex;
        private System.Windows.Forms.Label mName;
        private ContactListDataSet3 contactListDataSet3;
        private System.Windows.Forms.BindingSource contactBindingSource1;
        private ContactListDataSet3TableAdapters.ContactTableAdapter contactTableAdapter1;
        private ContactListDataSet4 contactListDataSet4;
        private System.Windows.Forms.BindingSource contactBindingSource2;
        private ContactListDataSet4TableAdapters.ContactTableAdapter contactTableAdapter2;
        private System.Windows.Forms.TextBox txtMid;
        private System.Windows.Forms.Label mId;
        private System.Windows.Forms.Button btnRup;
        private System.Windows.Forms.Label lblShow;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdataDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn1;
    }
}