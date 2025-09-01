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
                // ����������Ƭλ�á���ɫ��ƫ���������Ե����ݽṹ 
                var tileChangeData = new TileChangeData(
                    coords,                  // �������� (Vector3Int����)
                    item.Tile,               // ��Ƭ��Դ (TileBase����)
                    Color.white,              // ��Ƭ��ɫ (Ĭ�ϰ�ɫ)
                    Matrix4x4.Translate(item.Tileoffset) // ͨ��ƽ�ƾ���������Ƭƫ��
                );

                tilemap.SetTile(tileChangeData,  false);
            }

            buildables.Add(coords, buildable);    

        }



        public bool IsEmpty(Vector3 worldcoords)
        {
            var coords = tilemap.WorldToCell(worldcoords); // �������� �� ��Ƭ����
            return !buildables.ContainsKey(coords)&&tilemap.GetTile(coords)==null; // ��������Ƿ�ռ��
        }

    }
}