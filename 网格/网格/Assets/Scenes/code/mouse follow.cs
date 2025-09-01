using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mousefollow : MonoBehaviour
{
    [SerializeField] private Camera maincamera;

    private void Update()
    {
        Vector3 Mouseworldposition = maincamera.ScreenToWorldPoint(Input.mousePosition);
        Mouseworldposition.z = 0f;
        transform.position = Mouseworldposition;

    }

}
