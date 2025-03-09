using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paginaCamisas
{
    public partial class Camisas: Form
    {
        public Camisas()
        {
            InitializeComponent();

        }
        private void pictureBox4_Click(object sender, EventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void pictureBox2_Click(object sender, EventArgs e) { }
        private void pictureBox3_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void pictureBox2_Click_1(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void pictureBox4_Click_1(object sender, EventArgs e) { }
        private void panel2_Paint(object sender, PaintEventArgs e) { }
        private void pictureBox1_Click_1(object sender, EventArgs e) { }
        private void panel3_Paint(object sender, PaintEventArgs e) { }
        private void panel4_Paint(object sender, PaintEventArgs e) { }
        private void label9_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void label9_Click_1(object sender, EventArgs e) { }

        private void AjustarScrollBar()
        {
            
            vScrollBar1.Minimum = 0;
            vScrollBar1.Maximum =  panel5.Height; // Altura do conteúdo - área visível
            vScrollBar1.LargeChange = panel5.Height / 2; // Define um salto razoável ao rolar
            vScrollBar1.SmallChange = 10; // Pequenos incrementos
             
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            panel5.AutoScroll = true;
            AjustarScrollBar();
            panel5.Top = -e.NewValue;
           
            
        }

        private void panel5_Paint(object sender, PaintEventArgs e) { }
        private void button3_Click(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e) { }
        private void button4_Click(object sender, EventArgs e) { }
        private void button2_Click(object sender, EventArgs e) { }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
          carrinho.Click +=
        }
    }
}
