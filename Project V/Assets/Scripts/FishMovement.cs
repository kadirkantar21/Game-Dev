using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishMovement : MonoBehaviour
{
    //Balýðýn saða sola maximum gideceði mesafe
    private float maxRange = 2f;
    //Balýðýn yüzme hýzý
    private float swimSpeed = 1f;
    private void Update()
    {
        //Balýðý x pozisyonun maximum mesafeye ulaþýrsa balýðý terse döndürür.
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
        //Balýk hareketi
        transform.Translate(swimSpeed * Time.deltaTime, 0, 0);

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Balýða bir collider çarptýðýnda iþlem yaptýrýr.
        Debug.Log("sss");
    }
}
