namespace Lab4_task1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.getCustomersButton = new System.Windows.Forms.Button();
            this.CustomersListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // getCustomersButton
            // 
            this.getCustomersButton.Location = new System.Drawing.Point(12, 12);
            this.getCustomersButton.Name = "getCustomersButton";
            this.getCustomersButton.Size = new System.Drawing.Size(100, 42);
            this.getCustomersButton.TabIndex = 0;
            this.getCustomersButton.Text = "Get Customers";
            this.getCustomersButton.UseVisualStyleBackColor = true;
            this.getCustomersButton.Click += new System.EventHandler(this.getCustomersButton_Click);
            // 
            // CustomersListBox
            // 
            this.CustomersListBox.FormattingEnabled = true;
            this.CustomersListBox.Location = new System.Drawing.Point(12, 219);
            this.CustomersListBox.Name = "CustomersListBox";
            this.CustomersListBox.Size = new System.Drawing.Size(733, 212);
            this.CustomersListBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 446);
            this.Controls.Add(this.CustomersListBox);
            this.Controls.Add(this.getCustomersButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button getCustomersButton;
        private System.Windows.Forms.ListBox CustomersListBox;
    }
}

