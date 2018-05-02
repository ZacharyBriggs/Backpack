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
            backpack = new Bag(25);
            textBox1.Text = backpack.name;
            textBox3.Text = backpack.currentWeight + "/" + backpack.maxWeight;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (potion.putInContainer(backpack) == false)
            {
                textBox2.Text = "Backpack full.";
            }
            else
                richTextBox1.Text += potion.name + "\n";
            textBox3.Text = backpack.currentWeight + "/" + backpack.maxWeight;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (shot.putInContainer(backpack) == false)
            {
                textBox2.Text = "Backpack full.";
            }
            else
                richTextBox1.Text += shot.name + "\n";
            textBox3.Text = backpack.currentWeight + "/" + backpack.maxWeight;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            shield.putInContainer(backpack);
            if (shield.putInContainer(backpack) == false)
            {
                textBox2.Text = "Backpack full.";
            }
            else
                richTextBox1.Text += shield.name + "\n";
            textBox3.Text = backpack.currentWeight + "/" + backpack.maxWeight;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            baretta.putInContainer(backpack);
            if (baretta.putInContainer(backpack) == false)
            {
                textBox2.Text = "Backpack full.";
            }
            else
                richTextBox1.Text += baretta.name + "\n";
            textBox3.Text = backpack.currentWeight + "/" + backpack.maxWeight;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            kevlar.putInContainer(backpack);
            if (kevlar.putInContainer(backpack) == false)
            {
                textBox2.Text = "Backpack full.";
            }
            else
                richTextBox1.Text += kevlar.name + "\n";
            textBox3.Text = backpack.currentWeight + "/" + backpack.maxWeight;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string backpackState = JsonConvert.SerializeObject(backpack);
            var path = System.IO.Path.Combine(Environment.CurrentDirectory, "backpack.txt");
            System.IO.File.WriteAllText(path, backpackState);
            textBox2.Text = "Backpack Saved.";
        }
    }
}
