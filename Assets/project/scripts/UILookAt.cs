using System.Collections;
using System.Collections.Generic;
using Unity.XR.CoreUtils;
using UnityEngine;

public class UILookAt : MonoBehaviour
{
    XROrigin origin;

    // Start is called before the first frame update
    void Start()
    {
        origin = FindObjectOfType<XROrigin>();
    }

    // Update is called once per frame
    void Update()
    {
        var oldRot = transform.rotation;
        transform.LookAt(origin.transform);
        oldRot = new Quaternion(oldRot.x, transform.rotation.y, oldRot.z, oldRot.w);
        transform.rotation = oldRot;
    }
}
