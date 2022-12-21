
namespace AvtoService.Employee
{
    partial class Leader
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
            this.label6 = new System.Windows.Forms.Label();
            this.btnShowSotrs = new System.Windows.Forms.Button();
            this.btnDelSotr = new System.Windows.Forms.Button();
            this.btnAddSotr = new System.Windows.Forms.Button();
            this.dgvLeaderTable = new System.Windows.Forms.DataGridView();
            this.btnUpdateSotr = new System.Windows.Forms.Button();
            this.btnShowSostavZakazov = new System.Windows.Forms.Button();
            this.searchText1 = new System.Windows.Forms.TextBox();
            this.searchNum1 = new System.Windows.Forms.NumericUpDown();
            this.searchText2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.searchNum2 = new System.Windows.Forms.NumericUpDown();
            this.button8 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaderTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchNum1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchNum2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(17, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 22);
            this.label6.TabIndex = 15;
            this.label6.Text = "Руководитель:";
            // 
            // btnShowSotrs
            // 
            this.btnShowSotrs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShowSotrs.Location = new System.Drawing.Point(367, 44);
            this.btnShowSotrs.Name = "btnShowSotrs";
            this.btnShowSotrs.Size = new System.Drawing.Size(114, 64);
            this.btnShowSotrs.TabIndex = 14;
            this.btnShowSotrs.Text = "Вывести список всех сотрудников";
            this.btnShowSotrs.UseVisualStyleBackColor = true;
            this.btnShowSotrs.Click += new System.EventHandler(this.btnShowSotrs_Click);
            // 
            // btnDelSotr
            // 
            this.btnDelSotr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelSotr.Location = new System.Drawing.Point(367, 123);
            this.btnDelSotr.Name = "btnDelSotr";
            this.btnDelSotr.Size = new System.Drawing.Size(114, 68);
            this.btnDelSotr.TabIndex = 13;
            this.btnDelSotr.Text = "Уволить сотрудника";
            this.btnDelSotr.UseVisualStyleBackColor = true;
            this.btnDelSotr.Visible = false;
            this.btnDelSotr.Click += new System.EventHandler(this.btnDelSotr_Click);
            // 
            // btnAddSotr
            // 
            this.btnAddSotr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddSotr.Location = new System.Drawing.Point(517, 44);
            this.btnAddSotr.Name = "btnAddSotr";
            this.btnAddSotr.Size = new System.Drawing.Size(114, 64);
            this.btnAddSotr.TabIndex = 11;
            this.btnAddSotr.Text = "Добавить нового сотрудника";
            this.btnAddSotr.UseVisualStyleBackColor = true;
            this.btnAddSotr.Click += new System.EventHandler(this.btnAddSotr_Click);
            // 
            // dgvLeaderTable
            // 
            this.dgvLeaderTable.BackgroundColor = System.Drawing.Color.White;
            this.dgvLeaderTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeaderTable.Location = new System.Drawing.Point(12, 234);
            this.dgvLeaderTable.Name = "dgvLeaderTable";
            this.dgvLeaderTable.Size = new System.Drawing.Size(649, 190);
            this.dgvLeaderTable.TabIndex = 16;
            this.dgvLeaderTable.Visible = false;
            // 
            // btnUpdateSotr
            // 
            this.btnUpdateSotr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdateSotr.Location = new System.Drawing.Point(517, 123);
            this.btnUpdateSotr.Name = "btnUpdateSotr";
            this.btnUpdateSotr.Size = new System.Drawing.Size(114, 68);
            this.btnUpdateSotr.TabIndex = 17;
            this.btnUpdateSotr.Text = "Сохранить изменения";
            this.btnUpdateSotr.UseVisualStyleBackColor = true;
            this.btnUpdateSotr.Visible = false;
            this.btnUpdateSotr.Click += new System.EventHandler(this.btnUpdateSotr_Click);
            // 
            // btnShowSostavZakazov
            // 
            this.btnShowSostavZakazov.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShowSostavZakazov.Location = new System.Drawing.Point(12, 44);
            this.btnShowSostavZakazov.Name = "btnShowSostavZakazov";
            this.btnShowSostavZakazov.Size = new System.Drawing.Size(260, 64);
            this.btnShowSostavZakazov.TabIndex = 18;
            this.btnShowSostavZakazov.Text = "Посмотреть состав заказов на запчасти и заказы";
            this.btnShowSostavZakazov.UseVisualStyleBackColor = true;
            this.btnShowSostavZakazov.Click += new System.EventHandler(this.btnShowSostavZakazov_Click);
            // 
            // searchText1
            // 
            this.searchText1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchText1.Location = new System.Drawing.Point(152, 597);
            this.searchText1.Name = "searchText1";
            this.searchText1.Size = new System.Drawing.Size(164, 30);
            this.searchText1.TabIndex = 20;
            this.searchText1.TextChanged += new System.EventHandler(this.FIO_Text_TextChanged);
            // 
            // searchNum1
            // 
            this.searchNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchNum1.Location = new System.Drawing.Point(38, 597);
            this.searchNum1.Maximum = new decimal(new int[] {
            1200,
            0,
            0,
            0});
            this.searchNum1.Minimum = new decimal(new int[] {
            1120,
            0,
            0,
            0});
            this.searchNum1.Name = "searchNum1";
            this.searchNum1.Size = new System.Drawing.Size(74, 30);
            this.searchNum1.TabIndex = 21;
            this.searchNum1.Value = new decimal(new int[] {
            1120,
            0,
            0,
            0});
            this.searchNum1.Visible = false;
            this.searchNum1.ValueChanged += new System.EventHandler(this.searchNum1_ValueChanged);
            // 
            // searchText2
            // 
            this.searchText2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchText2.Location = new System.Drawing.Point(347, 597);
            this.searchText2.Name = "searchText2";
            this.searchText2.Size = new System.Drawing.Size(164, 30);
            this.searchText2.TabIndex = 22;
            this.searchText2.TextChanged += new System.EventHandler(this.PhoneNumText_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(17, 630);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Id Сотрудника";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(201, 630);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "ФИО";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(358, 630);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Номер телефона";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(559, 630);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Стаж";
            // 
            // searchNum2
            // 
            this.searchNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchNum2.Location = new System.Drawing.Point(537, 597);
            this.searchNum2.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.searchNum2.Name = "searchNum2";
            this.searchNum2.Size = new System.Drawing.Size(94, 30);
            this.searchNum2.TabIndex = 27;
            this.searchNum2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.searchNum2.ValueChanged += new System.EventHandler(this.StageNum_ValueChanged);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.Location = new System.Drawing.Point(12, 123);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(260, 68);
            this.button8.TabIndex = 28;
            this.button8.Text = "Просмотр запчастей на складе";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(175, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 22);
            this.label7.TabIndex = 30;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 459);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(649, 191);
            this.dataGridView1.TabIndex = 31;
            this.dataGridView1.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(276, 24);
            this.label5.TabIndex = 32;
            this.label5.Text = "Заказы на закупку запчастей:";
            this.label5.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(12, 427);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 24);
            this.label8.TabIndex = 33;
            this.label8.Text = "Состав на закупку:";
            this.label8.Visible = false;
            // 
            // Leader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 662);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.searchNum2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchText2);
            this.Controls.Add(this.searchNum1);
            this.Controls.Add(this.searchText1);
            this.Controls.Add(this.btnShowSostavZakazov);
            this.Controls.Add(this.btnUpdateSotr);
            this.Controls.Add(this.dgvLeaderTable);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnShowSotrs);
            this.Controls.Add(this.btnDelSotr);
            this.Controls.Add(this.btnAddSotr);
            this.Name = "Leader";
            this.Text = "Руководство";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaderTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchNum1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchNum2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnShowSotrs;
        private System.Windows.Forms.Button btnDelSotr;
        private System.Windows.Forms.Button btnAddSotr;
        private System.Windows.Forms.DataGridView dgvLeaderTable;
        private System.Windows.Forms.Button btnUpdateSotr;
        private System.Windows.Forms.Button btnShowSostavZakazov;
        private System.Windows.Forms.TextBox searchText1;
        private System.Windows.Forms.NumericUpDown searchNum1;
        private System.Windows.Forms.TextBox searchText2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown searchNum2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
    }
}