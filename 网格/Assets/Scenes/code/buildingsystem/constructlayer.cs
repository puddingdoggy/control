using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace buildingsystem
{
    public class Constructlayer : Tilemaplayer 
    {
        public void Build(Vector3 worldcoords, build item)
        {
            var coords= tilemap.WorldToCell(worldcoords);
            if (item.Tile != null)
            {
                tilemap.SetTile(coords, item.Tile);
            }
        }
    }
}