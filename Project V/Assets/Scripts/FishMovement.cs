using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishMovement : MonoBehaviour
{
    public bool catched = false;
    
    //Bal���n sa�a sola maximum gidece�i mesafe
    private float maxRange = 2.1f;
    //Bal���n y�zme h�z�
    private float swimSpeed = 1f;
    Transform harpoon;
    public GameObject player;
    float distanceBtw;


    private void Start()
    {
        
    }


    private void Update()
    {

        if (!catched)
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
        else
        {
            transform.position = harpoon.position;
            transform.rotation = Quaternion.Euler(0, 0, 0);

            distanceBtw = Vector3.Distance(player.transform.position, transform.position);

            


            if (distanceBtw < 3.6f)
            {

                Destroy(gameObject);

            }
        }
        
        

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        harpoon = collision.transform;
        catched = true;

        

        
        


    }



}
