using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isGameOver ;
    public GameObject gameoverPanel;
    public Text Time_txt;
    public Text Killed_txt;
    float timerCounter = 0f;
    public int killCount = 0;
    bool once = true;
    void Start()
    {
        isGameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale != 0)
        {
            timerCounter += Time.deltaTime;
        }
        if (isGameOver)
        {
            Time.timeScale = 0;
            gameoverPanel.SetActive(true);
            Time_txt.text = "Time: " +((int)(timerCounter)).ToString();
            Killed_txt.text = "Killed: " + ((int)(killCount)).ToString();
           /*
            if (once)
            {
                timerCounter = 0f;
                killCount = 0;
                once = false;
            }*/
        }
        else
        {
            gameoverPanel.SetActive(false);
            once = true;
        }
    }
}
