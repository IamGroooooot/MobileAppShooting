using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float nowTime;
    public Text timer_txt;
    public Text kill_txt;

    // Start is called before the first frame update
    void Start()
    {
        nowTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        timer_txt.text = "Time: "+((int)Time.time-nowTime).ToString();
        kill_txt.text = "Killed: " + GameOver.instance.killCount.ToString();
    }
}
