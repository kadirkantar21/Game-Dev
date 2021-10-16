using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitTarget : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        //Zýpkýn bir objeye çaptýðýnda o objeye ulaþýp iþlemler yapar.
        Debug.Log(other.gameObject.name);
    }
}
