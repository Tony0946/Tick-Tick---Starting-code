using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

class Camera1
{
    private bool _constantSpeed;
    private float _layer, _scrollingField, _speed;
    //private List<(klasse waar sprites instaan?)> _sprites;

    public float Layer
    {
        get { return _layer; }
        set
        {
            _layer = value;

            //foreach(var sprite in _sprites)
            {
                //sprite.Layer = _layer;
            }
        }
    }
}

