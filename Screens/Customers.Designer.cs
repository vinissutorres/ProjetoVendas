using System;
using System.Data;
using System.Windows.Forms;

namespace ProjetoVendas.Screens
{
    partial class Customers
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
            this.tabCadastro = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonCode = new System.Windows.Forms.Button();
            this.comboBoxState = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textCity = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textNeighbourhood = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textDetails = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textHouseNumber = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textZipCode = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textCellPhone = new System.Windows.Forms.MaskedTextBox();
            this.textPhone = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textRG = new System.Windows.Forms.MaskedTextBox();
            this.textCPF = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridPeople = new System.Windows.Forms.DataGridView();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textReadingName = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabCadastro.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 53);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clientes";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabCadastro
            // 
            this.tabCadastro.Controls.Add(this.tabPage1);
            this.tabCadastro.Controls.Add(this.tabPage2);
            this.tabCadastro.Location = new System.Drawing.Point(1, 59);
            this.tabCadastro.Name = "tabCadastro";
            this.tabCadastro.SelectedIndex = 0;
            this.tabCadastro.Size = new System.Drawing.Size(800, 379);
            this.tabCadastro.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonCode);
            this.tabPage1.Controls.Add(this.comboBoxState);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.textCity);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.textNeighbourhood);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.textDetails);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.textHouseNumber);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.textAddress);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.textZipCode);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.textCellPhone);
            this.tabPage1.Controls.Add(this.textPhone);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.textRG);
            this.tabPage1.Controls.Add(this.textCPF);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.textEmail);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.textName);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textID);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 350);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Novo Cadastro";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // buttonCode
            // 
            this.buttonCode.BackColor = System.Drawing.Color.Teal;
            this.buttonCode.Location = new System.Drawing.Point(177, 208);
            this.buttonCode.Name = "buttonCode";
            this.buttonCode.Size = new System.Drawing.Size(54, 25);
            this.buttonCode.TabIndex = 6;
            this.buttonCode.Text = "VER";
            this.buttonCode.UseVisualStyleBackColor = false;
            this.buttonCode.Click += new System.EventHandler(this.buttonCode_Click);
            // 
            // comboBoxState
            // 
            this.comboBoxState.FormattingEnabled = true;
            this.comboBoxState.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AM",
            "AP",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MG",
            "MS",
            "MT",
            "PA",
            "PB",
            "PE",
            "PI",
            "PR",
            "RJ",
            "RN",
            "RO",
            "RR",
            "RS",
            "SP",
            "SE",
            "TO"});
            this.comboBoxState.Location = new System.Drawing.Point(383, 303);
            this.comboBoxState.Name = "comboBoxState";
            this.comboBoxState.Size = new System.Drawing.Size(65, 24);
            this.comboBoxState.TabIndex = 30;
            this.comboBoxState.SelectedIndexChanged += new System.EventHandler(this.label7_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(333, 302);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 25);
            this.label15.TabIndex = 28;
            this.label15.Text = "UF:";
            // 
            // textCity
            // 
            this.textCity.Location = new System.Drawing.Point(106, 304);
            this.textCity.Name = "textCity";
            this.textCity.Size = new System.Drawing.Size(210, 22);
            this.textCity.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(21, 300);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 25);
            this.label14.TabIndex = 26;
            this.label14.Text = "Cidade:";
            // 
            // textNeighbourhood
            // 
            this.textNeighbourhood.Location = new System.Drawing.Point(542, 258);
            this.textNeighbourhood.Name = "textNeighbourhood";
            this.textNeighbourhood.Size = new System.Drawing.Size(210, 22);
            this.textNeighbourhood.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(467, 257);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 25);
            this.label13.TabIndex = 24;
            this.label13.Text = "Bairro:";
            // 
            // textDetails
            // 
            this.textDetails.Location = new System.Drawing.Point(168, 257);
            this.textDetails.Name = "textDetails";
            this.textDetails.Size = new System.Drawing.Size(280, 22);
            this.textDetails.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(22, 254);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(140, 25);
            this.label12.TabIndex = 22;
            this.label12.Text = "Complemento:";
            // 
            // textHouseNumber
            // 
            this.textHouseNumber.Location = new System.Drawing.Point(680, 216);
            this.textHouseNumber.Name = "textHouseNumber";
            this.textHouseNumber.Size = new System.Drawing.Size(72, 22);
            this.textHouseNumber.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(587, 212);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 25);
            this.label11.TabIndex = 20;
            this.label11.Text = "Número:";
            // 
            // textAddress
            // 
            this.textAddress.Location = new System.Drawing.Point(362, 212);
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(200, 22);
            this.textAddress.TabIndex = 19;
            this.textAddress.TextChanged += new System.EventHandler(this.textAddress_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(254, 208);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 25);
            this.label10.TabIndex = 18;
            this.label10.Text = "Endereço:";
            // 
            // textZipCode
            // 
            this.textZipCode.Location = new System.Drawing.Point(97, 209);
            this.textZipCode.Mask = "00000-000";
            this.textZipCode.Name = "textZipCode";
            this.textZipCode.Size = new System.Drawing.Size(75, 22);
            this.textZipCode.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 209);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 25);
            this.label9.TabIndex = 16;
            this.label9.Text = "CEP:";
            // 
            // textCellPhone
            // 
            this.textCellPhone.Location = new System.Drawing.Point(336, 171);
            this.textCellPhone.Mask = "(99) 00000-0000";
            this.textCellPhone.Name = "textCellPhone";
            this.textCellPhone.Size = new System.Drawing.Size(134, 22);
            this.textCellPhone.TabIndex = 15;
            // 
            // textPhone
            // 
            this.textPhone.Location = new System.Drawing.Point(122, 168);
            this.textPhone.Mask = "(99) 0000-0000";
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(121, 22);
            this.textPhone.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(250, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Celular:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "Telefone:";
            // 
            // textRG
            // 
            this.textRG.Location = new System.Drawing.Point(296, 120);
            this.textRG.Mask = "##.###.###-##";
            this.textRG.Name = "textRG";
            this.textRG.Size = new System.Drawing.Size(107, 22);
            this.textRG.TabIndex = 11;
            // 
            // textCPF
            // 
            this.textCPF.Location = new System.Drawing.Point(98, 120);
            this.textCPF.Mask = "###.###.###-##";
            this.textCPF.Name = "textCPF";
            this.textCPF.Size = new System.Drawing.Size(129, 22);
            this.textCPF.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(239, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "RG: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "CPF:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(472, 80);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(280, 22);
            this.textEmail.TabIndex = 5;
            this.textEmail.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(396, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "E-mail:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(97, 80);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(280, 22);
            this.textName.TabIndex = 3;
            this.textName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(143, 37);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(100, 22);
            this.textID.TabIndex = 1;
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
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridPeople);
            this.tabPage2.Controls.Add(this.buttonSearch);
            this.tabPage2.Controls.Add(this.textReadingName);
            this.tabPage2.Controls.Add(this.label28);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 350);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consultar Cadastro";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridPeople
            // 
            this.dataGridPeople.AllowUserToAddRows = false;
            this.dataGridPeople.AllowUserToDeleteRows = false;
            this.dataGridPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPeople.Location = new System.Drawing.Point(7, 91);
            this.dataGridPeople.Name = "dataGridPeople";
            this.dataGridPeople.ReadOnly = true;
            this.dataGridPeople.RowHeadersWidth = 51;
            this.dataGridPeople.RowTemplate.Height = 24;
            this.dataGridPeople.Size = new System.Drawing.Size(782, 256);
            this.dataGridPeople.TabIndex = 33;
            this.dataGridPeople.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPeople_CellContentClick);
            this.dataGridPeople.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPeople_CellContentClick);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.Teal;
            this.buttonSearch.Location = new System.Drawing.Point(637, 46);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(126, 39);
            this.buttonSearch.TabIndex = 6;
            this.buttonSearch.Text = "PESQUISAR";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textReadingName
            // 
            this.textReadingName.Location = new System.Drawing.Point(107, 54);
            this.textReadingName.Name = "textReadingName";
            this.textReadingName.Size = new System.Drawing.Size(523, 22);
            this.textReadingName.TabIndex = 32;
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
            // buttonRemove
            // 
            this.buttonRemove.BackColor = System.Drawing.Color.Teal;
            this.buttonRemove.Location = new System.Drawing.Point(553, 445);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(126, 39);
            this.buttonRemove.TabIndex = 2;
            this.buttonRemove.Text = "REMOVER";
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.Teal;
            this.buttonUpdate.Location = new System.Drawing.Point(403, 445);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(126, 39);
            this.buttonUpdate.TabIndex = 3;
            this.buttonUpdate.Text = "ALTERAR";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.Teal;
            this.buttonSave.Location = new System.Drawing.Point(249, 445);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(126, 39);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "SALVAR";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCreate
            // 
            this.buttonCreate.BackColor = System.Drawing.Color.Teal;
            this.buttonCreate.Location = new System.Drawing.Point(106, 445);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(126, 39);
            this.buttonCreate.TabIndex = 5;
            this.buttonCreate.Text = "CRIAR";
            this.buttonCreate.UseVisualStyleBackColor = false;
            this.buttonCreate.Click += new System.EventHandler(this.button4_Click);
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 496);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.tabCadastro);
            this.Controls.Add(this.panel1);
            this.Name = "Customers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Clientes";
            this.Load += new System.EventHandler(this.Customers_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabCadastro.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPeople)).EndInit();
            this.ResumeLayout(false);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String zipCode = textZipCode.Text;
                String xml = "https://viacep.com.br/ws/" + zipCode + "/xml/";
                DataSet data = new DataSet();
                data.ReadXml(xml);

                textAddress.Text = data.Tables[0].Rows[0]["logradouro"].ToString();
                textNeighbourhood.Text = data.Tables[0].Rows[0]["bairro"].ToString();
                textCity.Text = data.Tables[0].Rows[0]["localidade"].ToString();
                textDetails.Text = data.Tables[0].Rows[0]["complemento"].ToString();
                comboBoxState.Text = data.Tables[0].Rows[0]["uf"].ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("Endereço não encontrado.");
            }

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox textRG;
        private System.Windows.Forms.MaskedTextBox textCPF;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox textCellPhone;
        private System.Windows.Forms.MaskedTextBox textPhone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox textZipCode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textCity;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textNeighbourhood;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textDetails;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textHouseNumber;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxState;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textReadingName;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.DataGridView dataGridPeople;
        private System.Windows.Forms.Button buttonCode;
        public TabPage tabPage1;
        public TabPage tabPage2;
        public TabControl tabCadastro;
    }
}