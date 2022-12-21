
namespace AvtoService
{
    partial class ClientForm
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
            this.buttonClientPersonalArea = new System.Windows.Forms.Button();
            this.buttonClientCheckOrder = new System.Windows.Forms.Button();
            this.buttonClientCheckZapchasti = new System.Windows.Forms.Button();
            this.labelClientPhone = new System.Windows.Forms.Label();
            this.labelClientAboutPhone = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelFio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClientPersonalArea
            // 
            this.buttonClientPersonalArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClientPersonalArea.Location = new System.Drawing.Point(23, 35);
            this.buttonClientPersonalArea.Name = "buttonClientPersonalArea";
            this.buttonClientPersonalArea.Size = new System.Drawing.Size(216, 63);
            this.buttonClientPersonalArea.TabIndex = 0;
            this.buttonClientPersonalArea.Text = "Личный кабинет";
            this.buttonClientPersonalArea.UseVisualStyleBackColor = true;
            this.buttonClientPersonalArea.Click += new System.EventHandler(this.buttonClientPersonalArea_Click);
            // 
            // buttonClientCheckOrder
            // 
            this.buttonClientCheckOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClientCheckOrder.Location = new System.Drawing.Point(279, 35);
            this.buttonClientCheckOrder.Name = "buttonClientCheckOrder";
            this.buttonClientCheckOrder.Size = new System.Drawing.Size(216, 63);
            this.buttonClientCheckOrder.TabIndex = 1;
            this.buttonClientCheckOrder.Text = "Посмотреть свои заказы";
            this.buttonClientCheckOrder.UseVisualStyleBackColor = true;
            this.buttonClientCheckOrder.Click += new System.EventHandler(this.buttonClientCheckOrder_Click);
            // 
            // buttonClientCheckZapchasti
            // 
            this.buttonClientCheckZapchasti.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClientCheckZapchasti.Location = new System.Drawing.Point(533, 35);
            this.buttonClientCheckZapchasti.Name = "buttonClientCheckZapchasti";
            this.buttonClientCheckZapchasti.Size = new System.Drawing.Size(216, 63);
            this.buttonClientCheckZapchasti.TabIndex = 2;
            this.buttonClientCheckZapchasti.Text = "Посмотреть доступные запчасти";
            this.buttonClientCheckZapchasti.UseVisualStyleBackColor = true;
            this.buttonClientCheckZapchasti.Click += new System.EventHandler(this.buttonClientCheckZapchasti_Click);
            // 
            // labelClientPhone
            // 
            this.labelClientPhone.AutoSize = true;
            this.labelClientPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelClientPhone.Location = new System.Drawing.Point(969, 35);
            this.labelClientPhone.Name = "labelClientPhone";
            this.labelClientPhone.Size = new System.Drawing.Size(155, 22);
            this.labelClientPhone.TabIndex = 4;
            this.labelClientPhone.Text = "+7(999)919-91-91";
            // 
            // labelClientAboutPhone
            // 
            this.labelClientAboutPhone.AutoSize = true;
            this.labelClientAboutPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelClientAboutPhone.Location = new System.Drawing.Point(803, 35);
            this.labelClientAboutPhone.Name = "labelClientAboutPhone";
            this.labelClientAboutPhone.Size = new System.Drawing.Size(164, 20);
            this.labelClientAboutPhone.TabIndex = 5;
            this.labelClientAboutPhone.Text = "Телефон для связи:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridView1.Location = new System.Drawing.Point(12, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1112, 135);
            this.dataGridView1.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(104, 263);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(279, 29);
            this.textBox1.TabIndex = 7;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(149, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Поиск по названию";
            this.label1.Visible = false;
            // 
            // labelFio
            // 
            this.labelFio.AutoSize = true;
            this.labelFio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFio.Location = new System.Drawing.Point(19, 10);
            this.labelFio.Name = "labelFio";
            this.labelFio.Size = new System.Drawing.Size(0, 22);
            this.labelFio.TabIndex = 9;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 337);
            this.Controls.Add(this.labelFio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelClientAboutPhone);
            this.Controls.Add(this.labelClientPhone);
            this.Controls.Add(this.buttonClientCheckZapchasti);
            this.Controls.Add(this.buttonClientCheckOrder);
            this.Controls.Add(this.buttonClientPersonalArea);
            this.Name = "ClientForm";
            this.Text = "Клиент";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClientPersonalArea;
        private System.Windows.Forms.Button buttonClientCheckOrder;
        private System.Windows.Forms.Button buttonClientCheckZapchasti;
        private System.Windows.Forms.Label labelClientPhone;
        private System.Windows.Forms.Label labelClientAboutPhone;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelFio;
    }
}