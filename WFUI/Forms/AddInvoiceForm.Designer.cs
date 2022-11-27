namespace WFUI.Forms
{
    partial class AddInvoiceForm
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
            this.ordersComboBox = new System.Windows.Forms.ComboBox();
            this.customerLabel = new System.Windows.Forms.Label();
            this.productLabel = new System.Windows.Forms.Label();
            this.dateTimeLabel = new System.Windows.Forms.Label();
            this.addInvoiceButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ordersComboBox
            // 
            this.ordersComboBox.DisplayMember = "Id";
            this.ordersComboBox.FormattingEnabled = true;
            this.ordersComboBox.Location = new System.Drawing.Point(36, 32);
            this.ordersComboBox.Name = "ordersComboBox";
            this.ordersComboBox.Size = new System.Drawing.Size(347, 28);
            this.ordersComboBox.TabIndex = 0;
            this.ordersComboBox.ValueMember = "Id";
            this.ordersComboBox.SelectedIndexChanged += new System.EventHandler(this.ordersComboBox_SelectedIndexChanged);
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Location = new System.Drawing.Point(45, 88);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(91, 20);
            this.customerLabel.TabIndex = 1;
            this.customerLabel.Text = "Customer :   ";
            // 
            // productLabel
            // 
            this.productLabel.AutoSize = true;
            this.productLabel.Location = new System.Drawing.Point(45, 149);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(91, 20);
            this.productLabel.TabIndex = 2;
            this.productLabel.Text = "Product :      ";
            // 
            // dateTimeLabel
            // 
            this.dateTimeLabel.AutoSize = true;
            this.dateTimeLabel.Location = new System.Drawing.Point(45, 206);
            this.dateTimeLabel.Name = "dateTimeLabel";
            this.dateTimeLabel.Size = new System.Drawing.Size(95, 20);
            this.dateTimeLabel.TabIndex = 3;
            this.dateTimeLabel.Text = "Date/Time :  ";
            // 
            // addInvoiceButton
            // 
            this.addInvoiceButton.Location = new System.Drawing.Point(282, 231);
            this.addInvoiceButton.Name = "addInvoiceButton";
            this.addInvoiceButton.Size = new System.Drawing.Size(123, 29);
            this.addInvoiceButton.TabIndex = 4;
            this.addInvoiceButton.Text = "Add Invoice";
            this.addInvoiceButton.UseVisualStyleBackColor = true;
            this.addInvoiceButton.Click += new System.EventHandler(this.addInvoiceButton_Click);
            // 
            // AddInvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 272);
            this.Controls.Add(this.addInvoiceButton);
            this.Controls.Add(this.dateTimeLabel);
            this.Controls.Add(this.productLabel);
            this.Controls.Add(this.customerLabel);
            this.Controls.Add(this.ordersComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddInvoiceForm";
            this.Text = "AddInvoiceForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox ordersComboBox;
        private Label customerLabel;
        private Label productLabel;
        private Label dateTimeLabel;
        private Button addInvoiceButton;
    }
}