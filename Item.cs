using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Snake
{
    [Serializable]
    public abstract class Item : Base
    {
        //abstract class for the food items
        public Item(int x, int y) : base(x, y)
        {
            //constructor for the inheritance classes
        }
        public virtual void soundss()
        {
            //override function to play music in inheritance classes
        }
    }
}
