using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace SRPG_Framework
{
    public class Weapon : Item
    {
        // attributes
        private int strength;
        private int weight;

        // properties
        public int Strength
        {
            get { return strength; }
        }

        public int Weight
        {
            get { return weight; }
        }

        // methods
        public Weapon(Texture2D thissprite, string thisName, string thisDescription, int str, int wt) : base(thissprite, thisName, thisDescription)
        {
            strength = str;
            weight = wt;
        }
    }
}
