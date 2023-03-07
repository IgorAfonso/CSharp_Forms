﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_ValidaCPF_2 : Form
    {
        public Frm_ValidaCPF_2()
        {
            InitializeComponent();
        }

        private void Btn_Valida_Click(object sender, EventArgs e)
        {

            string vConteudo;
            vConteudo = Msk_CPF.Text;
            vConteudo = vConteudo.Replace(".", "").Replace("-", "");
            vConteudo = vConteudo.Trim();

            if(vConteudo == "") 
            {
                MessageBox.Show("Você deve digitar um CPF", "Mensagem de validação",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {

                if(vConteudo.Length != 11)
                {
                    MessageBox.Show("CPF deve ter 11 dígitos", "Mensagem de validação", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
                else 
                {
                    if (MessageBox.Show("Você deseja realmente validar o CPF?",
               "Mensagem de Validação", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        bool result;
                        result = Cls_Uteis.Valida(Msk_CPF.Text);

                        if (result == true)
                        {
                            MessageBox.Show("CPF Válido!",
                            "Mensagem de Validação", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("CPF Inválido!",
                            "Mensagem de Validação", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            Msk_CPF.Text = "";
        }
    }
}
