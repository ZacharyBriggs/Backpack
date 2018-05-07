using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Backpack
{
    public interface IContainable
    {
        bool putInContainer(Container bag);
    }
    public class Item
    {
        public string name;
        public int size;
    }

    public class Container : Item
    {
        public List<IContainable> itemsContained = new List<IContainable>();
        public int maxWeight = 20;
        public int currentWeight = 0;
    }
    public class Bag : Container
    {
        public Bag()
        {
            name = "Bag";
        }
        public Bag(int size)
        {
            maxWeight = size;
            name = "Bag";
        }

        public Bag(int size, string itemName)
        {
            maxWeight = size;
            name = itemName;
        }
    }

    public class Knife : Item, IContainable
    {
        public Knife()
        {
            sharpness = 25;
            name = "Knife";
            size = 1;
        }
        public Knife(int sharp, string itemName)
        {
            sharpness = sharp;
            name = itemName;
            size = 1;
        }

        public Knife(string itemName)
        {
            name = itemName;
            size = 1;
        }
        public int sharpness;

        public bool putInContainer(Container bag)
        {
            if (bag.currentWeight <= bag.maxWeight - size)
            {
                bag.itemsContained.Add(this);
                bag.currentWeight += size;
                return true;
            }
            return false;
        }
    }

    public class Potion : Container, IContainable
    {
        public bool isEmpty;

        public Potion()
        {
            name = "Potion";
            size = 1;
        }
        public Potion(string itemName)
        {
            name = itemName;
            size = 1;
        }
        public bool putInContainer(Container bag)
        {
            if (bag.currentWeight <= bag.maxWeight - size)
            {
                bag.itemsContained.Add(this);
                bag.currentWeight += size;
                return true;
            }
            return false;
        }
    }
    public class Syringe : Container, IContainable
    {
        public Syringe()
        {
            name = "Syringe";
            size = 1;
        }
        public Syringe(string itemName)
        {
            name = itemName;
            size = 1;
        }
        public bool isEmpty;
        public bool putInContainer(Container bag)
        {
            if (bag.currentWeight <= bag.maxWeight - size)
            {
                bag.itemsContained.Add(this);
                bag.currentWeight += size;
                return true;
            }
            return false;
        }
    }

    public class Shield : Item, IContainable
    {
        public int durability;

        public Shield()
        {
            name = "Shield";
            size = 2;
        }
        public bool putInContainer(Container bag)
        {
            if (bag.currentWeight <= bag.maxWeight - size)
            {
                bag.itemsContained.Add(this);
                bag.currentWeight += size;
                return true;
            }
            return false;
        }
    }

    public class Gun : Container, IContainable
    {
        public Gun()
        {
            name = "Gun";
            size = 1;
        }

        public Gun(string itemName)
        {
            name = itemName;
            size = 1;
        }
        public int numBullets;
        public List<string> usableCaliburs;

        public bool putInContainer(Container bag)
        {
            if (bag.currentWeight <= bag.maxWeight - size)
            {
                bag.itemsContained.Add(this);
                bag.currentWeight += size;
                return true;
            }
            return false;
        }
    }

    public class Vest : Item, IContainable
    {
        public Vest()
        {
            name = "Vest";
            size = 2;
        }
        public int armorLevel;

        public bool putInContainer(Container bag)
        {
            if (bag.currentWeight <= bag.maxWeight - size)
            {
                bag.itemsContained.Add(this);
                bag.currentWeight += size;
                return true;
            }
            return false;
        }
        static class Program
        {

        }

        /*public class Liquid : Item, IContainable
        {
            public bool putInContainer(Backpack bag)
            {
                bag.itemsContained.Add(this);
                return true;
            }
        }

        public class Magazine : Container, IContainable
        {
            public bool putInContainer(Backpack bag)
            {
                bag.itemsContained.Add(this);
                return true;
            }
        }

        public class Bullet : Item, IContainable
        {
            public string calibur;

            public bool putInContainer(Backpack bag)
            {
                bag.itemsContained.Add(this);
                return true;
            }
        }*/
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
