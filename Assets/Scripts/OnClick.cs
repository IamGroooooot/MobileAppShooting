using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClick : MonoBehaviour
{
    public GameObject player_prefab;

    public void OnClickRestart()
    {
        if (!(GameOver.instance.isGameOver))
        {
            Debug.Log("is not Gameover");
        }

        GameOver.instance.DestroyAllEnemy = true;
        GameOver.instance.onReset();
        Timer.instance.nowTime = Time.time;
                

        if (GameObject.FindGameObjectWithTag("Air") != null)
        {
            Destroy(GameObject.FindGameObjectWithTag("Air").gameObject);
        }
        Instantiate(player_prefab,new Vector3(0,-1.1f,0), player_prefab.transform.rotation, null);
    }
}
