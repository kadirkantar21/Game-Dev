using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HarpoonRotater : MonoBehaviour
{
    private float maxZrotation = 60f;
    private float differenceFromLeft = 30f;
    private float turnSpeed = 60f;
    private void Update()
    {
        float angle = Mathf.PingPong(Time.time * turnSpeed, maxZrotation) - differenceFromLeft;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
}
