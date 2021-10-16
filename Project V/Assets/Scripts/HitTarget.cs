using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitTarget : MonoBehaviour
{
    public bool Hit = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Hit = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Hit = false;
    }
}
