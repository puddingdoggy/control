using buildingsystem.model;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace buildingsystem
{
    public class Constructlayer : Tilemaplayer 
    {
        private Dictionary<Vector3Int, Buildable> buildables = new();
        public void Build(Vector3 worldcoords, build item)
        {
            var coords= tilemap.WorldToCell(worldcoords);
            var buildable = new Buildable(tilemap, item, coords);
            if (item.Tile != null)
            {
                // 创建包含瓦片位置、颜色、偏移量等属性的数据结构 
                var tileChangeData = new TileChangeData(
                    coords,                  // 网格坐标 (Vector3Int类型)
                    item.Tile,               // 瓦片资源 (TileBase类型)
                    Color.white,              // 瓦片颜色 (默认白色)
                    Matrix4x4.Translate(item.Tileoffset) // 通过平移矩阵设置瓦片偏移
                );

                tilemap.SetTile(tileChangeData,  false);
            }

            buildables.Add(coords, buildable);    

        }



        public bool IsEmpty(Vector3 worldcoords)
        {
            var coords = tilemap.WorldToCell(worldcoords); // 世界坐标 → 瓦片坐标
            return !buildables.ContainsKey(coords)&&tilemap.GetTile(coords)==null; // 检查坐标是否被占用
        }

    }
}