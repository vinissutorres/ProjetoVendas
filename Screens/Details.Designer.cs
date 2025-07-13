namespace ProjetoVendas.Screens
{
    partial class Details
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textDetailsCustomer = new System.Windows.Forms.TextBox();
            this.textDetailsDate = new System.Windows.Forms.TextBox();
            this.textDetailsValue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textDetailsObs = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DetailsGrid = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetailsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 53);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Detalhes";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textDetailsObs);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textDetailsValue);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textDetailsDate);
            this.groupBox1.Controls.Add(this.textDetailsCustomer);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(0, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 122);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Data:";
            // 
            // textDetailsCustomer
            // 
            this.textDetailsCustomer.Location = new System.Drawing.Point(97, 39);
            this.textDetailsCustomer.Name = "textDetailsCustomer";
            this.textDetailsCustomer.ReadOnly = true;
            this.textDetailsCustomer.Size = new System.Drawing.Size(329, 22);
            this.textDetailsCustomer.TabIndex = 5;
            // 
            // textDetailsDate
            // 
            this.textDetailsDate.Location = new System.Drawing.Point(97, 77);
            this.textDetailsDate.Name = "textDetailsDate";
            this.textDetailsDate.ReadOnly = true;
            this.textDetailsDate.Size = new System.Drawing.Size(120, 22);
            this.textDetailsDate.TabIndex = 6;
            // 
            // textDetailsValue
            // 
            this.textDetailsValue.Location = new System.Drawing.Point(306, 81);
            this.textDetailsValue.Name = "textDetailsValue";
            this.textDetailsValue.ReadOnly = true;
            this.textDetailsValue.Size = new System.Drawing.Size(120, 22);
            this.textDetailsValue.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(234, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Valor:";
            // 
            // textDetailsObs
            // 
            this.textDetailsObs.Location = new System.Drawing.Point(519, 40);
            this.textDetailsObs.Multiline = true;
            this.textDetailsObs.Name = "textDetailsObs";
            this.textDetailsObs.ReadOnly = true;
            this.textDetailsObs.Size = new System.Drawing.Size(269, 63);
            this.textDetailsObs.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(447, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Obs:";
            // 
            // DetailsGrid
            // 
            this.DetailsGrid.AllowUserToAddRows = false;
            this.DetailsGrid.AllowUserToDeleteRows = false;
            this.DetailsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetailsGrid.Location = new System.Drawing.Point(0, 208);
            this.DetailsGrid.Name = "DetailsGrid";
            this.DetailsGrid.ReadOnly = true;
            this.DetailsGrid.RowHeadersWidth = 51;
            this.DetailsGrid.RowTemplate.Height = 24;
            this.DetailsGrid.Size = new System.Drawing.Size(800, 230);
            this.DetailsGrid.TabIndex = 5;
            // 
            // Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DetailsGrid);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Details";
            this.Text = "Details";
            this.Load += new System.EventHandler(this.Details_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetailsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DetailsGrid;
        public System.Windows.Forms.TextBox textDetailsObs;
        public System.Windows.Forms.TextBox textDetailsValue;
        public System.Windows.Forms.TextBox textDetailsDate;
        public System.Windows.Forms.TextBox textDetailsCustomer;
    }
}