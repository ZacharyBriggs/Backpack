using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Backpack
{
    public interface IContainer
    {
        void takeIn(IContainable item);
        void takeOut(IContainable item);
    }
    public interface IContainable
    {
        void putIn(IContainer bag);
        void takeOut(IContainer bag);
    }
    public class Item
    {
        public string name;
    }

    public class Backpack : IContainer
    {
        
        public List<IContainable> itemsContained = new List<IContainable>();

        public void takeIn(IContainable item)
        {
            this.itemsContained.Add(item);
        }

        public void takeOut(IContainable item)
        {
            this.itemsContained.Remove(item);
        }
    }

    public class Knife : Item, IContainable
    {
        public Knife()
        {
            sharpness = 25;
            name = "Knife";
        }
        public Knife(int sharp, string itemName)
        {
            sharpness = sharp;
            name = itemName;
        }

        public Knife(string itemName)
        {
            name = itemName;
        }
        public int sharpness;

        public void putIn(IContainer bag)
        {
            bag.takeIn(this);
        }

        public void takeOut(IContainer bag)
        {
            bag.takeOut(this);
        }
    }

    public class Potion : Item, IContainable
    {
        public bool isEmpty;

        public Potion()
        {
            name = "Potion";
        }
        public Potion(string itemName)
        {
            name = itemName;
        }



        public void putIn(IContainer bag)
        {
            bag.takeIn(this);
        }
        public void takeOut(IContainer bag)
        {
            bag.takeOut(this);
        }
    }
    public class Syringe : Item, IContainable
    {
        public Syringe()
        {
            name = "Syringe";
        }
        public Syringe(string itemName)
        {
            name = itemName;
        }
        public bool isEmpty;

        public void putIn(IContainer bag)
        {
            bag.takeIn(this);
        }

        public void takeOut(IContainer bag)
        {
            bag.takeOut(this);
        }
    }

    public class Shield : Item, IContainable
    {
        public int durability;

        public Shield()
        {
            name = "Shield";
        }

        public void putIn(IContainer bag)
        {
            bag.takeIn(this);
        }

        public void takeOut(IContainer bag)
        {
            bag.takeOut(this);
        }
    }

    public class Gun : Item, IContainable
    {
        public Gun()
        {
            name = "Gun";
        }

        public Gun(string itemName)
        {
            name = itemName;
        }
        public int numBullets;
        public List<string> usableCaliburs;

        public void putIn(IContainer bag)
        {
            bag.takeIn(this);
        }

        public void takeOut(IContainer bag)
        {
            bag.takeOut(this);
        }
    }

    public class Vest : Item, IContainable
    {
        public Vest()
        {
            name = "Vest";
        }

        public int armorLevel;

        public void putIn(IContainer bag)
        {
            bag.takeIn(this);
        }

        public void takeOut(IContainer bag)
        {
            bag.takeOut(this);
        }
    }


    static class Program
    {


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
