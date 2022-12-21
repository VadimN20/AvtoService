
namespace AvtoService.Employee
{
    partial class LeaderShowSklad
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
            this.searchNum2 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.searchNum1 = new System.Windows.Forms.NumericUpDown();
            this.searchText1 = new System.Windows.Forms.TextBox();
            this.dgvSkladTable = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.searchNum2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchNum1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkladTable)).BeginInit();
            this.SuspendLayout();
            // 
            // searchNum2
            // 
            this.searchNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchNum2.Location = new System.Drawing.Point(182, 467);
            this.searchNum2.Name = "searchNum2";
            this.searchNum2.Size = new System.Drawing.Size(84, 30);
            this.searchNum2.TabIndex = 36;
            this.searchNum2.ValueChanged += new System.EventHandler(this.searchNum2_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(178, 500);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = "В наличии";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(480, 500);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "Единица измерения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(156, 433);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Название запчасти";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(530, 434);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Цена";
            // 
            // searchNum1
            // 
            this.searchNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchNum1.Location = new System.Drawing.Point(483, 401);
            this.searchNum1.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.searchNum1.Name = "searchNum1";
            this.searchNum1.Size = new System.Drawing.Size(153, 30);
            this.searchNum1.TabIndex = 30;
            this.searchNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchNum1.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.searchNum1.ValueChanged += new System.EventHandler(this.searchNum1_ValueChanged);
            // 
            // searchText1
            // 
            this.searchText1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchText1.Location = new System.Drawing.Point(71, 400);
            this.searchText1.Name = "searchText1";
            this.searchText1.Size = new System.Drawing.Size(325, 30);
            this.searchText1.TabIndex = 29;
            this.searchText1.TextChanged += new System.EventHandler(this.searchText1_TextChanged);
            // 
            // dgvSkladTable
            // 
            this.dgvSkladTable.BackgroundColor = System.Drawing.Color.White;
            this.dgvSkladTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSkladTable.Location = new System.Drawing.Point(10, 40);
            this.dgvSkladTable.Name = "dgvSkladTable";
            this.dgvSkladTable.Size = new System.Drawing.Size(677, 340);
            this.dgvSkladTable.TabIndex = 28;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "шт",
            "л"});
            this.comboBox1.Location = new System.Drawing.Point(499, 465);
            this.comboBox1.MaxLength = 2;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 32);
            this.comboBox1.TabIndex = 37;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(693, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 59);
            this.button1.TabIndex = 38;
            this.button1.Text = "Добавить запчасть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(693, 136);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 59);
            this.button2.TabIndex = 39;
            this.button2.Text = "Удалить запчасть";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(693, 224);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 59);
            this.button3.TabIndex = 40;
            this.button3.Text = "Сохранить изменения";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(693, 321);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(123, 59);
            this.button4.TabIndex = 41;
            this.button4.Text = "Обновить таблицу";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(723, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 42;
            // 
            // LeaderShowSklad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 566);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.searchNum2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchNum1);
            this.Controls.Add(this.searchText1);
            this.Controls.Add(this.dgvSkladTable);
            this.Name = "LeaderShowSklad";
            this.Text = "Склад";
            ((System.ComponentModel.ISupportInitialize)(this.searchNum2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchNum1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkladTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown searchNum2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown searchNum1;
        private System.Windows.Forms.TextBox searchText1;
        private System.Windows.Forms.DataGridView dgvSkladTable;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label5;
    }
}