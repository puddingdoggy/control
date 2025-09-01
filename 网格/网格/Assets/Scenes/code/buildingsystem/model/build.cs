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
            get;private set;//ͨ���� set ��������Ϊ private�����������ⲿ����ֱ���޸����Ե�ֵ��
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