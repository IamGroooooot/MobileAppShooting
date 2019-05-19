using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClick : MonoBehaviour
{
    public GameObject player_prefab;

    public void OnClickRestart()
    {

        GameOver.instance.onReset();
        Timer.instance.nowTime = Time.time;
        while (GameObject.Find("Enemy").transform.childCount > 0) { 
            if (GameObject.Find("Enemy").transform.GetChild(0) != null)
            {
                Destroy(GameObject.Find("Enemy").transform.GetChild(0).gameObject);
            }
        }
        Instantiate(player_prefab,new Vector3(0,-1.1f,0), player_prefab.transform.rotation, null);
    }
}
