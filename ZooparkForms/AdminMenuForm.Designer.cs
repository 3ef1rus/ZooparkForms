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
            this.bnt_refresh = new System.Windows.Forms.Button();
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
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.ClientSize = new System.Drawing.Size(1328, 680);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboBoxTables);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.bnt_refresh);
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
        private System.Windows.Forms.Button bnt_refresh;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxTables;
        private zooparkDataSet zooparkDataSet;
        private System.Windows.Forms.BindingSource zooparkDataSetBindingSource;
        private System.Windows.Forms.Label label11;
    }
}