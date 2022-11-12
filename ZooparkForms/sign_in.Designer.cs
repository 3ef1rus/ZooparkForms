namespace ZooparkForms
{
    partial class sign_in
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
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPasswordR = new System.Windows.Forms.TextBox();
            this.textBoxLoginR = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Регистрация";
            // 
            // textBoxPasswordR
            // 
            this.textBoxPasswordR.Location = new System.Drawing.Point(289, 203);
            this.textBoxPasswordR.Name = "textBoxPasswordR";
            this.textBoxPasswordR.Size = new System.Drawing.Size(151, 20);
            this.textBoxPasswordR.TabIndex = 13;
            // 
            // textBoxLoginR
            // 
            this.textBoxLoginR.Location = new System.Drawing.Point(289, 148);
            this.textBoxLoginR.Name = "textBoxLoginR";
            this.textBoxLoginR.Size = new System.Drawing.Size(151, 20);
            this.textBoxLoginR.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Логин";
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(301, 258);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(117, 35);
            this.btnReg.TabIndex = 8;
            this.btnReg.Text = "Создать аккаунт";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // sign_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 431);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPasswordR);
            this.Controls.Add(this.textBoxLoginR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReg);
            this.Name = "sign_in";
            this.Text = "sign_in";
            this.Load += new System.EventHandler(this.sign_in_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPasswordR;
        private System.Windows.Forms.TextBox textBoxLoginR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReg;
    }
}