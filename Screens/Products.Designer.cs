namespace ProjetoVendas.Screens
{
    partial class Products
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
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonSaveProduct = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.tabProdutos = new System.Windows.Forms.TabControl();
            this.tabProduto1 = new System.Windows.Forms.TabPage();
            this.comboProductSupplier = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textProductQuantity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textProductPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textProductDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textProductID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabProduto2 = new System.Windows.Forms.TabPage();
            this.dataGridProduct = new System.Windows.Forms.DataGridView();
            this.buttonProductSearch = new System.Windows.Forms.Button();
            this.textReadingNameProduct = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabProdutos.SuspendLayout();
            this.tabProduto1.SuspendLayout();
            this.tabProduto2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduct)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCreate
            // 
            this.buttonCreate.BackColor = System.Drawing.Color.Teal;
            this.buttonCreate.Location = new System.Drawing.Point(126, 439);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(126, 39);
            this.buttonCreate.TabIndex = 11;
            this.buttonCreate.Text = "CRIAR";
            this.buttonCreate.UseVisualStyleBackColor = false;
            // 
            // buttonSaveProduct
            // 
            this.buttonSaveProduct.BackColor = System.Drawing.Color.Teal;
            this.buttonSaveProduct.Location = new System.Drawing.Point(269, 439);
            this.buttonSaveProduct.Name = "buttonSaveProduct";
            this.buttonSaveProduct.Size = new System.Drawing.Size(126, 39);
            this.buttonSaveProduct.TabIndex = 10;
            this.buttonSaveProduct.Text = "SALVAR";
            this.buttonSaveProduct.UseVisualStyleBackColor = false;
            this.buttonSaveProduct.Click += new System.EventHandler(this.buttonSaveProduct_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.Teal;
            this.buttonUpdate.Location = new System.Drawing.Point(423, 439);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(126, 39);
            this.buttonUpdate.TabIndex = 9;
            this.buttonUpdate.Text = "ALTERAR";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackColor = System.Drawing.Color.Teal;
            this.buttonRemove.Location = new System.Drawing.Point(573, 439);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(126, 39);
            this.buttonRemove.TabIndex = 8;
            this.buttonRemove.Text = "REMOVER";
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // tabProdutos
            // 
            this.tabProdutos.Controls.Add(this.tabProduto1);
            this.tabProdutos.Controls.Add(this.tabProduto2);
            this.tabProdutos.Location = new System.Drawing.Point(0, 54);
            this.tabProdutos.Name = "tabProdutos";
            this.tabProdutos.SelectedIndex = 0;
            this.tabProdutos.Size = new System.Drawing.Size(800, 379);
            this.tabProdutos.TabIndex = 7;
            // 
            // tabProduto1
            // 
            this.tabProduto1.Controls.Add(this.comboProductSupplier);
            this.tabProduto1.Controls.Add(this.label6);
            this.tabProduto1.Controls.Add(this.textProductQuantity);
            this.tabProduto1.Controls.Add(this.label5);
            this.tabProduto1.Controls.Add(this.textProductPrice);
            this.tabProduto1.Controls.Add(this.label4);
            this.tabProduto1.Controls.Add(this.textProductDescription);
            this.tabProduto1.Controls.Add(this.label3);
            this.tabProduto1.Controls.Add(this.textProductID);
            this.tabProduto1.Controls.Add(this.label2);
            this.tabProduto1.Location = new System.Drawing.Point(4, 25);
            this.tabProduto1.Name = "tabProduto1";
            this.tabProduto1.Padding = new System.Windows.Forms.Padding(3);
            this.tabProduto1.Size = new System.Drawing.Size(792, 350);
            this.tabProduto1.TabIndex = 0;
            this.tabProduto1.Text = "Novo Produto";
            this.tabProduto1.UseVisualStyleBackColor = true;
            // 
            // comboProductSupplier
            // 
            this.comboProductSupplier.FormattingEnabled = true;
            this.comboProductSupplier.Location = new System.Drawing.Point(381, 41);
            this.comboProductSupplier.Name = "comboProductSupplier";
            this.comboProductSupplier.Size = new System.Drawing.Size(371, 24);
            this.comboProductSupplier.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(260, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Fornecedor:";
            // 
            // textProductQuantity
            // 
            this.textProductQuantity.Location = new System.Drawing.Point(364, 120);
            this.textProductQuantity.Name = "textProductQuantity";
            this.textProductQuantity.Size = new System.Drawing.Size(82, 22);
            this.textProductQuantity.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(238, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Quantidade:";
            // 
            // textProductPrice
            // 
            this.textProductPrice.Location = new System.Drawing.Point(97, 121);
            this.textProductPrice.Name = "textProductPrice";
            this.textProductPrice.Size = new System.Drawing.Size(120, 22);
            this.textProductPrice.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Preço:";
            // 
            // textProductDescription
            // 
            this.textProductDescription.Location = new System.Drawing.Point(122, 80);
            this.textProductDescription.Name = "textProductDescription";
            this.textProductDescription.Size = new System.Drawing.Size(630, 22);
            this.textProductDescription.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descrição:";
            // 
            // textProductID
            // 
            this.textProductID.Location = new System.Drawing.Point(143, 37);
            this.textProductID.Name = "textProductID";
            this.textProductID.Size = new System.Drawing.Size(100, 22);
            this.textProductID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Identificador: ";
            // 
            // tabProduto2
            // 
            this.tabProduto2.Controls.Add(this.dataGridProduct);
            this.tabProduto2.Controls.Add(this.buttonProductSearch);
            this.tabProduto2.Controls.Add(this.textReadingNameProduct);
            this.tabProduto2.Controls.Add(this.label28);
            this.tabProduto2.Location = new System.Drawing.Point(4, 25);
            this.tabProduto2.Name = "tabProduto2";
            this.tabProduto2.Padding = new System.Windows.Forms.Padding(3);
            this.tabProduto2.Size = new System.Drawing.Size(792, 350);
            this.tabProduto2.TabIndex = 1;
            this.tabProduto2.Text = "Consultar Produto";
            this.tabProduto2.UseVisualStyleBackColor = true;
            // 
            // dataGridProduct
            // 
            this.dataGridProduct.AllowUserToAddRows = false;
            this.dataGridProduct.AllowUserToDeleteRows = false;
            this.dataGridProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProduct.Location = new System.Drawing.Point(7, 91);
            this.dataGridProduct.Name = "dataGridProduct";
            this.dataGridProduct.ReadOnly = true;
            this.dataGridProduct.RowHeadersWidth = 51;
            this.dataGridProduct.RowTemplate.Height = 24;
            this.dataGridProduct.Size = new System.Drawing.Size(782, 256);
            this.dataGridProduct.TabIndex = 33;
            this.dataGridProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProduct_CellClick);
            this.dataGridProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProduct_CellContentClick);
            // 
            // buttonProductSearch
            // 
            this.buttonProductSearch.BackColor = System.Drawing.Color.Teal;
            this.buttonProductSearch.Location = new System.Drawing.Point(637, 46);
            this.buttonProductSearch.Name = "buttonProductSearch";
            this.buttonProductSearch.Size = new System.Drawing.Size(126, 39);
            this.buttonProductSearch.TabIndex = 6;
            this.buttonProductSearch.Text = "PESQUISAR";
            this.buttonProductSearch.UseVisualStyleBackColor = false;
            this.buttonProductSearch.Click += new System.EventHandler(this.buttonProductSearch_Click);
            // 
            // textReadingNameProduct
            // 
            this.textReadingNameProduct.Location = new System.Drawing.Point(107, 54);
            this.textReadingNameProduct.Name = "textReadingNameProduct";
            this.textReadingNameProduct.Size = new System.Drawing.Size(523, 22);
            this.textReadingNameProduct.TabIndex = 32;
            this.textReadingNameProduct.TextChanged += new System.EventHandler(this.textReadingNameProduct_TextChanged);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(31, 50);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(70, 25);
            this.label28.TabIndex = 31;
            this.label28.Text = "Nome:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 53);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Produtos";
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 489);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.buttonSaveProduct);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.tabProdutos);
            this.Controls.Add(this.panel1);
            this.Name = "Products";
            this.Text = "Cadastro de Produtos";
            this.Load += new System.EventHandler(this.Products_Load);
            this.tabProdutos.ResumeLayout(false);
            this.tabProduto1.ResumeLayout(false);
            this.tabProduto1.PerformLayout();
            this.tabProduto2.ResumeLayout(false);
            this.tabProduto2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduct)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonSaveProduct;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.TextBox textProductPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textProductDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textProductID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridProduct;
        private System.Windows.Forms.Button buttonProductSearch;
        private System.Windows.Forms.TextBox textReadingNameProduct;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textProductQuantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboProductSupplier;
        public System.Windows.Forms.TabControl tabProdutos;
        public System.Windows.Forms.TabPage tabProduto1;
        public System.Windows.Forms.TabPage tabProduto2;
    }
}