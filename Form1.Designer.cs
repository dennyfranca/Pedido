
namespace Pedido
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txbnome_produto = new System.Windows.Forms.TextBox();
            this.txbvalor = new System.Windows.Forms.TextBox();
            this.txbdata_vencimento = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnenviar = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.btnexibir = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txbnome_produto
            // 
            this.txbnome_produto.Location = new System.Drawing.Point(190, 81);
            this.txbnome_produto.Name = "txbnome_produto";
            this.txbnome_produto.Size = new System.Drawing.Size(100, 23);
            this.txbnome_produto.TabIndex = 0;
            // 
            // txbvalor
            // 
            this.txbvalor.Location = new System.Drawing.Point(190, 134);
            this.txbvalor.Name = "txbvalor";
            this.txbvalor.Size = new System.Drawing.Size(100, 23);
            this.txbvalor.TabIndex = 0;
            // 
            // txbdata_vencimento
            // 
            this.txbdata_vencimento.Location = new System.Drawing.Point(190, 186);
            this.txbdata_vencimento.Name = "txbdata_vencimento";
            this.txbdata_vencimento.Size = new System.Drawing.Size(100, 23);
            this.txbdata_vencimento.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(296, 303);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "nome_produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "valor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "data_vencimento";
            // 
            // btnenviar
            // 
            this.btnenviar.Location = new System.Drawing.Point(30, 12);
            this.btnenviar.Name = "btnenviar";
            this.btnenviar.Size = new System.Drawing.Size(75, 23);
            this.btnenviar.TabIndex = 3;
            this.btnenviar.Text = "Enviar";
            this.btnenviar.UseVisualStyleBackColor = true;
            this.btnenviar.Click += new System.EventHandler(this.btnenviar_Click);
            // 
            // btneditar
            // 
            this.btneditar.Location = new System.Drawing.Point(114, 12);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(75, 23);
            this.btneditar.TabIndex = 3;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = true;
            // 
            // btnsalvar
            // 
            this.btnsalvar.Location = new System.Drawing.Point(195, 12);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(75, 23);
            this.btnsalvar.TabIndex = 3;
            this.btnsalvar.Text = "Salvar";
            this.btnsalvar.UseVisualStyleBackColor = true;
            // 
            // btnexibir
            // 
            this.btnexibir.Location = new System.Drawing.Point(276, 12);
            this.btnexibir.Name = "btnexibir";
            this.btnexibir.Size = new System.Drawing.Size(75, 23);
            this.btnexibir.TabIndex = 3;
            this.btnexibir.Text = "exibir";
            this.btnexibir.UseVisualStyleBackColor = true;
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(357, 12);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 3;
            this.btndelete.Text = "delete";
            this.btndelete.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnexibir);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnenviar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txbdata_vencimento);
            this.Controls.Add(this.txbvalor);
            this.Controls.Add(this.txbnome_produto);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbnome_produto;
        private System.Windows.Forms.TextBox txbvalor;
        private System.Windows.Forms.TextBox txbdata_vencimento;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnenviar;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.Button btnexibir;
        private System.Windows.Forms.Button btndelete;
    }
}

