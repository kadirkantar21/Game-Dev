using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReleaseHarpoon2 : MonoBehaviour
{
    public GameObject harpoon;
    public GameObject target;
    public GameObject harpoonHolder;
    public bool isReleased = false;
    public bool isMaxRange = false;
    private LineRenderer lineRenderer;
    public bool fishCatched = false;
    public GameManager gameManager;
    private void Start()
    {
        lineRenderer = harpoon.GetComponent<LineRenderer>();
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && !gameManager.isendSession)
        {
            isReleased = true;
        }
        if (isReleased && !isMaxRange)
        {
            harpoon.transform.localPosition = Vector3.MoveTowards(harpoon.transform.localPosition, target.transform.localPosition, Time.deltaTime * 5f);
        }
        if (isMaxRange)
        {
            harpoon.transform.localPosition = Vector3.MoveTowards(harpoon.transform.localPosition, harpoonHolder.transform.localPosition, Time.deltaTime * 5f);
        }
        if (fishCatched)
        {
            isMaxRange = true;
        }
        if (harpoon.transform.localPosition == target.transform.localPosition)
        {
            isMaxRange = true;
        }
        if (harpoon.transform.localPosition == harpoonHolder.transform.localPosition)
        {
            isReleased = false;
            isMaxRange = false;
        }
        lineRenderer.SetPosition(1, new Vector3(0, 2.5f, 0f));
        lineRenderer.SetPosition(0, harpoon.transform.position);        
    }
}
