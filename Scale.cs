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
    [Serializable]
    public class Scale : Base
    {
        private static int _last_x;//X location of the last modified object 
        private static int _last_y;//Y location of the last modified object 
        private bool _head;//flag to mark the leading object of the list
        private char _direction;//direction of head

        public Scale(int x, int y,bool flag,char col) :base(x,y)
        {
            // regular constructor
            this._color = col;
            this._direction = 'd';
            this._head = flag;
        }
        public Scale(char col) :base(_last_x, _last_y)
        {
            //constructor for adding an object after eating an Item
            this._color = col;
            this._head = false;
        }

        public Scale(Scale s) : base(s._x, s._y)
        {
            //copy constructor
            this._color=s._color;
            this._direction = s._direction;
            this._head = s._head;

        }

        public void move()
        {
            //moving a scale to his new location
            //for a head scale calculating new location with direction
            //for a non head scale change to the location of the last modified scale
            if (this._head)
            {
                _last_x = this.getX();
                _last_y = this.getY();
                switch (this._direction)
                {
                    case 'r':
                        this.setX(this.getX() + 1); //right
                        break;
                    case 'l':
                        this.setX(this.getX() - 1); //left
                        break;
                    case 'd':
                        this.setY(this.getY() + 1);// Down
                        break;
                    case 'u':
                        this.setY(this.getY() - 1);//Up
                        break;
                }
            }
            else
            {
                int temp_x, temp_y;
                temp_x = this.getX();
                temp_y = this.getY();
                this.setX(_last_x);
                this.setY(_last_y);
                _last_x=temp_x;
                _last_y=temp_y;
            }
        }

        public bool outOfBounds(int maxXPos, int maxYPos)
        {
            //check if the object is outside he allowed parameters
            //return true or false accordingly
            if (this.getY() < 0 || this.getX() < 0 || this.getX() > maxXPos-1 || this.getY() > maxYPos-1) 
                return true;
            return false;
        }
        


        //get & ser func
        public char getDec()
        {
            return this._direction;
        }

        public void setDec(char dec)
        {
            this._direction = dec;
        }

        
    }
}
