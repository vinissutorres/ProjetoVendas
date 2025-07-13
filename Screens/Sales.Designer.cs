namespace ProjetoVendas.Screens
{
    partial class Sales
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textSalesDate = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textSalesName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textSalesCPF = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonSalesRemove = new System.Windows.Forms.Button();
            this.buttonSalesCreate = new System.Windows.Forms.Button();
            this.textSalesQuantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textSalesPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textSalesDescription = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textSalesID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridSalesProducts = new System.Windows.Forms.DataGridView();
            this.textSalesTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonPayment = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSalesProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(909, 60);
            this.panel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vendas";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textSalesDate);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textSalesName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textSalesCPF);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(0, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 126);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clientes";
            // 
            // textSalesDate
            // 
            this.textSalesDate.Location = new System.Drawing.Point(283, 37);
            this.textSalesDate.Mask = "00/00/0000";
            this.textSalesDate.Name = "textSalesDate";
            this.textSalesDate.Size = new System.Drawing.Size(119, 22);
            this.textSalesDate.TabIndex = 16;
            this.textSalesDate.ValidatingType = typeof(System.DateTime);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(218, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 25);
            this.label9.TabIndex = 15;
            this.label9.Text = "Data:";
            // 
            // textSalesName
            // 
            this.textSalesName.Location = new System.Drawing.Point(89, 76);
            this.textSalesName.Name = "textSalesName";
            this.textSalesName.Size = new System.Drawing.Size(313, 22);
            this.textSalesName.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Nome:";
            // 
            // textSalesCPF
            // 
            this.textSalesCPF.Location = new System.Drawing.Point(89, 36);
            this.textSalesCPF.Mask = "###.###.###-##";
            this.textSalesCPF.Name = "textSalesCPF";
            this.textSalesCPF.Size = new System.Drawing.Size(119, 22);
            this.textSalesCPF.TabIndex = 12;
            this.textSalesCPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textSalesCPF_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "CPF:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonSalesRemove);
            this.groupBox2.Controls.Add(this.buttonSalesCreate);
            this.groupBox2.Controls.Add(this.textSalesQuantity);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textSalesPrice);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textSalesDescription);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textSalesID);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(0, 208);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(452, 224);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Produtos";
            // 
            // buttonSalesRemove
            // 
            this.buttonSalesRemove.BackColor = System.Drawing.Color.Teal;
            this.buttonSalesRemove.Location = new System.Drawing.Point(242, 179);
            this.buttonSalesRemove.Name = "buttonSalesRemove";
            this.buttonSalesRemove.Size = new System.Drawing.Size(126, 39);
            this.buttonSalesRemove.TabIndex = 40;
            this.buttonSalesRemove.Text = "REMOVER";
            this.buttonSalesRemove.UseVisualStyleBackColor = false;
            this.buttonSalesRemove.Click += new System.EventHandler(this.buttonSalesRemove_Click);
            // 
            // buttonSalesCreate
            // 
            this.buttonSalesCreate.BackColor = System.Drawing.Color.Teal;
            this.buttonSalesCreate.Location = new System.Drawing.Point(107, 179);
            this.buttonSalesCreate.Name = "buttonSalesCreate";
            this.buttonSalesCreate.Size = new System.Drawing.Size(126, 39);
            this.buttonSalesCreate.TabIndex = 18;
            this.buttonSalesCreate.Text = "ADICIONAR";
            this.buttonSalesCreate.UseVisualStyleBackColor = false;
            this.buttonSalesCreate.Click += new System.EventHandler(this.buttonSalesCreate_Click);
            // 
            // textSalesQuantity
            // 
            this.textSalesQuantity.Location = new System.Drawing.Point(354, 130);
            this.textSalesQuantity.Name = "textSalesQuantity";
            this.textSalesQuantity.Size = new System.Drawing.Size(82, 22);
            this.textSalesQuantity.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(228, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 38;
            this.label2.Text = "Quantidade:";
            // 
            // textSalesPrice
            // 
            this.textSalesPrice.Location = new System.Drawing.Point(87, 131);
            this.textSalesPrice.Name = "textSalesPrice";
            this.textSalesPrice.Size = new System.Drawing.Size(120, 22);
            this.textSalesPrice.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 25);
            this.label4.TabIndex = 36;
            this.label4.Text = "Preço:";
            // 
            // textSalesDescription
            // 
            this.textSalesDescription.Location = new System.Drawing.Point(112, 90);
            this.textSalesDescription.Name = "textSalesDescription";
            this.textSalesDescription.Size = new System.Drawing.Size(324, 22);
            this.textSalesDescription.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 25);
            this.label7.TabIndex = 34;
            this.label7.Text = "Descrição:";
            // 
            // textSalesID
            // 
            this.textSalesID.Location = new System.Drawing.Point(133, 47);
            this.textSalesID.Name = "textSalesID";
            this.textSalesID.Size = new System.Drawing.Size(100, 22);
            this.textSalesID.TabIndex = 33;
            this.textSalesID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textSalesID_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 25);
            this.label8.TabIndex = 32;
            this.label8.Text = "Identificador: ";
            // 
            // dataGridSalesProducts
            // 
            this.dataGridSalesProducts.AllowUserToAddRows = false;
            this.dataGridSalesProducts.AllowUserToDeleteRows = false;
            this.dataGridSalesProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSalesProducts.Location = new System.Drawing.Point(473, 76);
            this.dataGridSalesProducts.Name = "dataGridSalesProducts";
            this.dataGridSalesProducts.ReadOnly = true;
            this.dataGridSalesProducts.RowHeadersWidth = 51;
            this.dataGridSalesProducts.RowTemplate.Height = 24;
            this.dataGridSalesProducts.Size = new System.Drawing.Size(410, 356);
            this.dataGridSalesProducts.TabIndex = 15;
            this.dataGridSalesProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridSalesProducts_CellContentClick);
            // 
            // textSalesTotal
            // 
            this.textSalesTotal.Location = new System.Drawing.Point(553, 451);
            this.textSalesTotal.Name = "textSalesTotal";
            this.textSalesTotal.Size = new System.Drawing.Size(235, 22);
            this.textSalesTotal.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(477, 447);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Total:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Teal;
            this.buttonCancel.Location = new System.Drawing.Point(644, 487);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(126, 39);
            this.buttonCancel.TabIndex = 42;
            this.buttonCancel.Text = "CANCELAR";
            this.buttonCancel.UseVisualStyleBackColor = false;
            // 
            // buttonPayment
            // 
            this.buttonPayment.BackColor = System.Drawing.Color.Teal;
            this.buttonPayment.Location = new System.Drawing.Point(509, 487);
            this.buttonPayment.Name = "buttonPayment";
            this.buttonPayment.Size = new System.Drawing.Size(126, 39);
            this.buttonPayment.TabIndex = 41;
            this.buttonPayment.Text = "PAGAMENTO";
            this.buttonPayment.UseVisualStyleBackColor = false;
            this.buttonPayment.Click += new System.EventHandler(this.buttonPayment_Click);
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 538);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonPayment);
            this.Controls.Add(this.textSalesTotal);
            this.Controls.Add(this.dataGridSalesProducts);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Sales";
            this.Text = "Vendas";
            this.Load += new System.EventHandler(this.Sales_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSalesProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox textSalesCPF;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textSalesName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textSalesQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textSalesPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textSalesDescription;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textSalesID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonSalesRemove;
        private System.Windows.Forms.Button buttonSalesCreate;
        private System.Windows.Forms.DataGridView dataGridSalesProducts;
        private System.Windows.Forms.TextBox textSalesTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonPayment;
        private System.Windows.Forms.MaskedTextBox textSalesDate;
        private System.Windows.Forms.Label label9;
    }
}