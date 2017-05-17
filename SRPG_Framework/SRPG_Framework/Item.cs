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
    public class Item
    {
        // attributes
        Texture2D sprite;
        string name;
        string description;
        
        // properties
        public string Name
        {
            get { return name; }
        }
        public string Description
        {
            get { return description; }
        }

        // constructor
        public Item(Texture2D thisSprite, string thisName, string thisDescription)
        {
            sprite = thisSprite;
            name = thisName;
            description = thisDescription;
        }

        // methods
    }
}
