namespace CursoWindowsForms
{
    partial class Frm_ValidaCPF_2
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
            Msk_CPF = new MaskedTextBox();
            Btn_Reset = new Button();
            Btn_Valida = new Button();
            SuspendLayout();
            // 
            // Msk_CPF
            // 
            Msk_CPF.Location = new Point(17, 75);
            Msk_CPF.Margin = new Padding(4, 5, 4, 5);
            Msk_CPF.Mask = "000,000,000-00";
            Msk_CPF.Name = "Msk_CPF";
            Msk_CPF.Size = new Size(310, 31);
            Msk_CPF.TabIndex = 0;
            // 
            // Btn_Reset
            // 
            Btn_Reset.Location = new Point(350, 70);
            Btn_Reset.Margin = new Padding(4, 5, 4, 5);
            Btn_Reset.Name = "Btn_Reset";
            Btn_Reset.Size = new Size(159, 38);
            Btn_Reset.TabIndex = 2;
            Btn_Reset.Text = "Limpa";
            Btn_Reset.UseVisualStyleBackColor = true;
            Btn_Reset.Click += Btn_Reset_Click;
            // 
            // Btn_Valida
            // 
            Btn_Valida.Location = new Point(350, 118);
            Btn_Valida.Margin = new Padding(4, 5, 4, 5);
            Btn_Valida.Name = "Btn_Valida";
            Btn_Valida.Size = new Size(159, 38);
            Btn_Valida.TabIndex = 3;
            Btn_Valida.Text = "Valida";
            Btn_Valida.UseVisualStyleBackColor = true;
            Btn_Valida.Click += Btn_Valida_Click;
            // 
            // Frm_ValidaCPF_2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 257);
            Controls.Add(Btn_Valida);
            Controls.Add(Btn_Reset);
            Controls.Add(Msk_CPF);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Frm_ValidaCPF_2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Validação CPF";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox Msk_CPF;
        private Button Btn_Reset;
        private Button Btn_Valida;
    }
}
