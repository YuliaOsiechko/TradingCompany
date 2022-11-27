namespace WFUI.Forms
{
    partial class SendInvoiceForm
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
            this.invoicesComboBox = new System.Windows.Forms.ComboBox();
            this.sendInvoiceButton = new System.Windows.Forms.Button();
            this.managerLabel = new System.Windows.Forms.Label();
            this.productLabel = new System.Windows.Forms.Label();
            this.customerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // invoicesComboBox
            // 
            this.invoicesComboBox.DisplayMember = "Id";
            this.invoicesComboBox.FormattingEnabled = true;
            this.invoicesComboBox.Location = new System.Drawing.Point(39, 29);
            this.invoicesComboBox.Name = "invoicesComboBox";
            this.invoicesComboBox.Size = new System.Drawing.Size(379, 28);
            this.invoicesComboBox.TabIndex = 0;
            this.invoicesComboBox.ValueMember = "Id";
            this.invoicesComboBox.SelectedIndexChanged += new System.EventHandler(this.invoicesComboBox_SelectedIndexChanged);
            // 
            // sendInvoiceButton
            // 
            this.sendInvoiceButton.Location = new System.Drawing.Point(318, 178);
            this.sendInvoiceButton.Name = "sendInvoiceButton";
            this.sendInvoiceButton.Size = new System.Drawing.Size(113, 29);
            this.sendInvoiceButton.TabIndex = 1;
            this.sendInvoiceButton.Text = "Send Invoice";
            this.sendInvoiceButton.UseVisualStyleBackColor = true;
            this.sendInvoiceButton.Click += new System.EventHandler(this.sendInvoiceButton_Click);
            // 
            // managerLabel
            // 
            this.managerLabel.AutoSize = true;
            this.managerLabel.Location = new System.Drawing.Point(39, 83);
            this.managerLabel.Name = "managerLabel";
            this.managerLabel.Size = new System.Drawing.Size(75, 20);
            this.managerLabel.TabIndex = 2;
            this.managerLabel.Text = "Manager :";
            // 
            // productLabel
            // 
            this.productLabel.AutoSize = true;
            this.productLabel.Location = new System.Drawing.Point(39, 126);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(67, 20);
            this.productLabel.TabIndex = 3;
            this.productLabel.Text = "Product :";
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Location = new System.Drawing.Point(39, 164);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(79, 20);
            this.customerLabel.TabIndex = 4;
            this.customerLabel.Text = "Customer :";
            // 
            // SendInvoiceFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 214);
            this.Controls.Add(this.customerLabel);
            this.Controls.Add(this.productLabel);
            this.Controls.Add(this.managerLabel);
            this.Controls.Add(this.sendInvoiceButton);
            this.Controls.Add(this.invoicesComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SendInvoiceFrom";
            this.Text = "SendInvoiceFrom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox invoicesComboBox;
        private Button sendInvoiceButton;
        private Label managerLabel;
        private Label productLabel;
        private Label customerLabel;
    }
}