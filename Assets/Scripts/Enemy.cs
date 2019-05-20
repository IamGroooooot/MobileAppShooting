using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Vector3 pos;
    float speed = 0.05f;
    float shootTimer=0;
    public GameObject EnemyBullet;
    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        shootTimer += Time.deltaTime;
        if (pos.y <= -5)
        {
            Destroy(this.gameObject);
        }
        if (shootTimer > 1.5f)
        {
            Shoot();
            shootTimer = 0f;
        }
        if (GameOver.instance.DestroyAllEnemy)
        {
            Destroy(this.gameObject);
        }
        transform.position = (pos);
        pos.y -= speed;
    }

    private void Shoot()
    {
        GameObject b = Instantiate(EnemyBullet, transform.position, EnemyBullet.transform.rotation);
        b.GetComponent<EnemyBullet>().AddBullet(transform.position.x, transform.position.y, transform.position.z);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Air")
        {
            GameOver.instance.isGameOver = true;
            Debug.Log("Player Destroyed");
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
}
