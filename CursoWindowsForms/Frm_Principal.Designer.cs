namespace CursoWindowsForms
{
    partial class Frm_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal));
            Btn_DemonstracaoKey = new Button();
            Btn_HelloWorld = new Button();
            Btn_Mascara = new Button();
            Btn_ValidaCPF = new Button();
            Btn_ValidaCPF2 = new Button();
            Btn_ValidaSenha = new Button();
            SuspendLayout();
            // 
            // Btn_DemonstracaoKey
            // 
            Btn_DemonstracaoKey.Image = (Image)resources.GetObject("Btn_DemonstracaoKey.Image");
            Btn_DemonstracaoKey.Location = new Point(12, 12);
            Btn_DemonstracaoKey.Name = "Btn_DemonstracaoKey";
            Btn_DemonstracaoKey.Size = new Size(114, 48);
            Btn_DemonstracaoKey.TabIndex = 0;
            Btn_DemonstracaoKey.Text = "Demonstração Key";
            Btn_DemonstracaoKey.UseVisualStyleBackColor = true;
            Btn_DemonstracaoKey.Click += Btn_DemonstracaoKey_Click;
            // 
            // Btn_HelloWorld
            // 
            Btn_HelloWorld.Image = (Image)resources.GetObject("Btn_HelloWorld.Image");
            Btn_HelloWorld.Location = new Point(132, 12);
            Btn_HelloWorld.Name = "Btn_HelloWorld";
            Btn_HelloWorld.Size = new Size(114, 48);
            Btn_HelloWorld.TabIndex = 1;
            Btn_HelloWorld.Text = "Hello World";
            Btn_HelloWorld.UseVisualStyleBackColor = true;
            Btn_HelloWorld.Click += Btn_HelloWorld_Click;
            // 
            // Btn_Mascara
            // 
            Btn_Mascara.Image = (Image)resources.GetObject("Btn_Mascara.Image");
            Btn_Mascara.Location = new Point(252, 12);
            Btn_Mascara.Name = "Btn_Mascara";
            Btn_Mascara.Size = new Size(114, 48);
            Btn_Mascara.TabIndex = 2;
            Btn_Mascara.Text = "Máscara";
            Btn_Mascara.UseVisualStyleBackColor = true;
            Btn_Mascara.Click += Btn_Mascara_Click;
            // 
            // Btn_ValidaCPF
            // 
            Btn_ValidaCPF.Image = (Image)resources.GetObject("Btn_ValidaCPF.Image");
            Btn_ValidaCPF.Location = new Point(12, 66);
            Btn_ValidaCPF.Name = "Btn_ValidaCPF";
            Btn_ValidaCPF.Size = new Size(114, 48);
            Btn_ValidaCPF.TabIndex = 3;
            Btn_ValidaCPF.Text = "Valida CPF";
            Btn_ValidaCPF.UseVisualStyleBackColor = true;
            Btn_ValidaCPF.Click += Btn_ValidaCPF_Click;
            // 
            // Btn_ValidaCPF2
            // 
            Btn_ValidaCPF2.Image = (Image)resources.GetObject("Btn_ValidaCPF2.Image");
            Btn_ValidaCPF2.Location = new Point(132, 66);
            Btn_ValidaCPF2.Name = "Btn_ValidaCPF2";
            Btn_ValidaCPF2.Size = new Size(114, 48);
            Btn_ValidaCPF2.TabIndex = 4;
            Btn_ValidaCPF2.Text = "Valida CPF 2";
            Btn_ValidaCPF2.UseVisualStyleBackColor = true;
            Btn_ValidaCPF2.Click += Btn_ValidaCPF2_Click;
            // 
            // Btn_ValidaSenha
            // 
            Btn_ValidaSenha.Image = (Image)resources.GetObject("Btn_ValidaSenha.Image");
            Btn_ValidaSenha.Location = new Point(252, 66);
            Btn_ValidaSenha.Name = "Btn_ValidaSenha";
            Btn_ValidaSenha.Size = new Size(114, 48);
            Btn_ValidaSenha.TabIndex = 5;
            Btn_ValidaSenha.Text = "Valida Senha";
            Btn_ValidaSenha.UseVisualStyleBackColor = true;
            Btn_ValidaSenha.Click += Btn_ValidaSenha_Click;
            // 
            // Frm_Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 126);
            Controls.Add(Btn_ValidaSenha);
            Controls.Add(Btn_ValidaCPF2);
            Controls.Add(Btn_ValidaCPF);
            Controls.Add(Btn_Mascara);
            Controls.Add(Btn_HelloWorld);
            Controls.Add(Btn_DemonstracaoKey);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Frm_Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Principal";
            ResumeLayout(false);
        }

        #endregion

        private Button Btn_DemonstracaoKey;
        private Button Btn_HelloWorld;
        private Button Btn_Mascara;
        private Button Btn_ValidaCPF;
        private Button Btn_ValidaCPF2;
        private Button Btn_ValidaSenha;
    }
}