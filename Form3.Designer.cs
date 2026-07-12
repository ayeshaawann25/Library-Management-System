namespace LibraryManagementSystem
{
    partial class Form3
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panelHeader = new Panel();
            lblTitle = new Label();
            lblUser = new Label();
            panelForm = new Panel();
            lblFullName = new Label();
            txtFullName = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblPhone = new Label();
            txtPhone = new TextBox();
            lblAddress = new Label();
            txtAddress = new TextBox();
            lblMembershipDate = new Label();
            dtpMembership = new DateTimePicker();
            btnSave = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            panelGrid = new Panel();
            lblSearch = new Label();
            txtSearch = new TextBox();
            dgvMembers = new DataGridView();
            panelHeader.SuspendLayout();
            panelForm.SuspendLayout();
            panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMembers).BeginInit();
            SuspendLayout();

            // panelHeader
            panelHeader.BackColor = Color.FromArgb(52, 152, 219);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Controls.Add(lblUser);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(850, 60);
            panelHeader.TabIndex = 0;

            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(298, 32);
            lblTitle.Text = "Library - Member Management";

            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI", 10F);
            lblUser.ForeColor = Color.White;
            lblUser.Location = new Point(650, 18);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(179, 23);
            lblUser.Text = "Logged in as: Librarian";

            // panelForm
            panelForm.BackColor = Color.White;
            panelForm.Controls.Add(lblFullName);
            panelForm.Controls.Add(txtFullName);
            panelForm.Controls.Add(lblEmail);
            panelForm.Controls.Add(txtEmail);
            panelForm.Controls.Add(lblPhone);
            panelForm.Controls.Add(txtPhone);
            panelForm.Controls.Add(lblAddress);
            panelForm.Controls.Add(txtAddress);
            panelForm.Controls.Add(lblMembershipDate);
            panelForm.Controls.Add(dtpMembership);
            panelForm.Location = new Point(20, 80);
            panelForm.Name = "panelForm";
            panelForm.Size = new Size(380, 350);
            panelForm.TabIndex = 1;

            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(20, 20);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(76, 20);
            lblFullName.Text = "Full Name";

            txtFullName.Location = new Point(20, 45);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(340, 27);
            txtFullName.TabIndex = 1;

            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(20, 80);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.Text = "Email";

            txtEmail.Location = new Point(20, 105);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(340, 27);
            txtEmail.TabIndex = 3;

            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(20, 140);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(50, 20);
            lblPhone.Text = "Phone";

            txtPhone.Location = new Point(20, 165);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(340, 27);
            txtPhone.TabIndex = 5;

            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(20, 200);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(62, 20);
            lblAddress.Text = "Address";

            txtAddress.Location = new Point(20, 225);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(340, 27);
            txtAddress.TabIndex = 7;

            lblMembershipDate.AutoSize = true;
            lblMembershipDate.Location = new Point(20, 260);
            lblMembershipDate.Name = "lblMembershipDate";
            lblMembershipDate.Size = new Size(124, 20);
            lblMembershipDate.Text = "Membership Date";

            dtpMembership.Location = new Point(20, 285);
            dtpMembership.Name = "dtpMembership";
            dtpMembership.Size = new Size(340, 27);
            dtpMembership.TabIndex = 9;

            // Buttons
            btnSave.BackColor = Color.FromArgb(52, 152, 219);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(430, 100);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 40);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;

            btnUpdate.BackColor = Color.FromArgb(52, 152, 219);
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(540, 100);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 40);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;

            btnDelete.BackColor = Color.FromArgb(231, 76, 60);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(650, 100);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 40);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;

            // panelGrid
            panelGrid.BackColor = Color.White;
            panelGrid.Controls.Add(lblSearch);
            panelGrid.Controls.Add(txtSearch);
            panelGrid.Controls.Add(dgvMembers);
            panelGrid.Location = new Point(20, 450);
            panelGrid.Name = "panelGrid";
            panelGrid.Size = new Size(810, 200);
            panelGrid.TabIndex = 5;

            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(10, 15);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(53, 20);
            lblSearch.Text = "Search:";

            txtSearch.Location = new Point(70, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(250, 27);
            txtSearch.TabIndex = 1;

            dgvMembers.AllowUserToAddRows = false;
            dgvMembers.AllowUserToDeleteRows = false;
            dgvMembers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMembers.BackgroundColor = Color.White;
            dgvMembers.ColumnHeadersHeight = 29;
            dgvMembers.Location = new Point(10, 50);
            dgvMembers.Name = "dgvMembers";
            dgvMembers.ReadOnly = true;
            dgvMembers.RowHeadersWidth = 51;
            dgvMembers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMembers.Size = new Size(790, 140);
            dgvMembers.TabIndex = 0;

            // Form3
            BackColor = Color.FromArgb(244, 248, 255);
            ClientSize = new Size(850, 680);
            Controls.Add(panelHeader);
            Controls.Add(panelForm);
            Controls.Add(btnSave);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(panelGrid);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Library - Member Management";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelForm.ResumeLayout(false);
            panelForm.PerformLayout();
            panelGrid.ResumeLayout(false);
            panelGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMembers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblTitle;
        private Label lblUser;
        private Panel panelForm;
        private Label lblFullName;
        private TextBox txtFullName;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblPhone;
        private TextBox txtPhone;
        private Label lblAddress;
        private TextBox txtAddress;
        private Label lblMembershipDate;
        private DateTimePicker dtpMembership;
        private Button btnSave;
        private Button btnUpdate;
        private Button btnDelete;
        private Panel panelGrid;
        private Label lblSearch;
        private TextBox txtSearch;
        private DataGridView dgvMembers;
    }
}
