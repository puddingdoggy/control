using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;


namespace buildingsystem
{
    [RequireComponent(typeof(Tilemap ))]
    public class Tilemaplayer : MonoBehaviour
    {
        protected Tilemap tilemap { get; private set; }

        protected void Awake()
        {
            tilemap = GetComponent<Tilemap>();
        }
    }
}