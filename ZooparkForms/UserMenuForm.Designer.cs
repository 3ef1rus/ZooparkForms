namespace ZooparkForms
{
    partial class UserMenuForm
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
            this.components = new System.ComponentModel.Container();
            this.comboBoxTables = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.bnt_refresh = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.zooparkDataSet = new ZooparkForms.zooparkDataSet();
            this.zooparkDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.btn_quary_menu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zooparkDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zooparkDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxTables
            // 
            this.comboBoxTables.FormattingEnabled = true;
            this.comboBoxTables.Items.AddRange(new object[] {
            "ZooparkForTrade",
            "Suppliers",
            "Vaccinations",
            "Disease",
            "Employee",
            "Feeds",
            "FoodTypes",
            "Types",
            "Cells",
            "Exchanges",
            "MedicalCard",
            "PassportAnimal",
            "Animal",
            "Mainzoopark"});
            this.comboBoxTables.Location = new System.Drawing.Point(115, 525);
            this.comboBoxTables.Name = "comboBoxTables";
            this.comboBoxTables.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTables.TabIndex = 34;
            this.comboBoxTables.Text = "Employee";
            this.comboBoxTables.SelectedIndexChanged += new System.EventHandler(this.comboBoxTables_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(153, 472);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "Поиск";
            // 
            // bnt_refresh
            // 
            this.bnt_refresh.Location = new System.Drawing.Point(12, 452);
            this.bnt_refresh.Name = "bnt_refresh";
            this.bnt_refresh.Size = new System.Drawing.Size(118, 53);
            this.bnt_refresh.TabIndex = 32;
            this.bnt_refresh.Text = "Обнавить данные";
            this.bnt_refresh.UseVisualStyleBackColor = true;
            this.bnt_refresh.Click += new System.EventHandler(this.bnt_refresh_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(211, 469);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(121, 20);
            this.textBoxSearch.TabIndex = 31;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1299, 412);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.label11.Location = new System.Drawing.Point(9, 528);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "Выберите таблицу";
            // 
            // btn_quary_menu
            // 
            this.btn_quary_menu.Location = new System.Drawing.Point(1167, 525);
            this.btn_quary_menu.Name = "btn_quary_menu";
            this.btn_quary_menu.Size = new System.Drawing.Size(144, 44);
            this.btn_quary_menu.TabIndex = 36;
            this.btn_quary_menu.Text = "Меню запросов";
            this.btn_quary_menu.UseVisualStyleBackColor = true;
            this.btn_quary_menu.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 671);
            this.Controls.Add(this.btn_quary_menu);
            this.Controls.Add(this.comboBoxTables);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.bnt_refresh);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label11);
            this.Name = "UserMenuForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.UserMenuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zooparkDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zooparkDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTables;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button bnt_refresh;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private zooparkDataSet zooparkDataSet;
        private System.Windows.Forms.BindingSource zooparkDataSetBindingSource;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_quary_menu;
    }
}

