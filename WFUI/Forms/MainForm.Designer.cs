namespace WFUI
{
    partial class MainForm
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.profileTabPage = new System.Windows.Forms.TabPage();
            this.changeDisplayNameButton = new System.Windows.Forms.Button();
            this.changePasswordButton = new System.Windows.Forms.Button();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.displayNameLabel = new System.Windows.Forms.Label();
            this.ordersTabPage = new System.Windows.Forms.TabPage();
            this.ordersDataGridView = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.repeatOrderToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.CommentToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.showComments_ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.searchToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.sortDescToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.sortAscToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.invoicesDataGridView = new System.Windows.Forms.DataGridView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.addInvoiceToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.sendInvoiceButton = new System.Windows.Forms.ToolStripButton();
            this.tabControl.SuspendLayout();
            this.profileTabPage.SuspendLayout();
            this.ordersTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesDataGridView)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.profileTabPage);
            this.tabControl.Controls.Add(this.ordersTabPage);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(439, 281);
            this.tabControl.TabIndex = 0;
            // 
            // profileTabPage
            // 
            this.profileTabPage.Controls.Add(this.changeDisplayNameButton);
            this.profileTabPage.Controls.Add(this.changePasswordButton);
            this.profileTabPage.Controls.Add(this.passwordLabel);
            this.profileTabPage.Controls.Add(this.loginLabel);
            this.profileTabPage.Controls.Add(this.displayNameLabel);
            this.profileTabPage.Location = new System.Drawing.Point(4, 29);
            this.profileTabPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.profileTabPage.Name = "profileTabPage";
            this.profileTabPage.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.profileTabPage.Size = new System.Drawing.Size(431, 248);
            this.profileTabPage.TabIndex = 0;
            this.profileTabPage.Text = "Profile";
            this.profileTabPage.UseVisualStyleBackColor = true;
            // 
            // changeDisplayNameButton
            // 
            this.changeDisplayNameButton.Location = new System.Drawing.Point(27, 175);
            this.changeDisplayNameButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.changeDisplayNameButton.Name = "changeDisplayNameButton";
            this.changeDisplayNameButton.Size = new System.Drawing.Size(169, 31);
            this.changeDisplayNameButton.TabIndex = 4;
            this.changeDisplayNameButton.Text = "Change Display Name";
            this.changeDisplayNameButton.UseVisualStyleBackColor = true;
            this.changeDisplayNameButton.Click += new System.EventHandler(this.changeDisplayNameButton_Click);
            // 
            // changePasswordButton
            // 
            this.changePasswordButton.Location = new System.Drawing.Point(216, 175);
            this.changePasswordButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.changePasswordButton.Name = "changePasswordButton";
            this.changePasswordButton.Size = new System.Drawing.Size(169, 31);
            this.changePasswordButton.TabIndex = 3;
            this.changePasswordButton.Text = "Change Password";
            this.changePasswordButton.UseVisualStyleBackColor = true;
            this.changePasswordButton.Click += new System.EventHandler(this.changePasswordButton_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(27, 124);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(70, 20);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Password";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(27, 80);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(46, 20);
            this.loginLabel.TabIndex = 1;
            this.loginLabel.Text = "Login";
            // 
            // displayNameLabel
            // 
            this.displayNameLabel.AutoSize = true;
            this.displayNameLabel.Location = new System.Drawing.Point(27, 39);
            this.displayNameLabel.Name = "displayNameLabel";
            this.displayNameLabel.Size = new System.Drawing.Size(102, 20);
            this.displayNameLabel.TabIndex = 0;
            this.displayNameLabel.Text = "Display Name";
            // 
            // ordersTabPage
            // 
            this.ordersTabPage.Controls.Add(this.ordersDataGridView);
            this.ordersTabPage.Controls.Add(this.toolStrip1);
            this.ordersTabPage.Location = new System.Drawing.Point(4, 29);
            this.ordersTabPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ordersTabPage.Name = "ordersTabPage";
            this.ordersTabPage.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ordersTabPage.Size = new System.Drawing.Size(431, 248);
            this.ordersTabPage.TabIndex = 1;
            this.ordersTabPage.Text = "Orders";
            this.ordersTabPage.UseVisualStyleBackColor = true;
            // 
            // ordersDataGridView
            // 
            this.ordersDataGridView.AllowUserToAddRows = false;
            this.ordersDataGridView.AllowUserToDeleteRows = false;
            this.ordersDataGridView.AllowUserToResizeColumns = false;
            this.ordersDataGridView.AllowUserToResizeRows = false;
            this.ordersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ordersDataGridView.Location = new System.Drawing.Point(3, 31);
            this.ordersDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ordersDataGridView.MultiSelect = false;
            this.ordersDataGridView.Name = "ordersDataGridView";
            this.ordersDataGridView.RowHeadersWidth = 51;
            this.ordersDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ordersDataGridView.RowTemplate.Height = 25;
            this.ordersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ordersDataGridView.Size = new System.Drawing.Size(425, 213);
            this.ordersDataGridView.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.repeatOrderToolStripButton1,
            this.CommentToolStripButton,
            this.showComments_ToolStripButton,
            this.toolStripSeparator1,
            this.searchToolStripTextBox,
            this.toolStripSeparator2,
            this.sortDescToolStripButton,
            this.sortAscToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(3, 4);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(425, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // repeatOrderToolStripButton1
            // 
            this.repeatOrderToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.repeatOrderToolStripButton1.Image = global::WFUI.Properties.Resources.Repeat_Icon;
            this.repeatOrderToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.repeatOrderToolStripButton1.Name = "repeatOrderToolStripButton1";
            this.repeatOrderToolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.repeatOrderToolStripButton1.Text = "Repeat Order";
            this.repeatOrderToolStripButton1.Click += new System.EventHandler(this.RepeatOrderToolStripButton_Click);
            // 
            // CommentToolStripButton
            // 
            this.CommentToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CommentToolStripButton.Image = global::WFUI.Properties.Resources.Comment_Icon;
            this.CommentToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CommentToolStripButton.Name = "CommentToolStripButton";
            this.CommentToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.CommentToolStripButton.Text = "Comment";
            this.CommentToolStripButton.Click += new System.EventHandler(this.CommentToolStripButton_Click);
            // 
            // showComments_ToolStripButton
            // 
            this.showComments_ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.showComments_ToolStripButton.Image = global::WFUI.Properties.Resources.CommentList_Icon1;
            this.showComments_ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.showComments_ToolStripButton.Name = "showComments_ToolStripButton";
            this.showComments_ToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.showComments_ToolStripButton.Text = "Show Comments";
            this.showComments_ToolStripButton.Click += new System.EventHandler(this.ShowCommentsToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // searchToolStripTextBox
            // 
            this.searchToolStripTextBox.Name = "searchToolStripTextBox";
            this.searchToolStripTextBox.Size = new System.Drawing.Size(114, 27);
            this.searchToolStripTextBox.TextChanged += new System.EventHandler(this.SearchToolStripTextBox_TextChanged);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // sortDescToolStripButton
            // 
            this.sortDescToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sortDescToolStripButton.Image = global::WFUI.Properties.Resources.DownArrow;
            this.sortDescToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sortDescToolStripButton.Name = "sortDescToolStripButton";
            this.sortDescToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.sortDescToolStripButton.Text = "Sort Descending";
            this.sortDescToolStripButton.Click += new System.EventHandler(this.SortDescToolStripButton_Click);
            // 
            // sortAscToolStripButton
            // 
            this.sortAscToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sortAscToolStripButton.Image = global::WFUI.Properties.Resources.UpArrow;
            this.sortAscToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sortAscToolStripButton.Name = "sortAscToolStripButton";
            this.sortAscToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.sortAscToolStripButton.Text = "Sort Ascending";
            this.sortAscToolStripButton.Click += new System.EventHandler(this.sortAscToolStripButton_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.invoicesDataGridView);
            this.tabPage1.Controls.Add(this.toolStrip2);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(431, 248);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Invoices";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // invoicesDataGridView
            // 
            this.invoicesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invoicesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.invoicesDataGridView.Location = new System.Drawing.Point(3, 30);
            this.invoicesDataGridView.Name = "invoicesDataGridView";
            this.invoicesDataGridView.RowHeadersWidth = 51;
            this.invoicesDataGridView.RowTemplate.Height = 29;
            this.invoicesDataGridView.Size = new System.Drawing.Size(425, 215);
            this.invoicesDataGridView.TabIndex = 4;
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addInvoiceToolStripButton,
            this.sendInvoiceButton});
            this.toolStrip2.Location = new System.Drawing.Point(3, 3);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(425, 27);
            this.toolStrip2.TabIndex = 3;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // addInvoiceToolStripButton
            // 
            this.addInvoiceToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addInvoiceToolStripButton.Image = global::WFUI.Properties.Resources.Plus_Icon;
            this.addInvoiceToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addInvoiceToolStripButton.Name = "addInvoiceToolStripButton";
            this.addInvoiceToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.addInvoiceToolStripButton.Text = "toolStripButton1";
            this.addInvoiceToolStripButton.Click += new System.EventHandler(this.addInvoiceToolStripButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(307, 223);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 29);
            this.button2.TabIndex = 2;
            this.button2.Text = "Send Invoice";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(173, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add Invoice";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // sendInvoiceButton
            // 
            this.sendInvoiceButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sendInvoiceButton.Image = global::WFUI.Properties.Resources.SortAscending_Icon;
            this.sendInvoiceButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sendInvoiceButton.Name = "sendInvoiceButton";
            this.sendInvoiceButton.Size = new System.Drawing.Size(29, 24);
            this.sendInvoiceButton.Text = "toolStripButton1";
            this.sendInvoiceButton.Click += new System.EventHandler(this.sendInvoiceButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 281);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.tabControl.ResumeLayout(false);
            this.profileTabPage.ResumeLayout(false);
            this.profileTabPage.PerformLayout();
            this.ordersTabPage.ResumeLayout(false);
            this.ordersTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesDataGridView)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl;
        private TabPage profileTabPage;
        private TabPage ordersTabPage;
        private Label passwordLabel;
        private Label loginLabel;
        private Label displayNameLabel;
        private Button changePasswordButton;
        private Button changeDisplayNameButton;
        private DataGridView ordersDataGridView;
        private ToolStrip toolStrip1;
        private ToolStripButton repeatOrderToolStripButton1;
        private ToolStripButton CommentToolStripButton;
        private ToolStripButton showComments_ToolStripButton;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripTextBox searchToolStripTextBox;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton sortDescToolStripButton;
        private ToolStripButton sortAscToolStripButton;
        private TabPage tabPage1;
        private Button button2;
        private Button button1;
        private DataGridView invoicesDataGridView;
        private ToolStrip toolStrip2;
        private ToolStripButton addInvoiceToolStripButton;
        private ToolStripButton sendInvoiceButton;
    }
}