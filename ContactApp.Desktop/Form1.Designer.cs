namespace ContactApp.Desktop
{
	partial class ContactApp
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.dgvContacts = new System.Windows.Forms.DataGridView();
			this.gbxAdd = new System.Windows.Forms.GroupBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.tbxNumber = new System.Windows.Forms.TextBox();
			this.tbxSurname = new System.Windows.Forms.TextBox();
			this.tbxName = new System.Windows.Forms.TextBox();
			this.lblNumber = new System.Windows.Forms.Label();
			this.lblSurname = new System.Windows.Forms.Label();
			this.lblName = new System.Windows.Forms.Label();
			this.gbxUpdate = new System.Windows.Forms.GroupBox();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.tbxNumberUpdate = new System.Windows.Forms.TextBox();
			this.tbxSurnameUpdate = new System.Windows.Forms.TextBox();
			this.tbxNameUpdate = new System.Windows.Forms.TextBox();
			this.lblNumberUpdate = new System.Windows.Forms.Label();
			this.lblSurnameUpdate = new System.Windows.Forms.Label();
			this.lblNameUpdate = new System.Windows.Forms.Label();
			this.lblSearch = new System.Windows.Forms.Label();
			this.tbxSearch = new System.Windows.Forms.TextBox();
			this.btnDelete = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).BeginInit();
			this.gbxAdd.SuspendLayout();
			this.gbxUpdate.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvContacts
			// 
			this.dgvContacts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvContacts.Location = new System.Drawing.Point(12, 63);
			this.dgvContacts.Name = "dgvContacts";
			this.dgvContacts.RowTemplate.Height = 25;
			this.dgvContacts.Size = new System.Drawing.Size(860, 184);
			this.dgvContacts.TabIndex = 0;
			this.dgvContacts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContacts_CellClick);
			// 
			// gbxAdd
			// 
			this.gbxAdd.Controls.Add(this.btnAdd);
			this.gbxAdd.Controls.Add(this.tbxNumber);
			this.gbxAdd.Controls.Add(this.tbxSurname);
			this.gbxAdd.Controls.Add(this.tbxName);
			this.gbxAdd.Controls.Add(this.lblNumber);
			this.gbxAdd.Controls.Add(this.lblSurname);
			this.gbxAdd.Controls.Add(this.lblName);
			this.gbxAdd.Location = new System.Drawing.Point(12, 267);
			this.gbxAdd.Name = "gbxAdd";
			this.gbxAdd.Size = new System.Drawing.Size(379, 189);
			this.gbxAdd.TabIndex = 1;
			this.gbxAdd.TabStop = false;
			this.gbxAdd.Text = "Add a Contact";
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(157, 149);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(88, 23);
			this.btnAdd.TabIndex = 6;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// tbxNumber
			// 
			this.tbxNumber.Location = new System.Drawing.Point(148, 108);
			this.tbxNumber.Name = "tbxNumber";
			this.tbxNumber.Size = new System.Drawing.Size(162, 23);
			this.tbxNumber.TabIndex = 5;
			// 
			// tbxSurname
			// 
			this.tbxSurname.Location = new System.Drawing.Point(148, 71);
			this.tbxSurname.Name = "tbxSurname";
			this.tbxSurname.Size = new System.Drawing.Size(162, 23);
			this.tbxSurname.TabIndex = 4;
			// 
			// tbxName
			// 
			this.tbxName.Location = new System.Drawing.Point(148, 31);
			this.tbxName.Name = "tbxName";
			this.tbxName.Size = new System.Drawing.Size(162, 23);
			this.tbxName.TabIndex = 3;
			// 
			// lblNumber
			// 
			this.lblNumber.AutoSize = true;
			this.lblNumber.Location = new System.Drawing.Point(51, 111);
			this.lblNumber.Name = "lblNumber";
			this.lblNumber.Size = new System.Drawing.Size(51, 15);
			this.lblNumber.TabIndex = 2;
			this.lblNumber.Text = "Number";
			// 
			// lblSurname
			// 
			this.lblSurname.AutoSize = true;
			this.lblSurname.Location = new System.Drawing.Point(51, 71);
			this.lblSurname.Name = "lblSurname";
			this.lblSurname.Size = new System.Drawing.Size(54, 15);
			this.lblSurname.TabIndex = 1;
			this.lblSurname.Text = "Surname";
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Location = new System.Drawing.Point(51, 33);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(39, 15);
			this.lblName.TabIndex = 0;
			this.lblName.Text = "Name";
			// 
			// gbxUpdate
			// 
			this.gbxUpdate.Controls.Add(this.btnUpdate);
			this.gbxUpdate.Controls.Add(this.tbxNumberUpdate);
			this.gbxUpdate.Controls.Add(this.tbxSurnameUpdate);
			this.gbxUpdate.Controls.Add(this.tbxNameUpdate);
			this.gbxUpdate.Controls.Add(this.lblNumberUpdate);
			this.gbxUpdate.Controls.Add(this.lblSurnameUpdate);
			this.gbxUpdate.Controls.Add(this.lblNameUpdate);
			this.gbxUpdate.Location = new System.Drawing.Point(493, 267);
			this.gbxUpdate.Name = "gbxUpdate";
			this.gbxUpdate.Size = new System.Drawing.Size(379, 189);
			this.gbxUpdate.TabIndex = 2;
			this.gbxUpdate.TabStop = false;
			this.gbxUpdate.Text = "Update a Contact";
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(157, 149);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(88, 23);
			this.btnUpdate.TabIndex = 6;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// tbxNumberUpdate
			// 
			this.tbxNumberUpdate.Location = new System.Drawing.Point(148, 108);
			this.tbxNumberUpdate.Name = "tbxNumberUpdate";
			this.tbxNumberUpdate.Size = new System.Drawing.Size(162, 23);
			this.tbxNumberUpdate.TabIndex = 5;
			// 
			// tbxSurnameUpdate
			// 
			this.tbxSurnameUpdate.Location = new System.Drawing.Point(148, 71);
			this.tbxSurnameUpdate.Name = "tbxSurnameUpdate";
			this.tbxSurnameUpdate.Size = new System.Drawing.Size(162, 23);
			this.tbxSurnameUpdate.TabIndex = 4;
			// 
			// tbxNameUpdate
			// 
			this.tbxNameUpdate.Location = new System.Drawing.Point(148, 31);
			this.tbxNameUpdate.Name = "tbxNameUpdate";
			this.tbxNameUpdate.Size = new System.Drawing.Size(162, 23);
			this.tbxNameUpdate.TabIndex = 3;
			// 
			// lblNumberUpdate
			// 
			this.lblNumberUpdate.AutoSize = true;
			this.lblNumberUpdate.Location = new System.Drawing.Point(51, 111);
			this.lblNumberUpdate.Name = "lblNumberUpdate";
			this.lblNumberUpdate.Size = new System.Drawing.Size(51, 15);
			this.lblNumberUpdate.TabIndex = 2;
			this.lblNumberUpdate.Text = "Number";
			// 
			// lblSurnameUpdate
			// 
			this.lblSurnameUpdate.AutoSize = true;
			this.lblSurnameUpdate.Location = new System.Drawing.Point(51, 71);
			this.lblSurnameUpdate.Name = "lblSurnameUpdate";
			this.lblSurnameUpdate.Size = new System.Drawing.Size(54, 15);
			this.lblSurnameUpdate.TabIndex = 1;
			this.lblSurnameUpdate.Text = "Surname";
			// 
			// lblNameUpdate
			// 
			this.lblNameUpdate.AutoSize = true;
			this.lblNameUpdate.Location = new System.Drawing.Point(51, 33);
			this.lblNameUpdate.Name = "lblNameUpdate";
			this.lblNameUpdate.Size = new System.Drawing.Size(39, 15);
			this.lblNameUpdate.TabIndex = 0;
			this.lblNameUpdate.Text = "Name";
			// 
			// lblSearch
			// 
			this.lblSearch.AutoSize = true;
			this.lblSearch.Location = new System.Drawing.Point(544, 23);
			this.lblSearch.Name = "lblSearch";
			this.lblSearch.Size = new System.Drawing.Size(42, 15);
			this.lblSearch.TabIndex = 3;
			this.lblSearch.Text = "Search";
			// 
			// tbxSearch
			// 
			this.tbxSearch.Location = new System.Drawing.Point(606, 20);
			this.tbxSearch.Name = "tbxSearch";
			this.tbxSearch.Size = new System.Drawing.Size(169, 23);
			this.tbxSearch.TabIndex = 4;
			this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(63, 19);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(107, 23);
			this.btnDelete.TabIndex = 5;
			this.btnDelete.Text = "Remove";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// ContactApp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(884, 475);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.tbxSearch);
			this.Controls.Add(this.lblSearch);
			this.Controls.Add(this.gbxUpdate);
			this.Controls.Add(this.gbxAdd);
			this.Controls.Add(this.dgvContacts);
			this.Name = "ContactApp";
			this.Text = "ContactApp";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).EndInit();
			this.gbxAdd.ResumeLayout(false);
			this.gbxAdd.PerformLayout();
			this.gbxUpdate.ResumeLayout(false);
			this.gbxUpdate.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DataGridView dgvContacts;
		private GroupBox gbxAdd;
		private Button btnAdd;
		private TextBox tbxNumber;
		private TextBox tbxSurname;
		private TextBox tbxName;
		private Label lblNumber;
		private Label lblSurname;
		private Label lblName;
		private GroupBox gbxUpdate;
		private Button btnUpdate;
		private TextBox tbxNumberUpdate;
		private TextBox tbxSurnameUpdate;
		private TextBox tbxNameUpdate;
		private Label lblNumberUpdate;
		private Label lblSurnameUpdate;
		private Label lblNameUpdate;
		private Label lblSearch;
		private TextBox tbxSearch;
		private Button btnDelete;
	}
}