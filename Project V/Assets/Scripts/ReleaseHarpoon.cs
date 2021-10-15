using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReleaseHarpoon : MonoBehaviour
{
    public GameObject harpoon;
    public GameObject harpoonHead;
    GameObject InsHarpoon;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            InsHarpoon = Instantiate(harpoonHead, harpoon.transform.position, transform.rotation) as GameObject;
        }


    }
}
