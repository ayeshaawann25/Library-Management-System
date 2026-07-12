namespace LibraryManagementSystem
{
    partial class Form4
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
            panelIssue = new Panel();
            lblSelectBook = new Label();
            cmbBook = new ComboBox();
            lblSelectMember = new Label();
            cmbMember = new ComboBox();
            lblIssueDate = new Label();
            dtpIssue = new DateTimePicker();
            btnIssue = new Button();
            btnReturn = new Button();
            panelReturn = new Panel();
            lblReturnDate = new Label();
            dtpReturn = new DateTimePicker();
            panelGrid = new Panel();
            dgvTransactions = new DataGridView();
            panelHeader.SuspendLayout();
            panelIssue.SuspendLayout();
            panelReturn.SuspendLayout();
            panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).BeginInit();
            SuspendLayout();

            // panelHeader
            panelHeader.BackColor = Color.FromArgb(155, 89, 182);
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
            lblTitle.Size = new Size(291, 32);
            lblTitle.Text = "Library - Book Transactions";

            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI", 10F);
            lblUser.ForeColor = Color.White;
            lblUser.Location = new Point(650, 18);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(179, 23);
            lblUser.Text = "Logged in as: Librarian";

            // panelIssue
            panelIssue.BackColor = Color.White;
            panelIssue.Controls.Add(lblSelectBook);
            panelIssue.Controls.Add(cmbBook);
            panelIssue.Controls.Add(lblSelectMember);
            panelIssue.Controls.Add(cmbMember);
            panelIssue.Controls.Add(lblIssueDate);
            panelIssue.Controls.Add(dtpIssue);
            panelIssue.Location = new Point(20, 80);
            panelIssue.Name = "panelIssue";
            panelIssue.Size = new Size(380, 180);
            panelIssue.TabIndex = 1;

            lblSelectBook.AutoSize = true;
            lblSelectBook.Location = new Point(20, 15);
            lblSelectBook.Name = "lblSelectBook";
            lblSelectBook.Size = new Size(82, 20);
            lblSelectBook.Text = "Select Book";

            cmbBook.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBook.Location = new Point(20, 40);
            cmbBook.Name = "cmbBook";
            cmbBook.Size = new Size(340, 28);
            cmbBook.TabIndex = 1;

            lblSelectMember.AutoSize = true;
            lblSelectMember.Location = new Point(20, 80);
            lblSelectMember.Name = "lblSelectMember";
            lblSelectMember.Size = new Size(103, 20);
            lblSelectMember.Text = "Select Member";

            cmbMember.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMember.Location = new Point(20, 105);
            cmbMember.Name = "cmbMember";
            cmbMember.Size = new Size(340, 28);
            cmbMember.TabIndex = 3;

            lblIssueDate.AutoSize = true;
            lblIssueDate.Location = new Point(20, 145);
            lblIssueDate.Name = "lblIssueDate";
            lblIssueDate.Size = new Size(76, 20);
            lblIssueDate.Text = "Issue Date";

            dtpIssue.Location = new Point(100, 142);
            dtpIssue.Name = "dtpIssue";
            dtpIssue.Size = new Size(260, 27);
            dtpIssue.TabIndex = 5;

            btnIssue.BackColor = Color.FromArgb(46, 204, 113);
            btnIssue.FlatAppearance.BorderSize = 0;
            btnIssue.FlatStyle = FlatStyle.Flat;
            btnIssue.ForeColor = Color.White;
            btnIssue.Location = new Point(20, 275);
            btnIssue.Name = "btnIssue";
            btnIssue.Size = new Size(160, 45);
            btnIssue.TabIndex = 2;
            btnIssue.Text = "📤 Issue Book";
            btnIssue.UseVisualStyleBackColor = false;

            btnReturn.BackColor = Color.FromArgb(52, 152, 219);
            btnReturn.FlatAppearance.BorderSize = 0;
            btnReturn.FlatStyle = FlatStyle.Flat;
            btnReturn.ForeColor = Color.White;
            btnReturn.Location = new Point(200, 275);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(160, 45);
            btnReturn.TabIndex = 3;
            btnReturn.Text = "📥 Return Book";
            btnReturn.UseVisualStyleBackColor = false;

            // panelReturn
            panelReturn.BackColor = Color.White;
            panelReturn.Controls.Add(lblReturnDate);
            panelReturn.Controls.Add(dtpReturn);
            panelReturn.Location = new Point(430, 80);
            panelReturn.Name = "panelReturn";
            panelReturn.Size = new Size(380, 180);
            panelReturn.TabIndex = 4;

            lblReturnDate.AutoSize = true;
            lblReturnDate.Location = new Point(20, 15);
            lblReturnDate.Name = "lblReturnDate";
            lblReturnDate.Size = new Size(88, 20);
            lblReturnDate.Text = "Return Date";

            dtpReturn.Location = new Point(20, 40);
            dtpReturn.Name = "dtpReturn";
            dtpReturn.Size = new Size(340, 27);
            dtpReturn.TabIndex = 1;

            // panelGrid
            panelGrid.BackColor = Color.White;
            panelGrid.Controls.Add(dgvTransactions);
            panelGrid.Location = new Point(20, 340);
            panelGrid.Name = "panelGrid";
            panelGrid.Size = new Size(810, 300);
            panelGrid.TabIndex = 5;

            dgvTransactions.AllowUserToAddRows = false;
            dgvTransactions.AllowUserToDeleteRows = false;
            dgvTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTransactions.BackgroundColor = Color.White;
            dgvTransactions.ColumnHeadersHeight = 29;
            dgvTransactions.Location = new Point(10, 10);
            dgvTransactions.Name = "dgvTransactions";
            dgvTransactions.ReadOnly = true;
            dgvTransactions.RowHeadersWidth = 51;
            dgvTransactions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTransactions.Size = new Size(790, 280);
            dgvTransactions.TabIndex = 0;

            // Form4
            BackColor = Color.FromArgb(244, 248, 255);
            ClientSize = new Size(850, 670);
            Controls.Add(panelHeader);
            Controls.Add(panelIssue);
            Controls.Add(btnIssue);
            Controls.Add(btnReturn);
            Controls.Add(panelReturn);
            Controls.Add(panelGrid);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Library - Book Transactions";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelIssue.ResumeLayout(false);
            panelIssue.PerformLayout();
            panelReturn.ResumeLayout(false);
            panelReturn.PerformLayout();
            panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblTitle;
        private Label lblUser;
        private Panel panelIssue;
        private Label lblSelectBook;
        private ComboBox cmbBook;
        private Label lblSelectMember;
        private ComboBox cmbMember;
        private Label lblIssueDate;
        private DateTimePicker dtpIssue;
        private Button btnIssue;
        private Button btnReturn;
        private Panel panelReturn;
        private Label lblReturnDate;
        private DateTimePicker dtpReturn;
        private Panel panelGrid;
        private DataGridView dgvTransactions;
    }
}
