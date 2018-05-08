using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Backpack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            potion = new Potion();
            shot = new Syringe("Combat Shot");
            shield = new Shield();
            baretta = new Gun("Baretta");
            kevlar = new Vest();
            backpack = new Backpack();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            potion.putIn(backpack);
            listBox1.Items.Add(potion.name);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            shot.putIn(backpack);
            listBox1.Items.Add(shot.name);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            shield.putIn(backpack);
            listBox1.Items.Add(shield.name);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            baretta.putIn(backpack);
            listBox1.Items.Add(baretta.name);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            kevlar.putIn(backpack);
            listBox1.Items.Add(kevlar.name);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string backpackState = JsonConvert.SerializeObject(backpack);
            var path = System.IO.Path.Combine(Environment.CurrentDirectory, "backpack.txt");
            System.IO.File.WriteAllText(path, backpackState);
            textBox2.Text = "Backpack Saved.";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
