namespace CalculationChargeSmelting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.shichtType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Export = new System.Windows.Forms.Button();
            this.EditUgar = new System.Windows.Forms.Button();
            this.Calculate = new System.Windows.Forms.Button();
            this.Import = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.AddMaterial = new System.Windows.Forms.Button();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.storage = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // shichtType
            // 
            this.shichtType.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.shichtType.FormattingEnabled = true;
            this.shichtType.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.shichtType.Items.AddRange(new object[] {
            "SN-B01"});
            this.shichtType.Location = new System.Drawing.Point(12, 29);
            this.shichtType.Name = "shichtType";
            this.shichtType.Size = new System.Drawing.Size(222, 24);
            this.shichtType.TabIndex = 0;
            this.shichtType.Text = "SN-B01";
            this.shichtType.SelectedIndexChanged += new System.EventHandler(this.shichtType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Плавильный агрегат";
            // 
            // Export
            // 
            this.Export.Location = new System.Drawing.Point(12, 485);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(222, 41);
            this.Export.TabIndex = 5;
            this.Export.Text = "Экспорт результата";
            this.Export.UseVisualStyleBackColor = true;
            // 
            // EditUgar
            // 
            this.EditUgar.Location = new System.Drawing.Point(12, 102);
            this.EditUgar.Name = "EditUgar";
            this.EditUgar.Size = new System.Drawing.Size(222, 23);
            this.EditUgar.TabIndex = 7;
            this.EditUgar.Text = "Редактор угара";
            this.EditUgar.UseVisualStyleBackColor = true;
            this.EditUgar.Click += new System.EventHandler(this.LoadMaterials_Click);
            // 
            // Calculate
            // 
            this.Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Calculate.Location = new System.Drawing.Point(12, 388);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(222, 46);
            this.Calculate.TabIndex = 8;
            this.Calculate.Text = "Произвести расчёт";
            this.Calculate.UseVisualStyleBackColor = true;
            // 
            // Import
            // 
            this.Import.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Import.Location = new System.Drawing.Point(12, 440);
            this.Import.Name = "Import";
            this.Import.Size = new System.Drawing.Size(222, 39);
            this.Import.TabIndex = 10;
            this.Import.Text = "Импорт склада";
            this.Import.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "АМ5",
            "АК6М2",
            "АК8"});
            this.comboBox2.Location = new System.Drawing.Point(12, 189);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(222, 24);
            this.comboBox2.TabIndex = 11;
            this.comboBox2.Text = "АМ5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Целевой сплав";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(12, 74);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(196, 22);
            this.numericUpDown1.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "кг";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.richTextBox2);
            this.groupBox2.Location = new System.Drawing.Point(804, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(258, 520);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Результат расчёта шихты";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(161, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 16);
            this.label10.TabIndex = 30;
            this.label10.Text = "Масса, кг";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 16);
            this.label9.TabIndex = 30;
            this.label9.Text = "Материал";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.richTextBox2.Location = new System.Drawing.Point(6, 39);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(246, 475);
            this.richTextBox2.TabIndex = 11;
            this.richTextBox2.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Макс. материалов";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Объём печи";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(12, 235);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(222, 22);
            this.numericUpDown2.TabIndex = 18;
            this.numericUpDown2.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(285, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Материал";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(418, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Цена, руб/кг";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(543, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "Масса, кг";
            // 
            // AddMaterial
            // 
            this.AddMaterial.Location = new System.Drawing.Point(240, 503);
            this.AddMaterial.Name = "AddMaterial";
            this.AddMaterial.Size = new System.Drawing.Size(494, 23);
            this.AddMaterial.TabIndex = 25;
            this.AddMaterial.Text = "+";
            this.AddMaterial.UseVisualStyleBackColor = true;
            this.AddMaterial.Click += new System.EventHandler(this.AddMaterial_Click);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(713, 28);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(21, 469);
            this.vScrollBar1.TabIndex = 28;
            // 
            // storage
            // 
            this.storage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.storage.Location = new System.Drawing.Point(240, 28);
            this.storage.Name = "storage";
            this.storage.Size = new System.Drawing.Size(470, 469);
            this.storage.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 544);
            this.Controls.Add(this.storage);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.AddMaterial);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.Import);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.EditUgar);
            this.Controls.Add(this.Export);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shichtType);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Расчет шихты при выплавке вторичных сплавов алюминия";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox shichtType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Export;
        private System.Windows.Forms.Button EditUgar;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Button Import;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AddMaterial;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.FlowLayoutPanel storage;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}

