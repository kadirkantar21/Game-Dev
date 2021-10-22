using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HarpoonRotater2 : MonoBehaviour
{
    public float turnSpeed = 50f;
    private float maxZRotation = 60f;
    public float differentFromLeft = 30f;
    private void Start()
    {
        
    }
    private void Update()
    {
        if (!GetComponent<ReleaseHarpoon2>().isReleased)
        {
            float angle = Mathf.PingPong(Time.time * turnSpeed, maxZRotation) - differentFromLeft;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }
        
    }
}
