using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HarpoonRotater : MonoBehaviour
{
    private float maxZrotation = 60f;
    private float differenceFromLeft = 30f;
    private float turnSpeed = 60f;
    bool rotating = true;
    LineRenderer hookLn;
    public GameObject hook;
    


    private void Start()
    {
        hookLn = hook.GetComponent<LineRenderer>();
    }

    private void Update()
    {
        
        if (rotating)
        {
            //Z�pk�n�n zaman i�erisinde a��s�n� de�i�tirir. Form�l (zaman * d�nme h�z�, ka� derece d�nece�i) - z�pk�n�n ortalanmas� i�in verilen orta de�er
            float angle = Mathf.PingPong(Time.time * turnSpeed, maxZrotation) - differenceFromLeft;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }
        else
        {
            FindObjectOfType<ReleaseHarpoon>().Release();
            
        }
       

        //Mouse sol t�k bas�ld���nda z�pk�n� f�rlat�r.
        if (Input.GetMouseButtonDown(0))
        {
            rotating = false;
            FindObjectOfType<ReleaseHarpoon>().finished = false;
            FindObjectOfType<ReleaseHarpoon>().timeRemain = 2.45f;
            hookLn.SetPosition(1, new Vector3(0, -1, 0));
            
           

        }

        if (FindObjectOfType<ReleaseHarpoon>().finished)
        {
            rotating = true;
            


        }
    }







}
