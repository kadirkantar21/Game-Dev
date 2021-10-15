using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishMovement : MonoBehaviour
{
    private float maxRange = 2f;
    private float swimSpeed = 1f;
    private void Update()
    {
        
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
        transform.Translate(swimSpeed * Time.deltaTime, 0, 0);

    }
}
