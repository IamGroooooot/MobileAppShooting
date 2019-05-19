using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public static GameOver instance = null;

    private void Awake()
    {
        instance = this;
    }

    public void onReset()
    {
        timerCounter = 0;
        killCount = 0;
        isGameOver = false;
    }

    // Start is called before the first frame update
    public bool isGameOver ;
    public GameObject gameoverPanel;
    public Text Time_txt;
    public Text Killed_txt;
    float timerCounter = 0f;
    public int killCount = 0;
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
           
        }
        else
        {
            gameoverPanel.SetActive(false);
            Time.timeScale = 1;

        }
    }
}
