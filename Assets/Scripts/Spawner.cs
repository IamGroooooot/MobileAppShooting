using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform enemy_folder;
    public GameObject enemy;
    float xPos;
    float yPos;
    float zPos;
    float period;
    float nowTime;
    float timer=0;

    // Start is called before the first frame update
    void Start()
    {
        nowTime = Time.time;
        period = 1.5f;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (Time.time - nowTime >= period)
        {
            period = Random.Range(1.5f,2.2f);
            Instantiate(enemy,new Vector3(Random.Range(-3, 3), Random.Range(4.6f, 4.8f),0),enemy.transform.rotation, enemy_folder);
            nowTime = Time.time;
            timer = 0;
            GameOver.instance.DestroyAllEnemy = false;
        }
    }
}
