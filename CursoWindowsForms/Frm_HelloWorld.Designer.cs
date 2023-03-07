namespace CursoWindowsForms
{
    partial class Frm_HelloWorld
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_HelloWorld));
            lbl_Titulo = new Label();
            SuspendLayout();
            // 
            // lbl_Titulo
            // 
            lbl_Titulo.AutoSize = true;
            lbl_Titulo.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Titulo.Location = new Point(30, 30);
            lbl_Titulo.Margin = new Padding(2, 0, 2, 0);
            lbl_Titulo.Name = "lbl_Titulo";
            lbl_Titulo.Size = new Size(213, 19);
            lbl_Titulo.TabIndex = 0;
            lbl_Titulo.Text = "Visual Studio .NET Version";
            // 
            // Frm_HelloWorld
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 312);
            Controls.Add(lbl_Titulo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Frm_HelloWorld";
            Text = "HelloWorld";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Titulo;
    }
}