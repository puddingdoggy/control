using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace buildingsystem
{
    public class buildingplacer : MonoBehaviour
    {
        [field :SerializeField]public build ActiveBuildable
        {
            get;private set;
        }
        [SerializeField] private Constructlayer constructlayer;

        private void Update()
        {
            if (Input .GetMouseButtonDown(0)&&ActiveBuildable!=null&&constructlayer !=null )
            {
                constructlayer.Build(GetMouseposition(), ActiveBuildable);
            }
        }

        private Vector3 GetMouseposition()
        {
            Vector3 vec = GetMousepositionZ(Input.mousePosition, Camera.main );
            vec.z = 0f;
            return vec;
        }
        private Vector3 GetMousepositionZ(Vector3 screenposition,Camera camera)
        {
            Vector3 worldpsoition = camera.ScreenToWorldPoint(screenposition);
            return worldpsoition;

        }
    }
}