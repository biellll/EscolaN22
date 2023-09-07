namespace Escola_POO_BASE.Telas
{
    partial class TelaPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.SspRodape = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.TslNomeUserLogado = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.TslEmailUserLogado = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.TslPerfilUserLogado = new System.Windows.Forms.ToolStripStatusLabel();
            this.TslDataHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TsiAlterarSenha = new System.Windows.Forms.ToolStripMenuItem();
            this.TsiCadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.TsiCadastraAluno = new System.Windows.Forms.ToolStripMenuItem();
            this.TmrRelogio = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblAlunosRemovidos = new System.Windows.Forms.Label();
            this.LblAlunosAtivos = new System.Windows.Forms.Label();
            this.LblQtdAlunos = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SspRodape.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SspRodape
            // 
            this.SspRodape.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SspRodape.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.TslNomeUserLogado,
            this.toolStripStatusLabel3,
            this.TslEmailUserLogado,
            this.toolStripStatusLabel2,
            this.TslPerfilUserLogado,
            this.TslDataHora});
            this.SspRodape.Location = new System.Drawing.Point(0, 562);
            this.SspRodape.Name = "SspRodape";
            this.SspRodape.Size = new System.Drawing.Size(1014, 35);
            this.SspRodape.TabIndex = 1;
            this.SspRodape.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(163, 30);
            this.toolStripStatusLabel1.Text = "Usuário Logado:";
            // 
            // TslNomeUserLogado
            // 
            this.TslNomeUserLogado.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TslNomeUserLogado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TslNomeUserLogado.Name = "TslNomeUserLogado";
            this.TslNomeUserLogado.Size = new System.Drawing.Size(102, 30);
            this.TslNomeUserLogado.Text = "Joaquina";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(76, 30);
            this.toolStripStatusLabel3.Text = "E-mail:";
            // 
            // TslEmailUserLogado
            // 
            this.TslEmailUserLogado.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TslEmailUserLogado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TslEmailUserLogado.Name = "TslEmailUserLogado";
            this.TslEmailUserLogado.Size = new System.Drawing.Size(222, 30);
            this.TslEmailUserLogado.Text = "joaquina@gmail.com";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(64, 30);
            this.toolStripStatusLabel2.Text = "Perfil:";
            // 
            // TslPerfilUserLogado
            // 
            this.TslPerfilUserLogado.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TslPerfilUserLogado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TslPerfilUserLogado.Name = "TslPerfilUserLogado";
            this.TslPerfilUserLogado.Size = new System.Drawing.Size(73, 30);
            this.TslPerfilUserLogado.Text = "Aluno";
            // 
            // TslDataHora
            // 
            this.TslDataHora.Name = "TslDataHora";
            this.TslDataHora.Size = new System.Drawing.Size(299, 30);
            this.TslDataHora.Spring = true;
            this.TslDataHora.Text = "10/10/2010 10:10";
            this.TslDataHora.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.TsiCadastros});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1014, 38);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsiAlterarSenha});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(97, 34);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // TsiAlterarSenha
            // 
            this.TsiAlterarSenha.Name = "TsiAlterarSenha";
            this.TsiAlterarSenha.Size = new System.Drawing.Size(211, 34);
            this.TsiAlterarSenha.Text = "Alterar Senha";
            this.TsiAlterarSenha.Click += new System.EventHandler(this.TsiAlterarSenha_Click);
            // 
            // TsiCadastros
            // 
            this.TsiCadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsiCadastraAluno});
            this.TsiCadastros.Name = "TsiCadastros";
            this.TsiCadastros.Size = new System.Drawing.Size(116, 34);
            this.TsiCadastros.Text = "Cadastros";
            // 
            // TsiCadastraAluno
            // 
            this.TsiCadastraAluno.Name = "TsiCadastraAluno";
            this.TsiCadastraAluno.Size = new System.Drawing.Size(141, 34);
            this.TsiCadastraAluno.Text = "Aluno";
            this.TsiCadastraAluno.Click += new System.EventHandler(this.TsiCadastraAluno_Click);
            // 
            // TmrRelogio
            // 
            this.TmrRelogio.Tick += new System.EventHandler(this.TmrRelogio_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LblAlunosRemovidos);
            this.panel1.Controls.Add(this.LblAlunosAtivos);
            this.panel1.Controls.Add(this.LblQtdAlunos);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 524);
            this.panel1.TabIndex = 4;
            // 
            // LblAlunosRemovidos
            // 
            this.LblAlunosRemovidos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblAlunosRemovidos.Location = new System.Drawing.Point(69, 308);
            this.LblAlunosRemovidos.Name = "LblAlunosRemovidos";
            this.LblAlunosRemovidos.Size = new System.Drawing.Size(78, 41);
            this.LblAlunosRemovidos.TabIndex = 5;
            // 
            // LblAlunosAtivos
            // 
            this.LblAlunosAtivos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblAlunosAtivos.Location = new System.Drawing.Point(69, 177);
            this.LblAlunosAtivos.Name = "LblAlunosAtivos";
            this.LblAlunosAtivos.Size = new System.Drawing.Size(78, 40);
            this.LblAlunosAtivos.TabIndex = 4;
            // 
            // LblQtdAlunos
            // 
            this.LblQtdAlunos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblQtdAlunos.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblQtdAlunos.Location = new System.Drawing.Point(69, 61);
            this.LblQtdAlunos.Name = "LblQtdAlunos";
            this.LblQtdAlunos.Size = new System.Drawing.Size(78, 37);
            this.LblQtdAlunos.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Alunos Removidos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Alunos ativos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quantidade de alunos:";
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 597);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SspRodape);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "TelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaPrincipal";
            this.Load += new System.EventHandler(this.TelaPrincipal_Load);
            this.SspRodape.ResumeLayout(false);
            this.SspRodape.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip SspRodape;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel TslNomeUserLogado;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel TslEmailUserLogado;
        private System.Windows.Forms.ToolStripStatusLabel TslDataHora;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TsiAlterarSenha;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel TslPerfilUserLogado;
        private System.Windows.Forms.ToolStripMenuItem TsiCadastros;
        private System.Windows.Forms.ToolStripMenuItem TsiCadastraAluno;
        private System.Windows.Forms.Timer TmrRelogio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblQtdAlunos;
        private System.Windows.Forms.Label LblAlunosRemovidos;
        private System.Windows.Forms.Label LblAlunosAtivos;
    }
}