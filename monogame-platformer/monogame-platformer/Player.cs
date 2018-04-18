using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace monogame_platformer
{
    //
    //
    class Player
    {
        float velocity = 30;

        Vector2 position = new Vector2(0, 0);

        // uses the Sprite object to create an instance
        Sprite playerSprite = new Sprite();

        // constructor
        public Player()
        {

        }

        public void Load(ContentManager content)
        {
            playerSprite.Load(content, "hero");
        }

        public void Update(float deltaTime)
        {
            playerSprite.Update(deltaTime);
            KeyboardState state = Keyboard.GetState();

            if (state.IsKeyDown(Keys.Right) == true)
            {
                position.X += velocity * deltaTime;
            }
            if (state.IsKeyDown(Keys.Left) == true)
            {
                position.X -= velocity * deltaTime;
            }
            if (state.IsKeyDown(Keys.Up) == true)
            {
                position.Y += velocity * deltaTime;
            }
            if (state.IsKeyDown(Keys.Down) == true)
            {
                position.Y -= velocity * deltaTime;
            }
            
            
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            playerSprite.Draw(spriteBatch);

            
        }

    }
}