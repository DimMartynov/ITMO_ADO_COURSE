namespace EXAM
{
    partial class DataTables
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UsersRad = new System.Windows.Forms.RadioButton();
            this.ourTableRad = new System.Windows.Forms.RadioButton();
            this.tableSourceRad = new System.Windows.Forms.RadioButton();
            this.updateBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tsTB1 = new System.Windows.Forms.TextBox();
            this.tsTB2 = new System.Windows.Forms.TextBox();
            this.tsTB3 = new System.Windows.Forms.TextBox();
            this.tsTB4 = new System.Windows.Forms.TextBox();
            this.tsTB5 = new System.Windows.Forms.TextBox();
            this.tsTB6 = new System.Windows.Forms.TextBox();
            this.tsAddBox = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.otAddBox = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.oTB5 = new System.Windows.Forms.TextBox();
            this.oTB1 = new System.Windows.Forms.TextBox();
            this.oTB4 = new System.Windows.Forms.TextBox();
            this.oTB2 = new System.Windows.Forms.TextBox();
            this.oTB3 = new System.Windows.Forms.TextBox();
            this.usersAddBox = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.uTB1 = new System.Windows.Forms.TextBox();
            this.uTB2 = new System.Windows.Forms.TextBox();
            this.delTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.delBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tsAddBox.SuspendLayout();
            this.otAddBox.SuspendLayout();
            this.usersAddBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 279);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.UsersRad);
            this.groupBox1.Controls.Add(this.ourTableRad);
            this.groupBox1.Controls.Add(this.tableSourceRad);
            this.groupBox1.Location = new System.Drawing.Point(809, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор таблицы";
            // 
            // UsersRad
            // 
            this.UsersRad.AutoSize = true;
            this.UsersRad.Location = new System.Drawing.Point(6, 65);
            this.UsersRad.Name = "UsersRad";
            this.UsersRad.Size = new System.Drawing.Size(52, 17);
            this.UsersRad.TabIndex = 2;
            this.UsersRad.TabStop = true;
            this.UsersRad.Text = "Users";
            this.UsersRad.UseVisualStyleBackColor = true;
            this.UsersRad.CheckedChanged += new System.EventHandler(this.UsersRad_CheckedChanged);
            // 
            // ourTableRad
            // 
            this.ourTableRad.AutoSize = true;
            this.ourTableRad.Location = new System.Drawing.Point(6, 42);
            this.ourTableRad.Name = "ourTableRad";
            this.ourTableRad.Size = new System.Drawing.Size(72, 17);
            this.ourTableRad.TabIndex = 1;
            this.ourTableRad.TabStop = true;
            this.ourTableRad.Text = "Our Table";
            this.ourTableRad.UseVisualStyleBackColor = true;
            this.ourTableRad.CheckedChanged += new System.EventHandler(this.ourTableRad_CheckedChanged);
            // 
            // tableSourceRad
            // 
            this.tableSourceRad.AutoSize = true;
            this.tableSourceRad.Location = new System.Drawing.Point(6, 19);
            this.tableSourceRad.Name = "tableSourceRad";
            this.tableSourceRad.Size = new System.Drawing.Size(89, 17);
            this.tableSourceRad.TabIndex = 0;
            this.tableSourceRad.TabStop = true;
            this.tableSourceRad.Text = "Table Source";
            this.tableSourceRad.UseVisualStyleBackColor = true;
            this.tableSourceRad.CheckedChanged += new System.EventHandler(this.tableSourceRad_CheckedChanged);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(840, 118);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(139, 46);
            this.updateBtn.TabIndex = 2;
            this.updateBtn.Text = "Сохранить изменение";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(840, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 46);
            this.button1.TabIndex = 3;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tsTB1
            // 
            this.tsTB1.Location = new System.Drawing.Point(107, 40);
            this.tsTB1.Name = "tsTB1";
            this.tsTB1.Size = new System.Drawing.Size(96, 20);
            this.tsTB1.TabIndex = 5;
            // 
            // tsTB2
            // 
            this.tsTB2.Location = new System.Drawing.Point(209, 40);
            this.tsTB2.Name = "tsTB2";
            this.tsTB2.Size = new System.Drawing.Size(109, 20);
            this.tsTB2.TabIndex = 6;
            // 
            // tsTB3
            // 
            this.tsTB3.Location = new System.Drawing.Point(324, 40);
            this.tsTB3.Name = "tsTB3";
            this.tsTB3.Size = new System.Drawing.Size(107, 20);
            this.tsTB3.TabIndex = 7;
            // 
            // tsTB4
            // 
            this.tsTB4.Location = new System.Drawing.Point(437, 40);
            this.tsTB4.Name = "tsTB4";
            this.tsTB4.Size = new System.Drawing.Size(104, 20);
            this.tsTB4.TabIndex = 8;
            // 
            // tsTB5
            // 
            this.tsTB5.Location = new System.Drawing.Point(547, 40);
            this.tsTB5.Name = "tsTB5";
            this.tsTB5.Size = new System.Drawing.Size(104, 20);
            this.tsTB5.TabIndex = 9;
            // 
            // tsTB6
            // 
            this.tsTB6.Location = new System.Drawing.Point(657, 40);
            this.tsTB6.Name = "tsTB6";
            this.tsTB6.Size = new System.Drawing.Size(106, 20);
            this.tsTB6.TabIndex = 10;
            // 
            // tsAddBox
            // 
            this.tsAddBox.Controls.Add(this.label14);
            this.tsAddBox.Controls.Add(this.label13);
            this.tsAddBox.Controls.Add(this.label12);
            this.tsAddBox.Controls.Add(this.label11);
            this.tsAddBox.Controls.Add(this.label10);
            this.tsAddBox.Controls.Add(this.label9);
            this.tsAddBox.Controls.Add(this.tsTB6);
            this.tsAddBox.Controls.Add(this.tsTB5);
            this.tsAddBox.Controls.Add(this.tsTB1);
            this.tsAddBox.Controls.Add(this.tsTB4);
            this.tsAddBox.Controls.Add(this.tsTB2);
            this.tsAddBox.Controls.Add(this.tsTB3);
            this.tsAddBox.Location = new System.Drawing.Point(12, 346);
            this.tsAddBox.Name = "tsAddBox";
            this.tsAddBox.Size = new System.Drawing.Size(776, 100);
            this.tsAddBox.TabIndex = 11;
            this.tsAddBox.TabStop = false;
            this.tsAddBox.Text = "Добавление TableSource";
            this.tsAddBox.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(683, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 13);
            this.label14.TabIndex = 20;
            this.label14.Text = "nValue";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(573, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "vTerritoryId";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(460, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "dtEndDate";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(348, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "dtStartDate";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(234, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "vPeriodType";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(130, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "nPokazatelId";
            // 
            // otAddBox
            // 
            this.otAddBox.Controls.Add(this.label6);
            this.otAddBox.Controls.Add(this.label5);
            this.otAddBox.Controls.Add(this.label4);
            this.otAddBox.Controls.Add(this.label3);
            this.otAddBox.Controls.Add(this.label2);
            this.otAddBox.Controls.Add(this.oTB5);
            this.otAddBox.Controls.Add(this.oTB1);
            this.otAddBox.Controls.Add(this.oTB4);
            this.otAddBox.Controls.Add(this.oTB2);
            this.otAddBox.Controls.Add(this.oTB3);
            this.otAddBox.Location = new System.Drawing.Point(12, 317);
            this.otAddBox.Name = "otAddBox";
            this.otAddBox.Size = new System.Drawing.Size(663, 100);
            this.otAddBox.TabIndex = 12;
            this.otAddBox.TabStop = false;
            this.otAddBox.Text = "Добавление OurTable";
            this.otAddBox.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(572, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "vProcent";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(451, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "nTerPodrazdel";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(341, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "nTerOtdelenie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(227, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "dtReportDate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "nCanonId";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // oTB5
            // 
            this.oTB5.Location = new System.Drawing.Point(547, 40);
            this.oTB5.Name = "oTB5";
            this.oTB5.Size = new System.Drawing.Size(104, 20);
            this.oTB5.TabIndex = 9;
            // 
            // oTB1
            // 
            this.oTB1.Location = new System.Drawing.Point(107, 40);
            this.oTB1.Name = "oTB1";
            this.oTB1.Size = new System.Drawing.Size(96, 20);
            this.oTB1.TabIndex = 5;
            // 
            // oTB4
            // 
            this.oTB4.Location = new System.Drawing.Point(437, 40);
            this.oTB4.Name = "oTB4";
            this.oTB4.Size = new System.Drawing.Size(104, 20);
            this.oTB4.TabIndex = 8;
            // 
            // oTB2
            // 
            this.oTB2.Location = new System.Drawing.Point(209, 40);
            this.oTB2.Name = "oTB2";
            this.oTB2.Size = new System.Drawing.Size(109, 20);
            this.oTB2.TabIndex = 6;
            // 
            // oTB3
            // 
            this.oTB3.Location = new System.Drawing.Point(324, 40);
            this.oTB3.Name = "oTB3";
            this.oTB3.Size = new System.Drawing.Size(107, 20);
            this.oTB3.TabIndex = 7;
            // 
            // usersAddBox
            // 
            this.usersAddBox.Controls.Add(this.label8);
            this.usersAddBox.Controls.Add(this.label7);
            this.usersAddBox.Controls.Add(this.uTB1);
            this.usersAddBox.Controls.Add(this.uTB2);
            this.usersAddBox.Location = new System.Drawing.Point(12, 306);
            this.usersAddBox.Name = "usersAddBox";
            this.usersAddBox.Size = new System.Drawing.Size(238, 100);
            this.usersAddBox.TabIndex = 13;
            this.usersAddBox.TabStop = false;
            this.usersAddBox.Text = "Добавление User";
            this.usersAddBox.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(129, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "User_password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "User_login";
            // 
            // uTB1
            // 
            this.uTB1.Location = new System.Drawing.Point(10, 40);
            this.uTB1.Name = "uTB1";
            this.uTB1.Size = new System.Drawing.Size(96, 20);
            this.uTB1.TabIndex = 5;
            // 
            // uTB2
            // 
            this.uTB2.Location = new System.Drawing.Point(112, 40);
            this.uTB2.Name = "uTB2";
            this.uTB2.Size = new System.Drawing.Size(109, 20);
            this.uTB2.TabIndex = 6;
            // 
            // delTB
            // 
            this.delTB.Location = new System.Drawing.Point(855, 259);
            this.delTB.Name = "delTB";
            this.delTB.Size = new System.Drawing.Size(63, 20);
            this.delTB.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(833, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Id";
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(924, 245);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(73, 46);
            this.delBtn.TabIndex = 16;
            this.delBtn.Text = "Удалить";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // DataTables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 477);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delTB);
            this.Controls.Add(this.otAddBox);
            this.Controls.Add(this.tsAddBox);
            this.Controls.Add(this.usersAddBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DataTables";
            this.Text = "DataTables";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DataTables_FormClosed);
            this.Load += new System.EventHandler(this.DataTables_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tsAddBox.ResumeLayout(false);
            this.tsAddBox.PerformLayout();
            this.otAddBox.ResumeLayout(false);
            this.otAddBox.PerformLayout();
            this.usersAddBox.ResumeLayout(false);
            this.usersAddBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton UsersRad;
        private System.Windows.Forms.RadioButton ourTableRad;
        private System.Windows.Forms.RadioButton tableSourceRad;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tsTB1;
        private System.Windows.Forms.TextBox tsTB2;
        private System.Windows.Forms.TextBox tsTB3;
        private System.Windows.Forms.TextBox tsTB4;
        private System.Windows.Forms.TextBox tsTB5;
        private System.Windows.Forms.TextBox tsTB6;
        private System.Windows.Forms.GroupBox tsAddBox;
        private System.Windows.Forms.GroupBox otAddBox;
        private System.Windows.Forms.GroupBox usersAddBox;
        private System.Windows.Forms.TextBox uTB1;
        private System.Windows.Forms.TextBox uTB2;
        private System.Windows.Forms.TextBox oTB5;
        private System.Windows.Forms.TextBox oTB1;
        private System.Windows.Forms.TextBox oTB4;
        private System.Windows.Forms.TextBox oTB2;
        private System.Windows.Forms.TextBox oTB3;
        private System.Windows.Forms.TextBox delTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}