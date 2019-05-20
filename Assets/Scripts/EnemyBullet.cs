using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    Vector3 pos;
    float speed = 0.15f;
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        if (pos.y < -8)
        {
            Destroy(this.gameObject);
        }
        transform.position = (pos);
        pos.y -= speed;
    }
    public void AddBullet(float x, float y, float z)
    {
        pos = new Vector3(x, y, z);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Air")
        {
            Debug.Log("Player Destroyed");
            GameOver.instance.isGameOver = true;
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
}
