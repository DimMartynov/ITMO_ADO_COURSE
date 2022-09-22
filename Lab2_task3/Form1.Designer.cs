namespace Lab2_task3
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ConnectionListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.productListBtn = new System.Windows.Forms.Button();
            this.productList = new System.Windows.Forms.ListView();
            this.productName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.transactionBtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 57);
            this.button1.TabIndex = 0;
            this.button1.Text = "Подключить БД";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 90);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 57);
            this.button2.TabIndex = 1;
            this.button2.Text = "Отключить БД";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(618, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConnectionListToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(48, 20);
            this.toolStripMenuItem1.Text = "Файл";
            // 
            // ConnectionListToolStripMenuItem
            // 
            this.ConnectionListToolStripMenuItem.Name = "ConnectionListToolStripMenuItem";
            this.ConnectionListToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.ConnectionListToolStripMenuItem.Text = "Список подключений";
            this.ConnectionListToolStripMenuItem.Click += new System.EventHandler(this.ConnectionListToolStripMenuItem_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(229, 27);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 57);
            this.button3.TabIndex = 3;
            this.button3.Text = "Сколько продуктов";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(367, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Сколько продуктов";
            // 
            // productListBtn
            // 
            this.productListBtn.Location = new System.Drawing.Point(229, 106);
            this.productListBtn.Name = "productListBtn";
            this.productListBtn.Size = new System.Drawing.Size(110, 57);
            this.productListBtn.TabIndex = 5;
            this.productListBtn.Text = "Список продуктов";
            this.productListBtn.UseVisualStyleBackColor = true;
            this.productListBtn.Click += new System.EventHandler(this.productListBtn_Click);
            // 
            // productList
            // 
            this.productList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.productName});
            this.productList.HideSelection = false;
            this.productList.Location = new System.Drawing.Point(370, 90);
            this.productList.Name = "productList";
            this.productList.Size = new System.Drawing.Size(180, 170);
            this.productList.TabIndex = 6;
            this.productList.UseCompatibleStateImageBehavior = false;
            this.productList.View = System.Windows.Forms.View.Details;
            // 
            // productName
            // 
            this.productName.Text = "Название продукта";
            // 
            // transactionBtn
            // 
            this.transactionBtn.Location = new System.Drawing.Point(229, 183);
            this.transactionBtn.Name = "transactionBtn";
            this.transactionBtn.Size = new System.Drawing.Size(110, 57);
            this.transactionBtn.TabIndex = 7;
            this.transactionBtn.Text = "Транзакция";
            this.transactionBtn.UseVisualStyleBackColor = true;
            this.transactionBtn.Click += new System.EventHandler(this.transactionBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 347);
            this.Controls.Add(this.transactionBtn);
            this.Controls.Add(this.productList);
            this.Controls.Add(this.productListBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ConnectionListToolStripMenuItem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button productListBtn;
        private System.Windows.Forms.ListView productList;
        private System.Windows.Forms.ColumnHeader productName;
        private System.Windows.Forms.Button transactionBtn;
    }
}

