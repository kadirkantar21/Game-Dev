using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishMovement : MonoBehaviour
{
    //Bal���n sa�a sola maximum gidece�i mesafe
    private float maxRange = 2f;
    //Bal���n y�zme h�z�
    private float swimSpeed = 1f;
    private void Update()
    {
        //Bal��� x pozisyonun maximum mesafeye ula��rsa bal��� terse d�nd�r�r.
        if (transform.position.x > maxRange)
        {
            swimSpeed *= -1;
            transform.localScale = new Vector2(transform.localScale.x * -1, 0.5f);
        }
        else if (transform.position.x < -maxRange)
        {
            swimSpeed *= -1;
            transform.localScale = new Vector2(transform.localScale.x * -1, 0.5f);
        }
        //Bal�k hareketi
        transform.Translate(swimSpeed * Time.deltaTime, 0, 0);

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Bal��a bir collider �arpt���nda i�lem yapt�r�r.
        Debug.Log("sss");
    }
}
