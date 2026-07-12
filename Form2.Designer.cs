namespace LibraryManagementSystem
{
    partial class Form2
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
            lblTitleText = new Label();
            txtTitle = new TextBox();
            lblAuthor = new Label();
            txtAuthor = new TextBox();
            lblISBN = new Label();
            txtISBN = new TextBox();
            lblCategory = new Label();
            cmbCategory = new ComboBox();
            lblQuantity = new Label();
            txtQuantity = new TextBox();
            btnSave = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            panelGrid = new Panel();
            lblSearch = new Label();
            txtSearch = new TextBox();
            dgvBooks = new DataGridView();
            panelHeader.SuspendLayout();
            panelForm.SuspendLayout();
            panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            SuspendLayout();

            // panelHeader
            panelHeader.BackColor = Color.FromArgb(46, 204, 113);
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
            lblTitle.Size = new Size(287, 32);
            lblTitle.Text = "Library - Book Management";

            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI", 10F);
            lblUser.ForeColor = Color.White;
            lblUser.Location = new Point(650, 18);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(179, 23);
            lblUser.Text = "Logged in as: Librarian";

            // panelForm
            panelForm.BackColor = Color.White;
            panelForm.Controls.Add(lblTitleText);
            panelForm.Controls.Add(txtTitle);
            panelForm.Controls.Add(lblAuthor);
            panelForm.Controls.Add(txtAuthor);
            panelForm.Controls.Add(lblISBN);
            panelForm.Controls.Add(txtISBN);
            panelForm.Controls.Add(lblCategory);
            panelForm.Controls.Add(cmbCategory);
            panelForm.Controls.Add(lblQuantity);
            panelForm.Controls.Add(txtQuantity);
            panelForm.Location = new Point(20, 80);
            panelForm.Name = "panelForm";
            panelForm.Size = new Size(380, 330);
            panelForm.TabIndex = 1;

            lblTitleText.AutoSize = true;
            lblTitleText.Location = new Point(20, 20);
            lblTitleText.Name = "lblTitleText";
            lblTitleText.Size = new Size(38, 20);
            lblTitleText.Text = "Title";

            txtTitle.Location = new Point(20, 45);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(340, 27);
            txtTitle.TabIndex = 1;

            lblAuthor.AutoSize = true;
            lblAuthor.Location = new Point(20, 80);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(54, 20);
            lblAuthor.Text = "Author";

            txtAuthor.Location = new Point(20, 105);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(340, 27);
            txtAuthor.TabIndex = 3;

            lblISBN.AutoSize = true;
            lblISBN.Location = new Point(20, 140);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new Size(42, 20);
            lblISBN.Text = "ISBN";

            txtISBN.Location = new Point(20, 165);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(340, 27);
            txtISBN.TabIndex = 5;

            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(20, 200);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(69, 20);
            lblCategory.Text = "Category";

            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.Location = new Point(20, 225);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(340, 28);
            cmbCategory.TabIndex = 7;
            cmbCategory.Items.AddRange(new object[] { "Fiction", "Non-Fiction", "Science", "Technology", "History", "Philosophy", "Literature", "Children", "Academic", "Reference" });

            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(20, 260);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(65, 20);
            lblQuantity.Text = "Quantity";

            txtQuantity.Location = new Point(20, 285);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(340, 27);
            txtQuantity.TabIndex = 9;

            // Buttons
            btnSave.BackColor = Color.FromArgb(46, 204, 113);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(430, 100);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 40);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;

            btnUpdate.BackColor = Color.FromArgb(46, 204, 113);
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
            panelGrid.Controls.Add(dgvBooks);
            panelGrid.Location = new Point(20, 430);
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

            dgvBooks.AllowUserToAddRows = false;
            dgvBooks.AllowUserToDeleteRows = false;
            dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBooks.BackgroundColor = Color.White;
            dgvBooks.ColumnHeadersHeight = 29;
            dgvBooks.Location = new Point(10, 50);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.ReadOnly = true;
            dgvBooks.RowHeadersWidth = 51;
            dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBooks.Size = new Size(790, 140);
            dgvBooks.TabIndex = 0;

            // Form2
            BackColor = Color.FromArgb(244, 248, 255);
            ClientSize = new Size(850, 660);
            Controls.Add(panelHeader);
            Controls.Add(panelForm);
            Controls.Add(btnSave);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(panelGrid);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Library - Book Management";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelForm.ResumeLayout(false);
            panelForm.PerformLayout();
            panelGrid.ResumeLayout(false);
            panelGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblTitle;
        private Label lblUser;
        private Panel panelForm;
        private Label lblTitleText;
        private TextBox txtTitle;
        private Label lblAuthor;
        private TextBox txtAuthor;
        private Label lblISBN;
        private TextBox txtISBN;
        private Label lblCategory;
        private ComboBox cmbCategory;
        private Label lblQuantity;
        private TextBox txtQuantity;
        private Button btnSave;
        private Button btnUpdate;
        private Button btnDelete;
        private Panel panelGrid;
        private Label lblSearch;
        private TextBox txtSearch;
        private DataGridView dgvBooks;
    }
}
