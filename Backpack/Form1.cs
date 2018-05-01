using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Backpack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            knife.Image = Image.FromFile(@"C:\Users\s178020\Documents\Visual Studio 2015\Projects\Backpack\Backpack\Properties\Backpack Images\knife.png") ;
            combatShot.Image = Image.FromFile(@"C:\Users\s178020\Documents\Visual Studio 2015\Projects\Backpack\Backpack\Properties\Backpack Images\combatshot.png");
            shield.Image = Image.FromFile(@"C:\Users\s178020\Documents\Visual Studio 2015\Projects\Backpack\Backpack\Properties\Backpack Images\shield.png");
            gun.Image = Image.FromFile(@"C:\Users\s178020\Documents\Visual Studio 2015\Projects\Backpack\Backpack\Properties\Backpack Images\gun.png");
            vest.Image = Image.FromFile(@"C:\Users\s178020\Documents\Visual Studio 2015\Projects\Backpack\Backpack\Properties\Backpack Images\vest.png");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            emptySyringe.Image = Image.FromFile(@"C:\Users\s178020\Documents\Visual Studio 2015\Projects\Backpack\Backpack\Properties\Backpack Images\syringe.png");
            liquid.Image = Image.FromFile(@"C:\Users\s178020\Documents\Visual Studio 2015\Projects\Backpack\Backpack\Properties\Backpack Images\liquid.png");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void gun_Click(object sender, EventArgs e)
        {
            gun.Image = Image.FromFile(@"C:\Users\s178020\Documents\Visual Studio 2015\Projects\Backpack\Backpack\Properties\Backpack Images\emptygun.png");
            clip.Image = Image.FromFile(@"C:\Users\s178020\Documents\Visual Studio 2015\Projects\Backpack\Backpack\Properties\Backpack Images\clip.png");
        }

        private void bullets_Click(object sender, EventArgs e)
        {

        }

        private void clip_Click(object sender, EventArgs e)
        {
            clip.Image = Image.FromFile(@"C:\Users\s178020\Documents\Visual Studio 2015\Projects\Backpack\Backpack\Properties\Backpack Images\emptyclip.png");
            bullets.Image = Image.FromFile(@"C:\Users\s178020\Documents\Visual Studio 2015\Projects\Backpack\Backpack\Properties\Backpack Images\bullets.png");
        }
    }
}
