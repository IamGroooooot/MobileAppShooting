using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePause : MonoBehaviour
{
    public bool isPauseBtnClicked = false; 
    bool isPause=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isPauseBtnClicked)
        {
            if (isPause)
            {
                Time.timeScale = 0;
                isPause = false;
            }
            else
            {
                Time.timeScale = 1;
                isPause = true;
            }
        }
    }
}
