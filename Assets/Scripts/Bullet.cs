﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Vector3 pos;
    float speed = 0.2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (pos.y > 9)
        {
            Destroy(this.gameObject);
        }
        transform.position = (pos);
        pos.y += speed;
    }
    public void AddBullet(float x, float y, float z)
    {
        pos = new Vector3(x,y,z);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            Destroy(other.gameObject);
            Debug.Log("Enemy Destroyed");
            GameOver.instance.killCount++;
            Destroy(this.gameObject);
        }
    }
}
