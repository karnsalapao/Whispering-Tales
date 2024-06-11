using System.Collections;
using System.Collections.Generic;
using Unity.XR.CoreUtils;
using UnityEngine;

public class UILookAt : MonoBehaviour
{
    XROrigin origin;

    void Start()
    {
        origin = FindObjectOfType<XROrigin>();
    }

    void Update()
    {
        transform.LookAt(Camera.main.transform, Vector3.up);
    }
}
