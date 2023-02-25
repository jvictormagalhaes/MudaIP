namespace MudaIP
{
    partial class FrmHome
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ChkGM = new System.Windows.Forms.CheckBox();
            this.ChkVW = new System.Windows.Forms.CheckBox();
            this.ChkNissan = new System.Windows.Forms.CheckBox();
            this.RbGEM = new System.Windows.Forms.RadioButton();
            this.RbOnix = new System.Windows.Forms.RadioButton();
            this.RbUP = new System.Windows.Forms.RadioButton();
            this.RbMQB = new System.Windows.Forms.RadioButton();
            this.RbFrontier = new System.Windows.Forms.RadioButton();
            this.RbVersa = new System.Windows.Forms.RadioButton();
            this.BtnSair = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 76);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(328, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Alteração IP";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Muda IP";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ChkGM
            // 
            this.ChkGM.Appearance = System.Windows.Forms.Appearance.Button;
            this.ChkGM.BackgroundImage = global::MudaIP.Properties.Resources.novo_logo_gm_png_1024x1024;
            this.ChkGM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ChkGM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChkGM.FlatAppearance.BorderSize = 0;
            this.ChkGM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChkGM.Location = new System.Drawing.Point(81, 162);
            this.ChkGM.Name = "ChkGM";
            this.ChkGM.Size = new System.Drawing.Size(104, 94);
            this.ChkGM.TabIndex = 1;
            this.ChkGM.UseVisualStyleBackColor = true;
            this.ChkGM.CheckedChanged += new System.EventHandler(this.CbGM_CheckedChanged);
            // 
            // ChkVW
            // 
            this.ChkVW.Appearance = System.Windows.Forms.Appearance.Button;
            this.ChkVW.BackgroundImage = global::MudaIP.Properties.Resources.volkswagen_vw_logo_1;
            this.ChkVW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ChkVW.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChkVW.FlatAppearance.BorderSize = 0;
            this.ChkVW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChkVW.Location = new System.Drawing.Point(341, 162);
            this.ChkVW.Name = "ChkVW";
            this.ChkVW.Size = new System.Drawing.Size(104, 94);
            this.ChkVW.TabIndex = 2;
            this.ChkVW.UseVisualStyleBackColor = true;
            this.ChkVW.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // ChkNissan
            // 
            this.ChkNissan.Appearance = System.Windows.Forms.Appearance.Button;
            this.ChkNissan.BackgroundImage = global::MudaIP.Properties.Resources.nissan_logo_1;
            this.ChkNissan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ChkNissan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChkNissan.FlatAppearance.BorderSize = 0;
            this.ChkNissan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChkNissan.Location = new System.Drawing.Point(590, 162);
            this.ChkNissan.Name = "ChkNissan";
            this.ChkNissan.Size = new System.Drawing.Size(117, 94);
            this.ChkNissan.TabIndex = 3;
            this.ChkNissan.UseVisualStyleBackColor = true;
            this.ChkNissan.CheckedChanged += new System.EventHandler(this.chkNissan_CheckedChanged);
            // 
            // RbGEM
            // 
            this.RbGEM.AutoSize = true;
            this.RbGEM.Location = new System.Drawing.Point(102, 262);
            this.RbGEM.Name = "RbGEM";
            this.RbGEM.Size = new System.Drawing.Size(58, 20);
            this.RbGEM.TabIndex = 4;
            this.RbGEM.TabStop = true;
            this.RbGEM.Text = "GEM";
            this.RbGEM.UseVisualStyleBackColor = true;
            this.RbGEM.Visible = false;
            this.RbGEM.CheckedChanged += new System.EventHandler(this.RbGEM_CheckedChanged);
            // 
            // RbOnix
            // 
            this.RbOnix.AutoSize = true;
            this.RbOnix.Location = new System.Drawing.Point(102, 288);
            this.RbOnix.Name = "RbOnix";
            this.RbOnix.Size = new System.Drawing.Size(54, 20);
            this.RbOnix.TabIndex = 5;
            this.RbOnix.TabStop = true;
            this.RbOnix.Text = "Onix";
            this.RbOnix.UseVisualStyleBackColor = true;
            this.RbOnix.Visible = false;
            // 
            // RbUP
            // 
            this.RbUP.AutoSize = true;
            this.RbUP.Location = new System.Drawing.Point(360, 288);
            this.RbUP.Name = "RbUP";
            this.RbUP.Size = new System.Drawing.Size(47, 20);
            this.RbUP.TabIndex = 7;
            this.RbUP.TabStop = true;
            this.RbUP.Text = "UP";
            this.RbUP.UseVisualStyleBackColor = true;
            this.RbUP.Visible = false;
            // 
            // RbMQB
            // 
            this.RbMQB.AutoSize = true;
            this.RbMQB.Location = new System.Drawing.Point(360, 262);
            this.RbMQB.Name = "RbMQB";
            this.RbMQB.Size = new System.Drawing.Size(58, 20);
            this.RbMQB.TabIndex = 6;
            this.RbMQB.TabStop = true;
            this.RbMQB.Text = "MQB";
            this.RbMQB.UseVisualStyleBackColor = true;
            this.RbMQB.Visible = false;
            // 
            // RbFrontier
            // 
            this.RbFrontier.AutoSize = true;
            this.RbFrontier.Location = new System.Drawing.Point(618, 288);
            this.RbFrontier.Name = "RbFrontier";
            this.RbFrontier.Size = new System.Drawing.Size(73, 20);
            this.RbFrontier.TabIndex = 9;
            this.RbFrontier.TabStop = true;
            this.RbFrontier.Text = "Frontier";
            this.RbFrontier.UseVisualStyleBackColor = true;
            this.RbFrontier.Visible = false;
            // 
            // RbVersa
            // 
            this.RbVersa.AutoSize = true;
            this.RbVersa.Location = new System.Drawing.Point(618, 262);
            this.RbVersa.Name = "RbVersa";
            this.RbVersa.Size = new System.Drawing.Size(64, 20);
            this.RbVersa.TabIndex = 8;
            this.RbVersa.TabStop = true;
            this.RbVersa.Text = "Versa";
            this.RbVersa.UseVisualStyleBackColor = true;
            this.RbVersa.Visible = false;
            // 
            // BtnSair
            // 
            this.BtnSair.Location = new System.Drawing.Point(343, 404);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(75, 34);
            this.BtnSair.TabIndex = 10;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.RbFrontier);
            this.Controls.Add(this.RbVersa);
            this.Controls.Add(this.RbUP);
            this.Controls.Add(this.RbMQB);
            this.Controls.Add(this.RbOnix);
            this.Controls.Add(this.RbGEM);
            this.Controls.Add(this.ChkNissan);
            this.Controls.Add(this.ChkVW);
            this.Controls.Add(this.ChkGM);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Muda IP";
            this.Load += new System.EventHandler(this.FrmMudaip_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ChkGM;
        private System.Windows.Forms.CheckBox ChkVW;
        private System.Windows.Forms.CheckBox ChkNissan;
        private System.Windows.Forms.RadioButton RbGEM;
        private System.Windows.Forms.RadioButton RbOnix;
        private System.Windows.Forms.RadioButton RbUP;
        private System.Windows.Forms.RadioButton RbMQB;
        private System.Windows.Forms.RadioButton RbFrontier;
        private System.Windows.Forms.RadioButton RbVersa;
        private System.Windows.Forms.Button BtnSair;
    }
}

