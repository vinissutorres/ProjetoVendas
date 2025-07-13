namespace ProjetoVendas.Screens
{
    partial class History
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
            this.buttonSearchHistory = new System.Windows.Forms.Button();
            this.dateEnding = new System.Windows.Forms.DateTimePicker();
            this.dateBeginning = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataHistory = new System.Windows.Forms.DataGridView();
            this.colCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colObs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataHistory)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(733, 53);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Histórico";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSearchHistory);
            this.groupBox1.Controls.Add(this.dateEnding);
            this.groupBox1.Controls.Add(this.dateBeginning);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(0, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 122);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consulta";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // buttonSearchHistory
            // 
            this.buttonSearchHistory.BackColor = System.Drawing.Color.Teal;
            this.buttonSearchHistory.Location = new System.Drawing.Point(441, 33);
            this.buttonSearchHistory.Name = "buttonSearchHistory";
            this.buttonSearchHistory.Size = new System.Drawing.Size(107, 36);
            this.buttonSearchHistory.TabIndex = 12;
            this.buttonSearchHistory.Text = "PESQUISAR";
            this.buttonSearchHistory.UseVisualStyleBackColor = false;
            this.buttonSearchHistory.Click += new System.EventHandler(this.buttonSearchHistory_Click);
            // 
            // dateEnding
            // 
            this.dateEnding.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateEnding.Location = new System.Drawing.Point(326, 40);
            this.dateEnding.Name = "dateEnding";
            this.dateEnding.Size = new System.Drawing.Size(96, 22);
            this.dateEnding.TabIndex = 6;
            // 
            // dateBeginning
            // 
            this.dateBeginning.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateBeginning.Location = new System.Drawing.Point(127, 39);
            this.dateBeginning.Name = "dateBeginning";
            this.dateBeginning.Size = new System.Drawing.Size(91, 22);
            this.dateBeginning.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(224, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Data Fim:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Data Início:";
            // 
            // dataHistory
            // 
            this.dataHistory.AllowUserToAddRows = false;
            this.dataHistory.AllowUserToDeleteRows = false;
            this.dataHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCod,
            this.colData,
            this.colCliente,
            this.colTotal,
            this.colObs});
            this.dataHistory.Location = new System.Drawing.Point(17, 201);
            this.dataHistory.Name = "dataHistory";
            this.dataHistory.ReadOnly = true;
            this.dataHistory.RowHeadersWidth = 51;
            this.dataHistory.RowTemplate.Height = 24;
            this.dataHistory.Size = new System.Drawing.Size(704, 237);
            this.dataHistory.TabIndex = 4;
            this.dataHistory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataHistory_CellClick);
            // 
            // colCod
            // 
            this.colCod.HeaderText = "Código";
            this.colCod.MinimumWidth = 6;
            this.colCod.Name = "colCod";
            this.colCod.ReadOnly = true;
            this.colCod.Width = 125;
            // 
            // colData
            // 
            this.colData.HeaderText = "Data Venda";
            this.colData.MinimumWidth = 6;
            this.colData.Name = "colData";
            this.colData.ReadOnly = true;
            this.colData.Width = 125;
            // 
            // colCliente
            // 
            this.colCliente.HeaderText = "Cliente";
            this.colCliente.MinimumWidth = 6;
            this.colCliente.Name = "colCliente";
            this.colCliente.ReadOnly = true;
            this.colCliente.Width = 125;
            // 
            // colTotal
            // 
            this.colTotal.HeaderText = "Total";
            this.colTotal.MinimumWidth = 6;
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            this.colTotal.Width = 125;
            // 
            // colObs
            // 
            this.colObs.HeaderText = "Observações";
            this.colObs.MinimumWidth = 6;
            this.colObs.Name = "colObs";
            this.colObs.ReadOnly = true;
            this.colObs.Width = 125;
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 450);
            this.Controls.Add(this.dataHistory);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "History";
            this.Text = "Histórico";
            this.Load += new System.EventHandler(this.History_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateEnding;
        private System.Windows.Forms.DateTimePicker dateBeginning;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataHistory;
        private System.Windows.Forms.Button buttonSearchHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn colData;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colObs;
    }
}