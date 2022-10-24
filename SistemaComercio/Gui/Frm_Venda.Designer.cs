﻿namespace SistemaComercio.Gui
{
    partial class Frm_Venda
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
            this.tbcVenda = new System.Windows.Forms.TabControl();
            this.tbpLancarVenda = new System.Windows.Forms.TabPage();
            this.btnLimparCampos = new System.Windows.Forms.Button();
            this.cmbQuantidade = new System.Windows.Forms.ComboBox();
            this.btnLancarVenda = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSelecioneProduto = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.cmbSelecioneProduto = new System.Windows.Forms.ComboBox();
            this.lblExemplo = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblPrecoUnitario = new System.Windows.Forms.Label();
            this.tbpCancelarVenda = new System.Windows.Forms.TabPage();
            this.btnCancelarVenda = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnEmitirRelatorio = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.cmbSituacao = new System.Windows.Forms.ComboBox();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbCliente = new System.Windows.Forms.RadioButton();
            this.rdbPeriodo = new System.Windows.Forms.RadioButton();
            this.lblSlecioneCancelamento = new System.Windows.Forms.Label();
            this.cmbSelecioneCancelamento = new System.Windows.Forms.ComboBox();
            this.lblExemploCancelar = new System.Windows.Forms.Label();
            this.btnPesquisarCancelar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbQuantiCancelar = new System.Windows.Forms.ComboBox();
            this.lblPrecoCancelar = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnLimparCancelar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tbcVenda.SuspendLayout();
            this.tbpLancarVenda.SuspendLayout();
            this.tbpCancelarVenda.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Controls.Add(this.tbcVenda);
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.btnEmitirRelatorio);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.btnConsultar);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(-7, -7);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(531, 545);
            this.panel1.TabIndex = 0;
            // 
            // tbcVenda
            // 
            this.tbcVenda.Controls.Add(this.tbpLancarVenda);
            this.tbcVenda.Controls.Add(this.tbpCancelarVenda);
            this.tbcVenda.Location = new System.Drawing.Point(19, 19);
            this.tbcVenda.Name = "tbcVenda";
            this.tbcVenda.SelectedIndex = 0;
            this.tbcVenda.Size = new System.Drawing.Size(493, 149);
            this.tbcVenda.TabIndex = 14;
            // 
            // tbpLancarVenda
            // 
            this.tbpLancarVenda.BackColor = System.Drawing.Color.MistyRose;
            this.tbpLancarVenda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbpLancarVenda.Controls.Add(this.btnLimparCampos);
            this.tbpLancarVenda.Controls.Add(this.cmbQuantidade);
            this.tbpLancarVenda.Controls.Add(this.btnLancarVenda);
            this.tbpLancarVenda.Controls.Add(this.label1);
            this.tbpLancarVenda.Controls.Add(this.txtSelecioneProduto);
            this.tbpLancarVenda.Controls.Add(this.btnPesquisar);
            this.tbpLancarVenda.Controls.Add(this.cmbSelecioneProduto);
            this.tbpLancarVenda.Controls.Add(this.lblExemplo);
            this.tbpLancarVenda.Controls.Add(this.lblQuantidade);
            this.tbpLancarVenda.Controls.Add(this.lblPrecoUnitario);
            this.tbpLancarVenda.Location = new System.Drawing.Point(4, 22);
            this.tbpLancarVenda.Name = "tbpLancarVenda";
            this.tbpLancarVenda.Padding = new System.Windows.Forms.Padding(3);
            this.tbpLancarVenda.Size = new System.Drawing.Size(485, 123);
            this.tbpLancarVenda.TabIndex = 0;
            this.tbpLancarVenda.Text = "Lançar Venda";
            // 
            // btnLimparCampos
            // 
            this.btnLimparCampos.Location = new System.Drawing.Point(238, 90);
            this.btnLimparCampos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLimparCampos.Name = "btnLimparCampos";
            this.btnLimparCampos.Size = new System.Drawing.Size(118, 23);
            this.btnLimparCampos.TabIndex = 9;
            this.btnLimparCampos.Text = "Limpar Campos";
            this.btnLimparCampos.UseVisualStyleBackColor = true;
            // 
            // cmbQuantidade
            // 
            this.cmbQuantidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQuantidade.FormattingEnabled = true;
            this.cmbQuantidade.Location = new System.Drawing.Point(70, 55);
            this.cmbQuantidade.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbQuantidade.Name = "cmbQuantidade";
            this.cmbQuantidade.Size = new System.Drawing.Size(152, 21);
            this.cmbQuantidade.TabIndex = 5;
            // 
            // btnLancarVenda
            // 
            this.btnLancarVenda.Location = new System.Drawing.Point(104, 90);
            this.btnLancarVenda.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLancarVenda.Name = "btnLancarVenda";
            this.btnLancarVenda.Size = new System.Drawing.Size(118, 23);
            this.btnLancarVenda.TabIndex = 7;
            this.btnLancarVenda.Text = "Lançar Venda";
            this.btnLancarVenda.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione o produto que deseja vender:";
            // 
            // txtSelecioneProduto
            // 
            this.txtSelecioneProduto.Enabled = false;
            this.txtSelecioneProduto.Location = new System.Drawing.Point(302, 55);
            this.txtSelecioneProduto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSelecioneProduto.Name = "txtSelecioneProduto";
            this.txtSelecioneProduto.Size = new System.Drawing.Size(172, 21);
            this.txtSelecioneProduto.TabIndex = 1;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(380, 26);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(94, 23);
            this.btnPesquisar.TabIndex = 1;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // cmbSelecioneProduto
            // 
            this.cmbSelecioneProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelecioneProduto.FormattingEnabled = true;
            this.cmbSelecioneProduto.Location = new System.Drawing.Point(10, 28);
            this.cmbSelecioneProduto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbSelecioneProduto.Name = "cmbSelecioneProduto";
            this.cmbSelecioneProduto.Size = new System.Drawing.Size(294, 21);
            this.cmbSelecioneProduto.TabIndex = 3;
            // 
            // lblExemplo
            // 
            this.lblExemplo.AutoSize = true;
            this.lblExemplo.Location = new System.Drawing.Point(306, 31);
            this.lblExemplo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExemplo.Name = "lblExemplo";
            this.lblExemplo.Size = new System.Drawing.Size(74, 13);
            this.lblExemplo.TabIndex = 2;
            this.lblExemplo.Text = "Ex: Xbox 360";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(7, 58);
            this.lblQuantidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(64, 13);
            this.lblQuantidade.TabIndex = 4;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // lblPrecoUnitario
            // 
            this.lblPrecoUnitario.AutoSize = true;
            this.lblPrecoUnitario.Location = new System.Drawing.Point(225, 58);
            this.lblPrecoUnitario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecoUnitario.Name = "lblPrecoUnitario";
            this.lblPrecoUnitario.Size = new System.Drawing.Size(79, 13);
            this.lblPrecoUnitario.TabIndex = 6;
            this.lblPrecoUnitario.Text = "Preço Unitário:";
            // 
            // tbpCancelarVenda
            // 
            this.tbpCancelarVenda.BackColor = System.Drawing.Color.MistyRose;
            this.tbpCancelarVenda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbpCancelarVenda.Controls.Add(this.btnLimparCancelar);
            this.tbpCancelarVenda.Controls.Add(this.textBox1);
            this.tbpCancelarVenda.Controls.Add(this.lblPrecoCancelar);
            this.tbpCancelarVenda.Controls.Add(this.cmbQuantiCancelar);
            this.tbpCancelarVenda.Controls.Add(this.label3);
            this.tbpCancelarVenda.Controls.Add(this.cmbSelecioneCancelamento);
            this.tbpCancelarVenda.Controls.Add(this.btnPesquisarCancelar);
            this.tbpCancelarVenda.Controls.Add(this.lblExemploCancelar);
            this.tbpCancelarVenda.Controls.Add(this.lblSlecioneCancelamento);
            this.tbpCancelarVenda.Controls.Add(this.btnCancelarVenda);
            this.tbpCancelarVenda.Location = new System.Drawing.Point(4, 22);
            this.tbpCancelarVenda.Name = "tbpCancelarVenda";
            this.tbpCancelarVenda.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCancelarVenda.Size = new System.Drawing.Size(485, 123);
            this.tbpCancelarVenda.TabIndex = 1;
            this.tbpCancelarVenda.Text = "Cancelar Venda";
            // 
            // btnCancelarVenda
            // 
            this.btnCancelarVenda.Location = new System.Drawing.Point(101, 90);
            this.btnCancelarVenda.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancelarVenda.Name = "btnCancelarVenda";
            this.btnCancelarVenda.Size = new System.Drawing.Size(118, 23);
            this.btnCancelarVenda.TabIndex = 8;
            this.btnCancelarVenda.Text = "Cancelar Venda";
            this.btnCancelarVenda.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(426, 509);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(86, 23);
            this.btnSair.TabIndex = 13;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // btnEmitirRelatorio
            // 
            this.btnEmitirRelatorio.Location = new System.Drawing.Point(21, 509);
            this.btnEmitirRelatorio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEmitirRelatorio.Name = "btnEmitirRelatorio";
            this.btnEmitirRelatorio.Size = new System.Drawing.Size(115, 23);
            this.btnEmitirRelatorio.TabIndex = 10;
            this.btnEmitirRelatorio.Text = "Emitir Relatório";
            this.btnEmitirRelatorio.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTotal);
            this.groupBox3.Controls.Add(this.lblTotal);
            this.groupBox3.Controls.Add(this.cmbSituacao);
            this.groupBox3.Controls.Add(this.lblSituacao);
            this.groupBox3.Controls.Add(this.txtHora);
            this.groupBox3.Controls.Add(this.lblHora);
            this.groupBox3.Controls.Add(this.txtData);
            this.groupBox3.Controls.Add(this.lblData);
            this.groupBox3.Location = new System.Drawing.Point(21, 412);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(492, 91);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dados Operacionais";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(309, 55);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(174, 21);
            this.txtTotal.TabIndex = 15;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(274, 58);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 14;
            this.lblTotal.Text = "Total:";
            // 
            // cmbSituacao
            // 
            this.cmbSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSituacao.FormattingEnabled = true;
            this.cmbSituacao.Location = new System.Drawing.Point(55, 55);
            this.cmbSituacao.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbSituacao.Name = "cmbSituacao";
            this.cmbSituacao.Size = new System.Drawing.Size(199, 21);
            this.cmbSituacao.TabIndex = 13;
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Location = new System.Drawing.Point(7, 58);
            this.lblSituacao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(50, 13);
            this.lblSituacao.TabIndex = 13;
            this.lblSituacao.Text = "Situação:";
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(309, 26);
            this.txtHora.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(174, 21);
            this.txtHora.TabIndex = 12;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(274, 29);
            this.lblHora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(34, 13);
            this.lblHora.TabIndex = 11;
            this.lblHora.Text = "Hora:";
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(42, 26);
            this.txtData.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(212, 21);
            this.txtData.TabIndex = 10;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(7, 29);
            this.lblData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(32, 13);
            this.lblData.TabIndex = 10;
            this.lblData.Text = "Data:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 249);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(491, 157);
            this.dataGridView1.TabIndex = 11;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(437, 204);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 10;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(162, 204);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(272, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 188);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(353, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Selecione a venda que deseja consultar após selecionar o tipo de consulta:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbCliente);
            this.groupBox2.Controls.Add(this.rdbPeriodo);
            this.groupBox2.Location = new System.Drawing.Point(21, 179);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(126, 64);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo de Consulta";
            // 
            // rdbCliente
            // 
            this.rdbCliente.AutoSize = true;
            this.rdbCliente.Location = new System.Drawing.Point(8, 41);
            this.rdbCliente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdbCliente.Name = "rdbCliente";
            this.rdbCliente.Size = new System.Drawing.Size(58, 17);
            this.rdbCliente.TabIndex = 3;
            this.rdbCliente.Text = "Cliente";
            this.rdbCliente.UseVisualStyleBackColor = true;
            // 
            // rdbPeriodo
            // 
            this.rdbPeriodo.AutoSize = true;
            this.rdbPeriodo.Checked = true;
            this.rdbPeriodo.Location = new System.Drawing.Point(8, 18);
            this.rdbPeriodo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdbPeriodo.Name = "rdbPeriodo";
            this.rdbPeriodo.Size = new System.Drawing.Size(62, 17);
            this.rdbPeriodo.TabIndex = 2;
            this.rdbPeriodo.TabStop = true;
            this.rdbPeriodo.Text = "Período";
            this.rdbPeriodo.UseVisualStyleBackColor = true;
            // 
            // lblSlecioneCancelamento
            // 
            this.lblSlecioneCancelamento.AutoSize = true;
            this.lblSlecioneCancelamento.Location = new System.Drawing.Point(6, 16);
            this.lblSlecioneCancelamento.Name = "lblSlecioneCancelamento";
            this.lblSlecioneCancelamento.Size = new System.Drawing.Size(236, 13);
            this.lblSlecioneCancelamento.TabIndex = 9;
            this.lblSlecioneCancelamento.Text = "Selecione o produto que deseja cancelar a venda:";
            // 
            // cmbSelecioneCancelamento
            // 
            this.cmbSelecioneCancelamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelecioneCancelamento.FormattingEnabled = true;
            this.cmbSelecioneCancelamento.Location = new System.Drawing.Point(9, 32);
            this.cmbSelecioneCancelamento.Name = "cmbSelecioneCancelamento";
            this.cmbSelecioneCancelamento.Size = new System.Drawing.Size(295, 21);
            this.cmbSelecioneCancelamento.TabIndex = 10;
            // 
            // lblExemploCancelar
            // 
            this.lblExemploCancelar.AutoSize = true;
            this.lblExemploCancelar.Location = new System.Drawing.Point(302, 35);
            this.lblExemploCancelar.Name = "lblExemploCancelar";
            this.lblExemploCancelar.Size = new System.Drawing.Size(74, 13);
            this.lblExemploCancelar.TabIndex = 11;
            this.lblExemploCancelar.Text = "Ex: Xbox 360";
            // 
            // btnPesquisarCancelar
            // 
            this.btnPesquisarCancelar.Location = new System.Drawing.Point(381, 30);
            this.btnPesquisarCancelar.Name = "btnPesquisarCancelar";
            this.btnPesquisarCancelar.Size = new System.Drawing.Size(94, 22);
            this.btnPesquisarCancelar.TabIndex = 12;
            this.btnPesquisarCancelar.Text = "Pesquisar";
            this.btnPesquisarCancelar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Quantidade:";
            // 
            // cmbQuantiCancelar
            // 
            this.cmbQuantiCancelar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQuantiCancelar.FormattingEnabled = true;
            this.cmbQuantiCancelar.Location = new System.Drawing.Point(66, 58);
            this.cmbQuantiCancelar.Name = "cmbQuantiCancelar";
            this.cmbQuantiCancelar.Size = new System.Drawing.Size(153, 21);
            this.cmbQuantiCancelar.TabIndex = 14;
            // 
            // lblPrecoCancelar
            // 
            this.lblPrecoCancelar.AutoSize = true;
            this.lblPrecoCancelar.Location = new System.Drawing.Point(225, 61);
            this.lblPrecoCancelar.Name = "lblPrecoCancelar";
            this.lblPrecoCancelar.Size = new System.Drawing.Size(79, 13);
            this.lblPrecoCancelar.TabIndex = 15;
            this.lblPrecoCancelar.Text = "Preço Unitário:";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(305, 58);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 21);
            this.textBox1.TabIndex = 16;
            // 
            // btnLimparCancelar
            // 
            this.btnLimparCancelar.Location = new System.Drawing.Point(228, 90);
            this.btnLimparCancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLimparCancelar.Name = "btnLimparCancelar";
            this.btnLimparCancelar.Size = new System.Drawing.Size(118, 23);
            this.btnLimparCancelar.TabIndex = 17;
            this.btnLimparCancelar.Text = "Limpar Campos";
            this.btnLimparCancelar.UseVisualStyleBackColor = true;
            // 
            // Frm_Venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 534);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Frm_Venda";
            this.Text = "Venda";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tbcVenda.ResumeLayout(false);
            this.tbpLancarVenda.ResumeLayout(false);
            this.tbpLancarVenda.PerformLayout();
            this.tbpCancelarVenda.ResumeLayout(false);
            this.tbpCancelarVenda.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSelecioneProduto;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label lblExemplo;
        private System.Windows.Forms.ComboBox cmbSelecioneProduto;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.ComboBox cmbQuantidade;
        private System.Windows.Forms.Label lblPrecoUnitario;
        private System.Windows.Forms.Button btnCancelarVenda;
        private System.Windows.Forms.Button btnLancarVenda;
        private System.Windows.Forms.Button btnLimparCampos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbCliente;
        private System.Windows.Forms.RadioButton rdbPeriodo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.ComboBox cmbSituacao;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnEmitirRelatorio;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TabControl tbcVenda;
        private System.Windows.Forms.TabPage tbpLancarVenda;
        private System.Windows.Forms.TabPage tbpCancelarVenda;
        private System.Windows.Forms.Button btnLimparCancelar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblPrecoCancelar;
        private System.Windows.Forms.ComboBox cmbQuantiCancelar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbSelecioneCancelamento;
        private System.Windows.Forms.Button btnPesquisarCancelar;
        private System.Windows.Forms.Label lblExemploCancelar;
        private System.Windows.Forms.Label lblSlecioneCancelamento;
    }
}