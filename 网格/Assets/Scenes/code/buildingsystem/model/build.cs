using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace buildingsystem.model
{
    [CreateAssetMenu (menuName ="Building/New Buildable Item",fileName ="New Buildable Item")]

    public class build : ScriptableObject
    {

        [field :SerializeField ]public string Name
        {
            get;private set;//通过将 set 访问器设为 private，可以限制外部代码直接修改属性的值。
        }
        [field :SerializeField ]public TileBase Tile
        {
            get;private set;
        }
        [field :SerializeField ]public Vector3 Tileoffset
        {
            get;private set;
        }
        [field: SerializeField] public Sprite PreviewSprite
        {
            get;private set;
        }
    }
}