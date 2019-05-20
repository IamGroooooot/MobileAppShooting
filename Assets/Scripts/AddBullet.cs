using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddBullet : MonoBehaviour
{
    float nowTime;

    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        nowTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if(FindObjectOfType<ShotBtn>().Pressed && Time.time - nowTime >=0.3f)
        {
            GameObject b = Instantiate(bullet, new Vector3(transform.position.x, transform.position.y+1f, transform.position.z), Quaternion.identity);
            b.GetComponent<Bullet>().AddBullet(transform.position.x,transform.position.y+1f,transform.position.z);
            nowTime = Time.time;
        }
    }
}
