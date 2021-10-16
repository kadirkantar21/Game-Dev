using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReleaseHarpoon : MonoBehaviour
{
    public GameObject hook;
    public float Hookspeed;
    LineRenderer hookLn;
    int hookDir = -1;
    public bool finished = false;
    public float timeRemain = 2.4f;
    

    private void Start()
    {
        hookLn = hook.GetComponent<LineRenderer>();
        
    }

    private void Update()
    {
        
    }


    public void Release()
    {
        Vector3 length = hookLn.GetPosition(1);

        if (length.y <= -7) hookDir = 1;
        if (length.y >= -.9f) hookDir = -1;

        length.y += Hookspeed * hookDir * Time.deltaTime;
        hookLn.SetPosition(1, length);

        
        if (timeRemain > 0)
        {
            timeRemain -= Time.deltaTime;
            
        }
        else
        {
            finished = true;
            hookLn.SetPosition(1, new Vector3(0, -1, 0));


        }


        //Debug.Log(finished);


        








    }
}
