using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Backpack
{
    static class Program
    {
        public interface IContainable
        {
            bool putInContainer(Backpack bag);
        }
        public class Item
        {
            public string name;
            public int size;
        }

        public class Container : Item
        {
            public List<Item> itemsContained;
            public int storageSize;
        }
        public class Backpack : Container
        {
        }

        public class knife : Item, IContainable
        {
            public int sharpness;

            public bool putInContainer(Backpack bag)
            {
                bag.itemsContained.Add(this);
                return true;
            }
        }

        public class potion : Container, IContainable
        {
            public bool isEmpty;
            public bool putInContainer(Backpack bag)
            {
                bag.itemsContained.Add(this);
                return true;
            }
        }
        public class syringe : Container, IContainable
        {
            public bool isEmpty;
            public bool putInContainer(Backpack bag)
            {
                bag.itemsContained.Add(this);
                return true;
            }
        }

        public class shield : Item, IContainable
        {
            public int durability;

            public bool putInContainer(Backpack bag)
            {
                bag.itemsContained.Add(this);
                return true;
            }
        }

        public class gun : Container, IContainable
        {
            public int numBullets;
            public List<string> usableCaliburs;

            public bool putInContainer(Backpack bag)
            {
                bag.itemsContained.Add(this);
                return true;
            }
        }

        public class vest : Item, IContainable
        {
            public int armorLevel;

            public bool putInContainer(Backpack bag)
            {
                bag.itemsContained.Add(this);
                return true;
            }
        }

        public class liquid : Item, IContainable
        {
            public bool putInContainer(Backpack bag)
            {
                bag.itemsContained.Add(this);
                return true;
            }
        }

        public class magazine : Container, IContainable
        {
            public bool putInContainer(Backpack bag)
            {
                bag.itemsContained.Add(this);
                return true;
            }
        }

        public class bullet : Item, IContainable
        {
            public string calibur;

            public bool putInContainer(Backpack bag)
            {
                bag.itemsContained.Add(this);
                return true;
            }
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
