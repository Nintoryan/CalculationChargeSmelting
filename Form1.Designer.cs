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
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.LoadMaterials = new System.Windows.Forms.Button();
            this.addMaterial = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RemoveMaterial = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // shichtType
            // 
            this.shichtType.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.shichtType.FormattingEnabled = true;
            this.shichtType.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.shichtType.Items.AddRange(new object[] {
            "Индукционная высокочастотная печь"});
            this.shichtType.Location = new System.Drawing.Point(12, 29);
            this.shichtType.Name = "shichtType";
            this.shichtType.Size = new System.Drawing.Size(222, 24);
            this.shichtType.TabIndex = 0;
            this.shichtType.SelectedIndexChanged += new System.EventHandler(this.shichtType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Плавильный агрегат";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 456);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Создать сплав";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 366);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(222, 24);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // LoadMaterials
            // 
            this.LoadMaterials.Location = new System.Drawing.Point(12, 102);
            this.LoadMaterials.Name = "LoadMaterials";
            this.LoadMaterials.Size = new System.Drawing.Size(222, 23);
            this.LoadMaterials.TabIndex = 7;
            this.LoadMaterials.Text = "Обновить списоки сплавов";
            this.LoadMaterials.UseVisualStyleBackColor = true;
            this.LoadMaterials.Click += new System.EventHandler(this.LoadMaterials_Click);
            // 
            // addMaterial
            // 
            this.addMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addMaterial.Location = new System.Drawing.Point(12, 396);
            this.addMaterial.Name = "addMaterial";
            this.addMaterial.Size = new System.Drawing.Size(222, 24);
            this.addMaterial.TabIndex = 8;
            this.addMaterial.Text = "Добавить сплав";
            this.addMaterial.UseVisualStyleBackColor = true;
            this.addMaterial.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Location = new System.Drawing.Point(240, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 473);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Список шихтовых материалов";
            // 
            // RemoveMaterial
            // 
            this.RemoveMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemoveMaterial.Location = new System.Drawing.Point(12, 426);
            this.RemoveMaterial.Name = "RemoveMaterial";
            this.RemoveMaterial.Size = new System.Drawing.Size(222, 24);
            this.RemoveMaterial.TabIndex = 10;
            this.RemoveMaterial.Text = "Убрать спалав";
            this.RemoveMaterial.UseVisualStyleBackColor = true;
            this.RemoveMaterial.Click += new System.EventHandler(this.RemoveMaterial_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.richTextBox1.Location = new System.Drawing.Point(6, 21);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(415, 446);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(12, 189);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(222, 24);
            this.comboBox2.TabIndex = 11;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Целевой сплав";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(12, 219);
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
            this.label3.Location = new System.Drawing.Point(214, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "кг";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richTextBox2);
            this.groupBox2.Location = new System.Drawing.Point(673, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(389, 520);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Результат расчёта шихты";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.richTextBox2.Location = new System.Drawing.Point(6, 21);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(377, 493);
            this.richTextBox2.TabIndex = 11;
            this.richTextBox2.Text = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 491);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(655, 41);
            this.button2.TabIndex = 15;
            this.button2.Text = "Произвести расчёт шихты";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Сплав шихтового материала";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 544);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.RemoveMaterial);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.addMaterial);
            this.Controls.Add(this.LoadMaterials);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shichtType);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Расчет шихты при выплавке вторичных сплавов алюминия";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox shichtType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button LoadMaterials;
        private System.Windows.Forms.Button addMaterial;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button RemoveMaterial;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
    }
}

