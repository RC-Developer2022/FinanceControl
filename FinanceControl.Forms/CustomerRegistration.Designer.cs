namespace FinanceControl.Forms
{
    partial class CustomerRegistration
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
            if(disposing && (components != null))
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
            customerNameLabel = new Label();
            txtCustomerName = new TextBox();
            customerPhoneLabel = new Label();
            txtCustomerPhone = new TextBox();
            SuspendLayout();
            // 
            // customerNameLabel
            // 
            customerNameLabel.AutoSize = true;
            customerNameLabel.Location = new Point(22 , 19);
            customerNameLabel.Name = "customerNameLabel";
            customerNameLabel.Size = new Size(50 , 20);
            customerNameLabel.TabIndex = 0;
            customerNameLabel.Text = "Nome";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(22 , 42);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(217 , 27);
            txtCustomerName.TabIndex = 1;
            // 
            // customerPhoneLabel
            // 
            customerPhoneLabel.AutoSize = true;
            customerPhoneLabel.Location = new Point(266 , 19);
            customerPhoneLabel.Name = "customerPhoneLabel";
            customerPhoneLabel.Size = new Size(66 , 20);
            customerPhoneLabel.TabIndex = 2;
            customerPhoneLabel.Text = "Telefone";
            // 
            // textBox1
            // 
            txtCustomerPhone.Location = new Point(266 , 42);
            txtCustomerPhone.Name = "txtCustomerPhone";
            txtCustomerPhone.Size = new Size(165 , 27);
            txtCustomerPhone.TabIndex = 3;
            // 
            // CustomerRegistration
            // 
            AutoScaleDimensions = new SizeF(8F , 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800 , 450);
            Controls.Add(textBox1);
            Controls.Add(customerPhoneLabel);
            Controls.Add(txtCustomerName);
            Controls.Add(customerNameLabel);
            Name = "CustomerRegistration";
            Text = "CustomerRegistration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label customerNameLabel;
        private TextBox txtCustomerName;
        private Label customerPhoneLabel;
        private TextBox txtCustomerPhone;
    }
}
