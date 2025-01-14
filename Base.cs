using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Snake
{
    //The root class of the polymorphism tree
    [Serializable]
    public abstract class Base
    {
        protected int _x;//location on the X axis
        protected int _y;//location on the Y axis
        protected static int _length = 16;//set length of items in the program
        protected char _color;//char indicating the color of the object

        public Base(int x, int y)
        {
            //standard constructor
            this._x = x;
            this._y = y;
        }

        public bool collision(Base second)
        {
            //detect collosion between two base object
            //return true or false accordingly
            if (this._x == second._x && this._y==second._y) 
                return true;
            return false;
        }



        //get & set func
        public static int getLength()
        {
            return _length;
        }

        public int getX() { return _x; }
        public int getY() { return _y; }
        public void setX(int x)
        {
            _x = x;
        }
        public void setY(int y)
        {
            _y = y;
        }
        public char getColor()
        {
            return this._color;
        }
        public void setColor(char col)
        {
            this._color = col;
        }


    }
}
