using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using buildingsystem.model;

namespace buildingsystem
{
    public class buildingplacer : MonoBehaviour
    {
        [field :SerializeField]public build ActiveBuildable
        {
            get;private set;
        }
        [SerializeField] private float MaxDistance = 3f;
        [SerializeField] private Constructlayer constructlayer;
        [SerializeField ]private Previewlayer previewlayer ;

        private void Update()
        {
            if (!Ifinrange()||ActiveBuildable==null)
            {
                previewlayer.Clearpreview();
                return;
            }
            previewlayer.Showpreview(ActiveBuildable, GetMouseposition(), constructlayer.IsEmpty(GetMouseposition()));//‘§¿¿

            if (Input .GetMouseButtonDown(0)&&ActiveBuildable!=null&&constructlayer !=null&&constructlayer .IsEmpty(GetMouseposition()) )
            {
                constructlayer.Build(GetMouseposition(), ActiveBuildable);
            }
        }

        private bool Ifinrange()
        {
            return Vector3.Distance(GetMouseposition(), transform.position) <= MaxDistance;
        }

        private   Vector3 GetMouseposition()
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