namespace ZooparkForms
{
    partial class quarymenu
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
            this.comboBoxTables = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_opis = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bnt_refresh = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.textBox_Quary = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxTables
            // 
            this.comboBoxTables.FormattingEnabled = true;
            this.comboBoxTables.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboBoxTables.Location = new System.Drawing.Point(178, 442);
            this.comboBoxTables.Name = "comboBoxTables";
            this.comboBoxTables.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTables.TabIndex = 36;
            this.comboBoxTables.Text = "1";
            this.comboBoxTables.SelectedIndexChanged += new System.EventHandler(this.comboBoxTables_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 445);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(160, 13);
            this.label11.TabIndex = 37;
            this.label11.Text = "Выберите запрос или таблицу";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(559, 450);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Описание запроса :";
            // 
            // label_opis
            // 
            this.label_opis.AutoSize = true;
            this.label_opis.Location = new System.Drawing.Point(673, 450);
            this.label_opis.Name = "label_opis";
            this.label_opis.Size = new System.Drawing.Size(16, 13);
            this.label_opis.TabIndex = 39;
            this.label_opis.Text = "=)";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1357, 412);
            this.dataGridView1.TabIndex = 40;
            // 
            // bnt_refresh
            // 
            this.bnt_refresh.Location = new System.Drawing.Point(12, 528);
            this.bnt_refresh.Name = "bnt_refresh";
            this.bnt_refresh.Size = new System.Drawing.Size(118, 53);
            this.bnt_refresh.TabIndex = 41;
            this.bnt_refresh.Text = "Обнавить данные";
            this.bnt_refresh.UseVisualStyleBackColor = true;
            this.bnt_refresh.Click += new System.EventHandler(this.bnt_refresh_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 481);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 43;
            this.label10.Text = "Поиск";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(70, 478);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(121, 20);
            this.textBoxSearch.TabIndex = 42;
            // 
            // textBox_Quary
            // 
            this.textBox_Quary.Location = new System.Drawing.Point(735, 578);
            this.textBox_Quary.Name = "textBox_Quary";
            this.textBox_Quary.Size = new System.Drawing.Size(190, 20);
            this.textBox_Quary.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(559, 581);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Введите данные для запроса :";
            // 
            // quarymenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1381, 672);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Quary);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.bnt_refresh);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label_opis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxTables);
            this.Controls.Add(this.label11);
            this.Name = "quarymenu";
            this.Text = "quarymenu";
            this.Load += new System.EventHandler(this.quarymenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTables;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_opis;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bnt_refresh;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.TextBox textBox_Quary;
        private System.Windows.Forms.Label label2;
    }
}