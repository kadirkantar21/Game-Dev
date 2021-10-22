using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int score;
    public int fishCount = 4;
    public TextMeshProUGUI scoreText;
    public GameObject endSessionPanel;
    public GameObject harpoonParent;
    public bool isendSession = false;
    private void Start()
    {
        scoreText.text = "Score : " + score;
    }
    private void Update()
    {
        scoreText.text = "Score : " + score;
        if (fishCount <= 0)
        {
            endSessionPanel.SetActive(true);
            harpoonParent.GetComponent<HarpoonRotater2>().turnSpeed = 0;
            harpoonParent.GetComponent<HarpoonRotater2>().differentFromLeft = 0;
            isendSession = true;
        }
    }
    public void RestartButton()
    {
        SceneManager.LoadScene(1);
    }
    public void ExitButton()
    {
        Application.Quit();
    }
}
