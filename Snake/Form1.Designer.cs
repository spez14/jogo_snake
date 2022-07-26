namespace Snake
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PnTela = new System.Windows.Forms.Panel();
            this.LbPontuacao = new System.Windows.Forms.Label();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciarJogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Frame = new System.Windows.Forms.Timer(this.components);
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnTela
            // 
            this.PnTela.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PnTela.Location = new System.Drawing.Point(8, 66);
            this.PnTela.Name = "PnTela";
            this.PnTela.Size = new System.Drawing.Size(428, 428);
            this.PnTela.TabIndex = 0;
            // 
            // LbPontuacao
            // 
            this.LbPontuacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbPontuacao.Location = new System.Drawing.Point(8, 25);
            this.LbPontuacao.Name = "LbPontuacao";
            this.LbPontuacao.Size = new System.Drawing.Size(428, 38);
            this.LbPontuacao.TabIndex = 1;
            this.LbPontuacao.Text = "PONTOS: 0";
            this.LbPontuacao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(441, 24);
            this.Menu.TabIndex = 2;
            this.Menu.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iniciarJogoToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // iniciarJogoToolStripMenuItem
            // 
            this.iniciarJogoToolStripMenuItem.Name = "iniciarJogoToolStripMenuItem";
            this.iniciarJogoToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.iniciarJogoToolStripMenuItem.Text = "Iniciar jogo";
            this.iniciarJogoToolStripMenuItem.Click += new System.EventHandler(this.iniciarJogoToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // Frame
            // 
            this.Frame.Tick += new System.EventHandler(this.Frame_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 498);
            this.Controls.Add(this.LbPontuacao);
            this.Controls.Add(this.PnTela);
            this.Controls.Add(this.Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Menu;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Clicado);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel PnTela;
        private Label LbPontuacao;
        private MenuStrip Menu;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem iniciarJogoToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Timer Frame;
    }
}