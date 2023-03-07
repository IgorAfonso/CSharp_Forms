namespace CursoWindowsForms
{
    partial class Frm_DemonstracaoKey
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_DemonstracaoKey));
            Txt_Input = new TextBox();
            Txt_Msg = new TextBox();
            Btn_Reset = new Button();
            Lbl_Minus = new Label();
            Lbl_Maius = new Label();
            Lbl_Upper = new Label();
            Lbl_Lower = new Label();
            SuspendLayout();
            // 
            // Txt_Input
            // 
            Txt_Input.Location = new Point(8, 8);
            Txt_Input.Margin = new Padding(2);
            Txt_Input.Name = "Txt_Input";
            Txt_Input.Size = new Size(100, 23);
            Txt_Input.TabIndex = 0;
            Txt_Input.KeyDown += Txt_Input_KeyDown;
            // 
            // Txt_Msg
            // 
            Txt_Msg.Location = new Point(8, 40);
            Txt_Msg.Margin = new Padding(2);
            Txt_Msg.Multiline = true;
            Txt_Msg.Name = "Txt_Msg";
            Txt_Msg.ScrollBars = ScrollBars.Vertical;
            Txt_Msg.Size = new Size(304, 232);
            Txt_Msg.TabIndex = 1;
            Txt_Msg.TabStop = false;
            // 
            // Btn_Reset
            // 
            Btn_Reset.Location = new Point(328, 8);
            Btn_Reset.Margin = new Padding(2);
            Btn_Reset.Name = "Btn_Reset";
            Btn_Reset.Size = new Size(75, 28);
            Btn_Reset.TabIndex = 2;
            Btn_Reset.Text = "Limpa";
            Btn_Reset.UseVisualStyleBackColor = true;
            Btn_Reset.Click += Btn_Reset_Click;
            // 
            // Lbl_Minus
            // 
            Lbl_Minus.AutoSize = true;
            Lbl_Minus.Location = new Point(320, 104);
            Lbl_Minus.Margin = new Padding(2, 0, 2, 0);
            Lbl_Minus.Name = "Lbl_Minus";
            Lbl_Minus.Size = new Size(43, 15);
            Lbl_Minus.TabIndex = 3;
            Lbl_Minus.Text = "Minus.";
            // 
            // Lbl_Maius
            // 
            Lbl_Maius.AutoSize = true;
            Lbl_Maius.Location = new Point(320, 56);
            Lbl_Maius.Margin = new Padding(2, 0, 2, 0);
            Lbl_Maius.Name = "Lbl_Maius";
            Lbl_Maius.Size = new Size(39, 15);
            Lbl_Maius.TabIndex = 4;
            Lbl_Maius.Text = "Maius";
            // 
            // Lbl_Upper
            // 
            Lbl_Upper.BorderStyle = BorderStyle.Fixed3D;
            Lbl_Upper.Location = new Point(368, 56);
            Lbl_Upper.Margin = new Padding(2, 0, 2, 0);
            Lbl_Upper.Name = "Lbl_Upper";
            Lbl_Upper.Size = new Size(32, 23);
            Lbl_Upper.TabIndex = 5;
            // 
            // Lbl_Lower
            // 
            Lbl_Lower.BorderStyle = BorderStyle.Fixed3D;
            Lbl_Lower.Location = new Point(368, 104);
            Lbl_Lower.Margin = new Padding(2, 0, 2, 0);
            Lbl_Lower.Name = "Lbl_Lower";
            Lbl_Lower.Size = new Size(32, 23);
            Lbl_Lower.TabIndex = 6;
            // 
            // Frm_DemonstracaoKey
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 281);
            Controls.Add(Lbl_Lower);
            Controls.Add(Lbl_Upper);
            Controls.Add(Lbl_Maius);
            Controls.Add(Lbl_Minus);
            Controls.Add(Btn_Reset);
            Controls.Add(Txt_Msg);
            Controls.Add(Txt_Input);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "Frm_DemonstracaoKey";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Demonstração Evento Key";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Txt_Input;
        private TextBox Txt_Msg;
        private Button Btn_Reset;
        private Label Lbl_Minus;
        private Label Lbl_Maius;
        private Label Lbl_Upper;
        public Label Lbl_Lower;
    }
}