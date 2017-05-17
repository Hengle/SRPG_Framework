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
    public class Character : GameObject
    {
        // attributes
        string name;
        string characterClass;
        Random growthChecker;
        
        // properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Random GrowthChecker
        {
            get { return growthChecker; }
        }

        // constructor
        public Character(Texture2D thisSprite, int x, int y, int width, int height, bool isDynamic, string thisName, string thisClass) : base(thisSprite, x, y, width, height, isDynamic)
        {
            name = thisName;
            characterClass = thisClass;
            growthChecker = new Random();
        }

        // methods

    }
}
