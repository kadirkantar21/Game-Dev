using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HarpoonSpeed : MonoBehaviour
{
    //Zýpkýn hýzý ve hareketi
    private float speed = 5f;
    private void Update()
    {
        transform.Translate(Vector2.down * Time.deltaTime * speed);
    }
}
