
namespace Lujinha.WF
{
    partial class FormVendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVendas));
            this.label11 = new System.Windows.Forms.Label();
            this.txtProdutosOutros = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.listProduto = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOutroValorUnitario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listValorUnitario = new System.Windows.Forms.ListBox();
            this.txtOutrasQuantidadesPecas = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAdicionarProdutos = new System.Windows.Forms.Button();
            this.btnLimparProdutos = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.listResumoPedido = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.radioDebito = new System.Windows.Forms.RadioButton();
            this.radioDinheiro = new System.Windows.Forms.RadioButton();
            this.label15 = new System.Windows.Forms.Label();
            this.radioCredito = new System.Windows.Forms.RadioButton();
            this.txtOutrasFormasPagamento = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnCancelarCompra = new System.Windows.Forms.Button();
            this.btnSalvarCompra = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listQuantidadeItens = new System.Windows.Forms.ListBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.labelValorTotal = new System.Windows.Forms.Label();
            this.listResumoValorTotal = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(18)))), ((int)(((byte)(12)))));
            this.label11.Location = new System.Drawing.Point(1, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 22);
            this.label11.TabIndex = 38;
            this.label11.Text = "*";
            // 
            // txtProdutosOutros
            // 
            this.txtProdutosOutros.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProdutosOutros.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdutosOutros.Location = new System.Drawing.Point(91, 208);
            this.txtProdutosOutros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProdutosOutros.Name = "txtProdutosOutros";
            this.txtProdutosOutros.Size = new System.Drawing.Size(129, 23);
            this.txtProdutosOutros.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(26, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 32;
            this.label3.Text = "Produto:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(26, 209);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(63, 18);
            this.lblNome.TabIndex = 34;
            this.lblNome.Text = "Outros: ";
            // 
            // listProduto
            // 
            this.listProduto.Font = new System.Drawing.Font("Consolas", 12F);
            this.listProduto.FormattingEnabled = true;
            this.listProduto.ItemHeight = 19;
            this.listProduto.Items.AddRange(new object[] {
            "Camiseta",
            "Calca",
            "Bermuda",
            "Vestido",
            "Acessorio"});
            this.listProduto.Location = new System.Drawing.Point(100, 35);
            this.listProduto.Name = "listProduto";
            this.listProduto.Size = new System.Drawing.Size(120, 156);
            this.listProduto.TabIndex = 41;
            this.listProduto.SelectedIndexChanged += new System.EventHandler(this.listProduto_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 283);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(787, 10);
            this.panel1.TabIndex = 42;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(245, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 292);
            this.panel2.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(18)))), ((int)(((byte)(12)))));
            this.label1.Location = new System.Drawing.Point(259, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 22);
            this.label1.TabIndex = 46;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(284, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 18);
            this.label2.TabIndex = 44;
            this.label2.Text = "Valor Unitario:";
            // 
            // txtOutroValorUnitario
            // 
            this.txtOutroValorUnitario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtOutroValorUnitario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutroValorUnitario.Location = new System.Drawing.Point(402, 204);
            this.txtOutroValorUnitario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOutroValorUnitario.Name = "txtOutroValorUnitario";
            this.txtOutroValorUnitario.Size = new System.Drawing.Size(120, 23);
            this.txtOutroValorUnitario.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(284, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 18);
            this.label5.TabIndex = 47;
            this.label5.Text = "Outros Valores:";
            // 
            // listValorUnitario
            // 
            this.listValorUnitario.Font = new System.Drawing.Font("Consolas", 12F);
            this.listValorUnitario.FormattingEnabled = true;
            this.listValorUnitario.ItemHeight = 19;
            this.listValorUnitario.Items.AddRange(new object[] {
            "20 R$",
            "25 R$",
            "30 R$",
            "35 R$",
            "40 R$",
            "45 R$",
            "50 R$",
            "60 R$",
            "70 R$",
            "80 R$",
            ""});
            this.listValorUnitario.Location = new System.Drawing.Point(402, 35);
            this.listValorUnitario.Name = "listValorUnitario";
            this.listValorUnitario.Size = new System.Drawing.Size(120, 156);
            this.listValorUnitario.TabIndex = 50;
            this.listValorUnitario.SelectedIndexChanged += new System.EventHandler(this.listValorUnitario_SelectedIndexChanged);
            // 
            // txtOutrasQuantidadesPecas
            // 
            this.txtOutrasQuantidadesPecas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtOutrasQuantidadesPecas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutrasQuantidadesPecas.Location = new System.Drawing.Point(699, 149);
            this.txtOutrasQuantidadesPecas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOutrasQuantidadesPecas.Name = "txtOutrasQuantidadesPecas";
            this.txtOutrasQuantidadesPecas.Size = new System.Drawing.Size(37, 23);
            this.txtOutrasQuantidadesPecas.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(606, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 18);
            this.label7.TabIndex = 51;
            this.label7.Text = "Qtd Peças:";
            // 
            // btnAdicionarProdutos
            // 
            this.btnAdicionarProdutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnAdicionarProdutos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionarProdutos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAdicionarProdutos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAdicionarProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarProdutos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarProdutos.ForeColor = System.Drawing.Color.White;
            this.btnAdicionarProdutos.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionarProdutos.Image")));
            this.btnAdicionarProdutos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionarProdutos.Location = new System.Drawing.Point(603, 242);
            this.btnAdicionarProdutos.Margin = new System.Windows.Forms.Padding(1);
            this.btnAdicionarProdutos.Name = "btnAdicionarProdutos";
            this.btnAdicionarProdutos.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnAdicionarProdutos.Size = new System.Drawing.Size(142, 37);
            this.btnAdicionarProdutos.TabIndex = 54;
            this.btnAdicionarProdutos.Text = "  Adicionar";
            this.btnAdicionarProdutos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionarProdutos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdicionarProdutos.UseVisualStyleBackColor = false;
            this.btnAdicionarProdutos.Click += new System.EventHandler(this.btnAdicionarProdutos_Click);
            // 
            // btnLimparProdutos
            // 
            this.btnLimparProdutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnLimparProdutos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimparProdutos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnLimparProdutos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnLimparProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparProdutos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparProdutos.ForeColor = System.Drawing.Color.White;
            this.btnLimparProdutos.Image = ((System.Drawing.Image)(resources.GetObject("btnLimparProdutos.Image")));
            this.btnLimparProdutos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimparProdutos.Location = new System.Drawing.Point(603, 194);
            this.btnLimparProdutos.Margin = new System.Windows.Forms.Padding(1);
            this.btnLimparProdutos.Name = "btnLimparProdutos";
            this.btnLimparProdutos.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnLimparProdutos.Size = new System.Drawing.Size(142, 40);
            this.btnLimparProdutos.TabIndex = 55;
            this.btnLimparProdutos.Text = "  Limpar";
            this.btnLimparProdutos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimparProdutos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimparProdutos.UseVisualStyleBackColor = false;
            this.btnLimparProdutos.Click += new System.EventHandler(this.btnLimparProdutos_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(21, 323);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 18);
            this.label8.TabIndex = 56;
            this.label8.Text = "Resumo de Pedido: ";
            // 
            // listResumoPedido
            // 
            this.listResumoPedido.Font = new System.Drawing.Font("Consolas", 12F);
            this.listResumoPedido.FormattingEnabled = true;
            this.listResumoPedido.ItemHeight = 19;
            this.listResumoPedido.Location = new System.Drawing.Point(24, 365);
            this.listResumoPedido.Name = "listResumoPedido";
            this.listResumoPedido.Size = new System.Drawing.Size(429, 80);
            this.listResumoPedido.TabIndex = 57;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(36, 346);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 16);
            this.label9.TabIndex = 58;
            this.label9.Text = "Produto";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(227, 346);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 16);
            this.label10.TabIndex = 59;
            this.label10.Text = "Preço";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(336, 346);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 16);
            this.label13.TabIndex = 60;
            this.label13.Text = "Quantidade Peças";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(531, 346);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 16);
            this.label14.TabIndex = 61;
            this.label14.Text = "Valor";
            // 
            // radioDebito
            // 
            this.radioDebito.AutoSize = true;
            this.radioDebito.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioDebito.ForeColor = System.Drawing.Color.White;
            this.radioDebito.Location = new System.Drawing.Point(223, 462);
            this.radioDebito.Name = "radioDebito";
            this.radioDebito.Size = new System.Drawing.Size(75, 22);
            this.radioDebito.TabIndex = 64;
            this.radioDebito.TabStop = true;
            this.radioDebito.Text = "Debito";
            this.radioDebito.UseVisualStyleBackColor = true;
            // 
            // radioDinheiro
            // 
            this.radioDinheiro.AutoSize = true;
            this.radioDinheiro.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioDinheiro.ForeColor = System.Drawing.Color.White;
            this.radioDinheiro.Location = new System.Drawing.Point(132, 461);
            this.radioDinheiro.Name = "radioDinheiro";
            this.radioDinheiro.Size = new System.Drawing.Size(88, 22);
            this.radioDinheiro.TabIndex = 63;
            this.radioDinheiro.TabStop = true;
            this.radioDinheiro.Text = "Dinheiro";
            this.radioDinheiro.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(15, 512);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 18);
            this.label15.TabIndex = 62;
            this.label15.Text = "Pagamento:";
            // 
            // radioCredito
            // 
            this.radioCredito.AutoSize = true;
            this.radioCredito.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioCredito.ForeColor = System.Drawing.Color.White;
            this.radioCredito.Location = new System.Drawing.Point(131, 511);
            this.radioCredito.Name = "radioCredito";
            this.radioCredito.Size = new System.Drawing.Size(81, 22);
            this.radioCredito.TabIndex = 66;
            this.radioCredito.TabStop = true;
            this.radioCredito.Text = "Crédito";
            this.radioCredito.UseVisualStyleBackColor = true;
            // 
            // txtOutrasFormasPagamento
            // 
            this.txtOutrasFormasPagamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtOutrasFormasPagamento.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutrasFormasPagamento.Location = new System.Drawing.Point(287, 511);
            this.txtOutrasFormasPagamento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOutrasFormasPagamento.Name = "txtOutrasFormasPagamento";
            this.txtOutrasFormasPagamento.Size = new System.Drawing.Size(97, 23);
            this.txtOutrasFormasPagamento.TabIndex = 68;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(218, 513);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(63, 18);
            this.label17.TabIndex = 67;
            this.label17.Text = "Outros: ";
            // 
            // btnCancelarCompra
            // 
            this.btnCancelarCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnCancelarCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarCompra.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnCancelarCompra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnCancelarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarCompra.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarCompra.ForeColor = System.Drawing.Color.White;
            this.btnCancelarCompra.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarCompra.Image")));
            this.btnCancelarCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarCompra.Location = new System.Drawing.Point(505, 507);
            this.btnCancelarCompra.Margin = new System.Windows.Forms.Padding(1);
            this.btnCancelarCompra.Name = "btnCancelarCompra";
            this.btnCancelarCompra.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnCancelarCompra.Size = new System.Drawing.Size(71, 29);
            this.btnCancelarCompra.TabIndex = 70;
            this.btnCancelarCompra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarCompra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelarCompra.UseVisualStyleBackColor = false;
            // 
            // btnSalvarCompra
            // 
            this.btnSalvarCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnSalvarCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvarCompra.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSalvarCompra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSalvarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarCompra.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarCompra.ForeColor = System.Drawing.Color.White;
            this.btnSalvarCompra.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvarCompra.Image")));
            this.btnSalvarCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarCompra.Location = new System.Drawing.Point(701, 508);
            this.btnSalvarCompra.Margin = new System.Windows.Forms.Padding(1);
            this.btnSalvarCompra.Name = "btnSalvarCompra";
            this.btnSalvarCompra.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnSalvarCompra.Size = new System.Drawing.Size(71, 29);
            this.btnSalvarCompra.TabIndex = 69;
            this.btnSalvarCompra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarCompra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvarCompra.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(566, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 292);
            this.panel3.TabIndex = 44;
            // 
            // listQuantidadeItens
            // 
            this.listQuantidadeItens.Font = new System.Drawing.Font("Consolas", 12F);
            this.listQuantidadeItens.FormattingEnabled = true;
            this.listQuantidadeItens.ItemHeight = 19;
            this.listQuantidadeItens.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.listQuantidadeItens.Location = new System.Drawing.Point(652, 23);
            this.listQuantidadeItens.Name = "listQuantidadeItens";
            this.listQuantidadeItens.Size = new System.Drawing.Size(84, 99);
            this.listQuantidadeItens.TabIndex = 73;
            this.listQuantidadeItens.SelectedIndexChanged += new System.EventHandler(this.listQuantidadeItens_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(18)))), ((int)(((byte)(12)))));
            this.label16.Location = new System.Drawing.Point(575, 23);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(19, 22);
            this.label16.TabIndex = 72;
            this.label16.Text = "*";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(600, 23);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(39, 18);
            this.label18.TabIndex = 71;
            this.label18.Text = "Qtd:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(584, 461);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(90, 18);
            this.label19.TabIndex = 74;
            this.label19.Text = "Valor Total:";
            // 
            // labelValorTotal
            // 
            this.labelValorTotal.AutoSize = true;
            this.labelValorTotal.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValorTotal.ForeColor = System.Drawing.Color.White;
            this.labelValorTotal.Location = new System.Drawing.Point(687, 461);
            this.labelValorTotal.Name = "labelValorTotal";
            this.labelValorTotal.Size = new System.Drawing.Size(57, 18);
            this.labelValorTotal.TabIndex = 75;
            this.labelValorTotal.Text = "0,00 R$";
            // 
            // listResumoValorTotal
            // 
            this.listResumoValorTotal.Font = new System.Drawing.Font("Consolas", 12F);
            this.listResumoValorTotal.FormattingEnabled = true;
            this.listResumoValorTotal.ItemHeight = 19;
            this.listResumoValorTotal.Location = new System.Drawing.Point(499, 365);
            this.listResumoValorTotal.Name = "listResumoValorTotal";
            this.listResumoValorTotal.Size = new System.Drawing.Size(101, 80);
            this.listResumoValorTotal.TabIndex = 76;
            // 
            // FormVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.listResumoValorTotal);
            this.Controls.Add(this.labelValorTotal);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.listQuantidadeItens);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnCancelarCompra);
            this.Controls.Add(this.btnSalvarCompra);
            this.Controls.Add(this.txtOutrasFormasPagamento);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.radioCredito);
            this.Controls.Add(this.radioDebito);
            this.Controls.Add(this.radioDinheiro);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.listResumoPedido);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnLimparProdutos);
            this.Controls.Add(this.btnAdicionarProdutos);
            this.Controls.Add(this.txtOutrasQuantidadesPecas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listValorUnitario);
            this.Controls.Add(this.txtOutroValorUnitario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listProduto);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtProdutosOutros);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNome);
            this.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.Name = "FormVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormVendas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtProdutosOutros;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.ListBox listProduto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOutroValorUnitario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listValorUnitario;
        private System.Windows.Forms.TextBox txtOutrasQuantidadesPecas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAdicionarProdutos;
        private System.Windows.Forms.Button btnLimparProdutos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listResumoPedido;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RadioButton radioDebito;
        private System.Windows.Forms.RadioButton radioDinheiro;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RadioButton radioCredito;
        private System.Windows.Forms.TextBox txtOutrasFormasPagamento;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnCancelarCompra;
        private System.Windows.Forms.Button btnSalvarCompra;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox listQuantidadeItens;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label labelValorTotal;
        private System.Windows.Forms.ListBox listResumoValorTotal;
    }
}