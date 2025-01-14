using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Snake
{
    [Serializable]
    public class M_Item : Item
    {
        //class for the moving food item
        public M_Item(int x, int y) : base(x, y)
        {
            //standard constructor
            this._color = 'b';
        }

        public void Jump(Base snake, int maxXPos, int maxYPos)
        {
            //moving the object to a new set of (x,y) coordinates
            //the new coordinates can't the snake head coordinates
            Random random = new Random();
            do
            {
                int Rx = random.Next(0, maxXPos);
                int Ry = random.Next(0, maxYPos);
                this.setX(Rx);
                this.setY(Ry);
            } while (this.collision(snake) );
        }
        public override void soundss()
        {
            //override funtion to to play music
            base.soundss();
            SoundPlayer sp = new SoundPlayer(soundLocation: @"C:\Users\galru\OneDrive\Desktop\Snake\Moving item.wav");
            sp.Play();
        }
    }
}
