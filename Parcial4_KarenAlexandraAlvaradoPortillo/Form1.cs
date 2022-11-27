using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parcial
{
    public partial class PARCIAL : Form
    {
        public PARCIAL()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            boton3 goToBill = new boton3();
            goToBill.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            boton7 goToBill = new boton7();
            goToBill.Show();
        }

        private void PARCIAL_Load(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            boton5 goToBill = new boton5();
            goToBill.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            boton6 goToBill = new boton6();
            goToBill.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            boton8 goToBill = new boton8();
            goToBill.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            boton9 goToBill = new boton9();
            goToBill.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            boton10 goToBill = new boton10();
            goToBill.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            boton11 goToBill = new boton11();
            goToBill.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            boton12 goToBill = new boton12();
            goToBill.Show();
        }

        private void registro_Click(object sender, EventArgs e)
        {
            boton1 goToBill = new boton1();
            goToBill.Show();
        }

        private void clientes_Click(object sender, EventArgs e)
        {
            boton2 goToBill = new boton2();
            goToBill.Show();
        }

        private void categorias_Click(object sender, EventArgs e)
        {
            boton4 goToBill = new boton4();
            goToBill.Show();
        }
    }
}
