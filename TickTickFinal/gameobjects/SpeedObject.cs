using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

class SpeedObject : SpriteGameObject
{
    float bounce;

    public SpeedObject(int layer = 0, string id = "") : base("Sprites/spr_waterspeed", layer, id)
    {
    }

    public override void Update(GameTime gameTime)
    {
        double t = gameTime.TotalGameTime.TotalSeconds * 3.0f + Position.X;
        bounce = (float)Math.Sin(t) * 0.2f;
        position.Y += bounce;
        Player player = GameWorld.Find("player") as Player;
        if (visible && CollidesWith(player))
        {
            visible = false;
            GameEnvironment.AssetManager.PlaySound("Sounds/snd_watercollected");

        }

    }
}
