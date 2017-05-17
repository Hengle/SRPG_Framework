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
    public class GameObject
    {
        // attributes
        Texture2D sprite;
        Rectangle hitBox;
        Boolean dynamic;

        // properties
        public int XPos
        {
            get { return hitBox.X; }
            set { hitBox.X = value; }
        }
        public int YPos
        {
            get { return hitBox.Y; }
            set { hitBox.Y = value; }
        }
        public int Width
        {
            get { return hitBox.Width; }
            set { hitBox.Width = value; }
        }
        public int Height
        {
            get { return hitBox.Height; }
            set { hitBox.Height = value; }
        }
        public Boolean IsDyanmic
        {
            get { return dynamic; }
        }

        // constructor
        public GameObject(Texture2D thisSprite, int x, int y, int width, int height, Boolean isDynamic)
        {
            hitBox = new Rectangle(x, y, width, height);
            dynamic = isDynamic;
            sprite = thisSprite;
        }

        // methods
        public virtual void Draw(SpriteBatch sb)
        {
            sb.Begin();
            sb.Draw(sprite, hitBox, Color.White);
            sb.End();
        }

        public virtual void Update(GameTime gt)
        {

        }
    }
}
