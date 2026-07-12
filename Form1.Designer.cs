namespace LibraryManagementSystem
{
    partial class Form1
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
            this.panelHeader = new Panel();
            this.lblLogin = new Label();
            this.lblTitle = new Label();
            this.panelMain = new Panel();
            this.lblWelcome = new Label();
            this.btnBooks = new Button();
            this.btnMembers = new Button();
            this.btnTransactions = new Button();
            this.btnLogout = new Button();
            this.btnExit = new Button();
            this.lblFooter = new Label();

            // Form
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(240, 245, 252);
            this.ClientSize = new Size(900, 550);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Text = "Library Management System";
            this.StartPosition = FormStartPosition.CenterScreen;

            // Header
            panelHeader.BackColor = Color.FromArgb(46, 204, 113);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Height = 70;

            lblTitle.Text = "📚 Library Management System";
            lblTitle.ForeColor = Color.White;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(20, 20);
            lblTitle.AutoSize = true;

            lblLogin.Text = "Logged in as: Librarian";
            lblLogin.ForeColor = Color.White;
            lblLogin.Font = new Font("Segoe UI", 10F);
            lblLogin.AutoSize = true;
            lblLogin.Location = new Point(700, 25);

            panelHeader.Controls.Add(lblTitle);
            panelHeader.Controls.Add(lblLogin);

            // Main Panel
            panelMain.BackColor = Color.White;
            panelMain.Size = new Size(760, 380);
            panelMain.Location = new Point(70, 100);

            lblWelcome.Text = "Welcome to the Library Management System";
            lblWelcome.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.FromArgb(40, 70, 120);
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new Point(160, 20);

            // Buttons
            ConfigureButton(btnBooks, "📖 Books", 50, 90, true);
            ConfigureButton(btnMembers, "👤 Members", 310, 90, true);
            ConfigureButton(btnTransactions, "📋 Transactions", 570, 90, true);
            ConfigureButton(btnLogout, "🚪 Logout", 200, 200, false);
            ConfigureButton(btnExit, "❌ Exit", 430, 200, false);

            panelMain.Controls.Add(lblWelcome);
            panelMain.Controls.Add(btnBooks);
            panelMain.Controls.Add(btnMembers);
            panelMain.Controls.Add(btnTransactions);
            panelMain.Controls.Add(btnLogout);
            panelMain.Controls.Add(btnExit);

            // Footer
            lblFooter.Text = "© 2025 Library Management System";
            lblFooter.Font = new Font("Segoe UI", 9F);
            lblFooter.ForeColor = Color.Gray;
            lblFooter.AutoSize = true;
            lblFooter.Location = new Point(330, 500);

            // Add Controls
            this.Controls.Add(panelHeader);
            this.Controls.Add(panelMain);
            this.Controls.Add(lblFooter);
        }

        #endregion

        private Panel panelHeader;
        private Panel panelMain;
        private Label lblTitle;
        private Label lblLogin;
        private Label lblWelcome;
        private Label lblFooter;
        private Button btnBooks;
        private Button btnMembers;
        private Button btnTransactions;
        private Button btnLogout;
        private Button btnExit;

        private void ConfigureButton(Button btn, string text, int x, int y, bool primary)
        {
            btn.Text = text;
            btn.Size = new Size(210, 70);
            btn.Location = new Point(x, y);
            btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;

            if (primary)
            {
                btn.BackColor = Color.FromArgb(46, 204, 113);
                btn.ForeColor = Color.White;
            }
            else
            {
                btn.BackColor = Color.FromArgb(245, 247, 250);
                btn.ForeColor = Color.FromArgb(70, 90, 120);
            }
        }
    }
}
