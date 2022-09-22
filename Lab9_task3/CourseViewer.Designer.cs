namespace Lab9_task3
{
    partial class CourseViewer
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
            this.courseGridView = new System.Windows.Forms.DataGridView();
            this.departmentList = new System.Windows.Forms.ComboBox();
            this.saveChanges = new System.Windows.Forms.Button();
            this.closeForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.courseGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // courseGridView
            // 
            this.courseGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courseGridView.Location = new System.Drawing.Point(12, 191);
            this.courseGridView.Name = "courseGridView";
            this.courseGridView.Size = new System.Drawing.Size(776, 247);
            this.courseGridView.TabIndex = 0;
            // 
            // departmentList
            // 
            this.departmentList.FormattingEnabled = true;
            this.departmentList.Location = new System.Drawing.Point(12, 12);
            this.departmentList.Name = "departmentList";
            this.departmentList.Size = new System.Drawing.Size(121, 21);
            this.departmentList.TabIndex = 1;
            this.departmentList.SelectedIndexChanged += new System.EventHandler(this.departmentList_SelectedIndexChanged);
            // 
            // saveChanges
            // 
            this.saveChanges.Location = new System.Drawing.Point(12, 39);
            this.saveChanges.Name = "saveChanges";
            this.saveChanges.Size = new System.Drawing.Size(102, 50);
            this.saveChanges.TabIndex = 2;
            this.saveChanges.Text = "Обновить";
            this.saveChanges.UseVisualStyleBackColor = true;
            this.saveChanges.Click += new System.EventHandler(this.saveChanges_Click);
            // 
            // closeForm
            // 
            this.closeForm.Location = new System.Drawing.Point(12, 95);
            this.closeForm.Name = "closeForm";
            this.closeForm.Size = new System.Drawing.Size(102, 50);
            this.closeForm.TabIndex = 3;
            this.closeForm.Text = "Закрыть";
            this.closeForm.UseVisualStyleBackColor = true;
            // 
            // CourseViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.closeForm);
            this.Controls.Add(this.saveChanges);
            this.Controls.Add(this.departmentList);
            this.Controls.Add(this.courseGridView);
            this.Name = "CourseViewer";
            this.Text = "Course Viewer";
            this.Load += new System.EventHandler(this.CourseViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.courseGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView courseGridView;
        private System.Windows.Forms.ComboBox departmentList;
        private System.Windows.Forms.Button saveChanges;
        private System.Windows.Forms.Button closeForm;
    }
}

