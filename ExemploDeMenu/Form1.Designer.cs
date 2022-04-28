
namespace ExemploDeMenu
{
    partial class Menu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cadastrar = new System.Windows.Forms.Button();
            this.consultar = new System.Windows.Forms.Button();
            this.atualizar = new System.Windows.Forms.Button();
            this.excluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cadastrar
            // 
            this.cadastrar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cadastrar.Location = new System.Drawing.Point(122, 105);
            this.cadastrar.Name = "cadastrar";
            this.cadastrar.Size = new System.Drawing.Size(104, 51);
            this.cadastrar.TabIndex = 5;
            this.cadastrar.Text = "Cadastrar";
            this.cadastrar.UseVisualStyleBackColor = false;
            this.cadastrar.Click += new System.EventHandler(this.cadastrar_Click);
            // 
            // consultar
            // 
            this.consultar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.consultar.Location = new System.Drawing.Point(122, 162);
            this.consultar.Name = "consultar";
            this.consultar.Size = new System.Drawing.Size(104, 53);
            this.consultar.TabIndex = 6;
            this.consultar.Text = "Consultar";
            this.consultar.UseVisualStyleBackColor = false;
            this.consultar.Click += new System.EventHandler(this.consultar_Click);
            // 
            // atualizar
            // 
            this.atualizar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.atualizar.Location = new System.Drawing.Point(122, 221);
            this.atualizar.Name = "atualizar";
            this.atualizar.Size = new System.Drawing.Size(104, 52);
            this.atualizar.TabIndex = 7;
            this.atualizar.Text = "Atualizar";
            this.atualizar.UseVisualStyleBackColor = false;
            this.atualizar.Click += new System.EventHandler(this.atualizar_Click);
            // 
            // excluir
            // 
            this.excluir.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.excluir.Location = new System.Drawing.Point(122, 279);
            this.excluir.Name = "excluir";
            this.excluir.Size = new System.Drawing.Size(104, 50);
            this.excluir.TabIndex = 8;
            this.excluir.Text = "Excluir";
            this.excluir.UseVisualStyleBackColor = false;
            this.excluir.Click += new System.EventHandler(this.excluir_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(337, 450);
            this.Controls.Add(this.excluir);
            this.Controls.Add(this.atualizar);
            this.Controls.Add(this.consultar);
            this.Controls.Add(this.cadastrar);
            this.Name = "Menu";
            this.Text = "Exemplo Menu";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button cadastrar;
        private System.Windows.Forms.Button consultar;
        private System.Windows.Forms.Button atualizar;
        private System.Windows.Forms.Button excluir;
    }
}

