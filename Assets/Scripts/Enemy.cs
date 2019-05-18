using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Enemy : MonoBehaviour
{
    Vector3 pos;
    float speed = 0.05f;
    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (pos.y <= -5)
        {
            Destroy(this.gameObject);
        }
        transform.position = (pos);
        pos.y -= speed;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Air")
        {
            FindObjectOfType<GameOver>().isGameOver = true;
            Debug.Log("Player Destroyed");
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
}
