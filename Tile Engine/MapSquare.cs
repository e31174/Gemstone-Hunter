using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Tile_Engine
{
    [Serializable] public class MapSquare
    {
        #region Declarations
        public int[] LayerTiles = new int[4];
        public string CodeValue = "";
        public bool Passable = true;
        #endregion

        #region Constructor
        public MapSquare(int farBackground, int closeBackground, int interactive, int foreground, string code, bool passable)
        {
            LayerTiles[0] = farBackground;
            LayerTiles[1] = closeBackground;
            LayerTiles[2] = interactive;
            LayerTiles[3] = foreground;
            CodeValue = code;
            Passable = passable;
        }
        #endregion

        #region Public Methods
        public void TogglePassable()
        {
            if(TileMap.isToggleLocked == false)
            { 
                Passable = !Passable;
            }
            if (TileMap.isToggleLocked == true)
            {
                Passable = false;
            }
        }
        #endregion
    }
}
