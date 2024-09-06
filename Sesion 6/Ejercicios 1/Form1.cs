using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            {
                agregar();
            }
        }

        private void agregar()

        {
            if (TBTitulo.Text.Trim().Length > 0)
            {
                string tiutlo = TBTitulo.Text.Trim();
                LbLibros.Items.Add(tiutlo);
                TBTitulo.Clear();
                TBTitulo.Focus();
            }
        }

        private void TBTitulo_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TBTitulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar== (char)Keys.Enter)
            {
                agregar();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btncopiar_Click(object sender, EventArgs e)
        {
            int cant = LbLibros.Items.Count; 
            for (int i=0; i < cant; i++)
                {
                string titulo = LbLibros.Items[i].ToString();
                lbcopia.Items.Add(titulo);
            }
        }

        private void btnmover_Click(object sender, EventArgs e)
        {
            if(LbLibros.Items.Count > 0)
            {
                string titulo = LbLibros.SelectedItem.ToString();
                lbcopia.Items.Add(titulo);
                int index = LbLibros.SelectedIndex;
                LbLibros.Items.RemoveAt(index);
            }
           
        }

        private void LbLibros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LbLibros.Items.Count > 0)
            {
                btnmover.Enabled = true;
            }
                
        }
    }
}
