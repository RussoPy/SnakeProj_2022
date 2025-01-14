using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Snake
{
    [Serializable]
    public class R_Item : Item
    {
        //class for the stationary food item
        public R_Item(int x, int y) : base(x, y)
        {
            //standard constructor
            this._color = 'y';
        }
        public override void soundss()
        {
            //override funtion to to play music
            base.soundss();
            SoundPlayer sp = new SoundPlayer(soundLocation: @"C:\Users\galru\OneDrive\Desktop\Snake\Regular-Item.wav");
            sp.Play();
        }
    }
}
