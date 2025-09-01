using buildingsystem.model;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace buildingsystem
{
    public class Previewlayer :Tilemaplayer
    
    {
        [SerializeField] private  SpriteRenderer previewrenderer;

        public void Showpreview(build item,Vector3 worldcroods,bool Isvaild )
        {
            var coords = tilemap.WorldToCell(worldcroods);
            previewrenderer.enabled = true;
            previewrenderer.transform.position = tilemap.CellToWorld(coords) + tilemap.cellSize / 2;
            previewrenderer.sprite = item.PreviewSprite;
            previewrenderer.color = Isvaild ? new Color(0, 1, 0, 0.5f) : new Color(1, 0, 0, 0.5f);
        }

        public void Clearpreview()
        {
            previewrenderer.enabled = false;
        }
    }
}