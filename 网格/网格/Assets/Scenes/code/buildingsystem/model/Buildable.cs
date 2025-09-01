using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace buildingsystem.model
{
    [SerializeField ]
    public class Buildable 
    {
        [field: SerializeField]public Tilemap ParentTilemap
        { 
            get; private set;
        }
        [field: SerializeField] public build BuildableType 
        { 
            get; private set; 
        }
        [field: SerializeField]public GameObject Gameobject 
        { 
            get; private set; 
        }
        [field: SerializeField]public Vector3Int Coordinates 
        {
            get; private set; 
        }


        public Buildable(Tilemap tilemap,build type,Vector3Int coord,GameObject gameObject=null)
        {
            ParentTilemap = tilemap;
            BuildableType = type;
            Gameobject = gameObject;
            Coordinates = coord;
        }
    }
}