using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitTarget : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        //Z�pk�n bir objeye �apt���nda o objeye ula��p i�lemler yapar.
        Debug.Log(other.gameObject.name);
    }
}
