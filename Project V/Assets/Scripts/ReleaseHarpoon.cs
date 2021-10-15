using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReleaseHarpoon : MonoBehaviour
{
    public GameObject harpoon;
    public GameObject harpoonHead;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(harpoonHead, harpoon.transform.position, transform.rotation);
        }
    }
}
