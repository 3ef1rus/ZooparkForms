namespace ZooparkForms
{
    partial class AdminMenuForm
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_chang = new System.Windows.Forms.Button();
            this.btn_rem = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.textBox_FIO = new System.Windows.Forms.TextBox();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.textBox_Exp = new System.Windows.Forms.TextBox();
            this.textBox_Age = new System.Windows.Forms.TextBox();
            this.textBox_Sex = new System.Windows.Forms.TextBox();
            this.textBox_Salarity = new System.Windows.Forms.TextBox();
            this.textBox_IDjobs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bnt_refresh = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxTables = new System.Windows.Forms.ComboBox();
            this.zooparkDataSet = new ZooparkForms.zooparkDataSet();
            this.zooparkDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zooparkDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zooparkDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1299, 422);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(300, 440);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(118, 53);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "Добавить";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_chang
            // 
            this.btn_chang.Location = new System.Drawing.Point(300, 563);
            this.btn_chang.Name = "btn_chang";
            this.btn_chang.Size = new System.Drawing.Size(118, 53);
            this.btn_chang.TabIndex = 2;
            this.btn_chang.Text = "Изменить";
            this.btn_chang.UseVisualStyleBackColor = true;
            this.btn_chang.Click += new System.EventHandler(this.btn_chang_Click);
            // 
            // btn_rem
            // 
            this.btn_rem.Location = new System.Drawing.Point(300, 501);
            this.btn_rem.Name = "btn_rem";
            this.btn_rem.Size = new System.Drawing.Size(118, 53);
            this.btn_rem.TabIndex = 3;
            this.btn_rem.Text = "Удалить";
            this.btn_rem.UseVisualStyleBackColor = true;
            this.btn_rem.Click += new System.EventHandler(this.btn_rem_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(1190, 446);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(121, 20);
            this.textBoxSearch.TabIndex = 4;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // textBox_FIO
            // 
            this.textBox_FIO.Location = new System.Drawing.Point(518, 469);
            this.textBox_FIO.Name = "textBox_FIO";
            this.textBox_FIO.Size = new System.Drawing.Size(382, 20);
            this.textBox_FIO.TabIndex = 5;
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(518, 443);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(382, 20);
            this.textBox_ID.TabIndex = 6;
            // 
            // textBox_Exp
            // 
            this.textBox_Exp.Location = new System.Drawing.Point(518, 573);
            this.textBox_Exp.Name = "textBox_Exp";
            this.textBox_Exp.Size = new System.Drawing.Size(382, 20);
            this.textBox_Exp.TabIndex = 7;
            // 
            // textBox_Age
            // 
            this.textBox_Age.Location = new System.Drawing.Point(518, 547);
            this.textBox_Age.Name = "textBox_Age";
            this.textBox_Age.Size = new System.Drawing.Size(382, 20);
            this.textBox_Age.TabIndex = 8;
            // 
            // textBox_Sex
            // 
            this.textBox_Sex.Location = new System.Drawing.Point(518, 521);
            this.textBox_Sex.Name = "textBox_Sex";
            this.textBox_Sex.Size = new System.Drawing.Size(382, 20);
            this.textBox_Sex.TabIndex = 9;
            // 
            // textBox_Salarity
            // 
            this.textBox_Salarity.Location = new System.Drawing.Point(518, 495);
            this.textBox_Salarity.Name = "textBox_Salarity";
            this.textBox_Salarity.Size = new System.Drawing.Size(382, 20);
            this.textBox_Salarity.TabIndex = 10;
            // 
            // textBox_IDjobs
            // 
            this.textBox_IDjobs.Location = new System.Drawing.Point(518, 599);
            this.textBox_IDjobs.Name = "textBox_IDjobs";
            this.textBox_IDjobs.Size = new System.Drawing.Size(382, 20);
            this.textBox_IDjobs.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(424, 446);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(424, 469);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "ФИО";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(424, 495);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Зарплата";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(424, 521);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Пол";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(424, 547);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Возраст";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(424, 573);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Опыт работы";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(424, 603);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "ID должности";
            // 
            // bnt_refresh
            // 
            this.bnt_refresh.Location = new System.Drawing.Point(12, 452);
            this.bnt_refresh.Name = "bnt_refresh";
            this.bnt_refresh.Size = new System.Drawing.Size(118, 53);
            this.bnt_refresh.TabIndex = 19;
            this.bnt_refresh.Text = "Обнавить данные";
            this.bnt_refresh.UseVisualStyleBackColor = true;
            this.bnt_refresh.Click += new System.EventHandler(this.bnt_refresh_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(422, 654);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "//";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(518, 651);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(382, 20);
            this.textBox1.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(424, 628);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(12, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "/";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(518, 625);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(382, 20);
            this.textBox2.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1132, 449);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Поиск";
            // 
            // comboBoxTables
            // 
            this.comboBoxTables.FormattingEnabled = true;
            this.comboBoxTables.Items.AddRange(new object[] {
            "ZooparkForTrade",
            "Suppliers",
            "Vaccinations",
            "VaccinationsList",
            "Disease",
            "DiseaseList",
            "Employee",
            "Feeds",
            "FoodTypes",
            "Types",
            "InteractionFamilyList",
            "Cells",
            "Exchanges",
            "MedicalCard",
            "PassportAnimal",
            "Responsibility",
            "ResponsibilityList",
            "Animal",
            "ListAnimalTypeInCell",
            "Mainzoopark",
            "Access",
            "EmployeeHistory",
            "Users",
            "Admins"});
            this.comboBoxTables.Location = new System.Drawing.Point(1190, 472);
            this.comboBoxTables.Name = "comboBoxTables";
            this.comboBoxTables.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTables.TabIndex = 25;
            this.comboBoxTables.Text = "Employee";
            this.comboBoxTables.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // zooparkDataSet
            // 
            this.zooparkDataSet.DataSetName = "zooparkDataSet";
            this.zooparkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zooparkDataSetBindingSource
            // 
            this.zooparkDataSetBindingSource.DataSource = this.zooparkDataSet;
            this.zooparkDataSetBindingSource.Position = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(986, 480);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(198, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Выберите с какой таблицей работать";
            // 
            // AdminMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 680);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboBoxTables);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bnt_refresh);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_IDjobs);
            this.Controls.Add(this.textBox_Salarity);
            this.Controls.Add(this.textBox_Sex);
            this.Controls.Add(this.textBox_Age);
            this.Controls.Add(this.textBox_Exp);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.textBox_FIO);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.btn_rem);
            this.Controls.Add(this.btn_chang);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AdminMenuForm";
            this.Text = "AdminMenuForm";
            this.Load += new System.EventHandler(this.AdminMenuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zooparkDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zooparkDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_chang;
        private System.Windows.Forms.Button btn_rem;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.TextBox textBox_FIO;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.TextBox textBox_Exp;
        private System.Windows.Forms.TextBox textBox_Age;
        private System.Windows.Forms.TextBox textBox_Sex;
        private System.Windows.Forms.TextBox textBox_Salarity;
        private System.Windows.Forms.TextBox textBox_IDjobs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bnt_refresh;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxTables;
        private zooparkDataSet zooparkDataSet;
        private System.Windows.Forms.BindingSource zooparkDataSetBindingSource;
        private System.Windows.Forms.Label label11;
    }
}