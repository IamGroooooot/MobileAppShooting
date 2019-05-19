using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClick : MonoBehaviour
{
    public GameObject player_prefab;

    public void OnClickRestart()
    {
        GameOver.instance.onReset();
        Instantiate(player_prefab,new Vector3(0,-1.1f,0), player_prefab.transform.rotation, null);
    }
}
