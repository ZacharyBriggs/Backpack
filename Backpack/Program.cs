using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Backpack
{
    static class Program
    {
        public class Item
        {
            public string Name;
            private List<Item> itemsContained;
        }

        public class Backpack : Item
        {

        }

        public class knife : Item
        {
            public int sharpness;
        }

        public class syringe : Item
        {
            public bool isEmpty;
        }

        public class shield : Item
        {
            public int durability;
        }

        public class gun : Item
        {
            public int numBullets;
        }

        public class vest : Item
        {
            public int armorLevel;
        }

        public class liquid : Item
        {

        }

        public class magazine : Item
        {

        }

        public class bullet : Item
        {
            public string calibur;
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
