using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishMovement2 : MonoBehaviour
{
    private int speed = 1;
    private float maxRange = 2f;
    public bool catched = false;
    public Vector3 offset = new Vector3(0f, 0.5f, 1f);
    private float distanceBetweenPlayer;
    private GameObject player;
    private GameObject harpoonParent;
    private GameObject gameManager;
    private void Start()
    {
        gameManager = GameObject.Find("GameManager");
        player = GameObject.Find("Player");
        harpoonParent = GameObject.Find("HarpoonParent");
    }
    private void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed);
        if (transform.position.x > maxRange)
        {
            speed *= -1;
            transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        }
        else if (transform.position.x < -maxRange)
        {
            speed *= -1;
            transform.localScale = new Vector3(-0.5f, 0.5f, 0.5f);
        }
        if (catched)
        {
            transform.position = GameObject.Find("FishHolder").transform.position;
            transform.rotation = GameObject.Find("FishHolder").transform.rotation;
            speed = 0;
        }
        distanceBetweenPlayer = Vector3.Distance(player.transform.position, transform.position);
        if (distanceBetweenPlayer < 2)
        {
            gameManager.GetComponent<GameManager>().score++;
            gameManager.GetComponent<GameManager>().fishCount--;
            harpoonParent.GetComponent<ReleaseHarpoon2>().fishCatched = false;
            Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Harpoon"))
        {
            catched = true;
            harpoonParent.GetComponent<ReleaseHarpoon2>().fishCatched = true;
        }
    }
}
