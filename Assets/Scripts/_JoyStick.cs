using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _JoyStick : MonoBehaviour
{
    public float speed = 3f;
    protected Joystick joystick;
    // protected
    // Use this for initialization
    void Start()
    {
        joystick = FindObjectOfType<Joystick>();
    }

    // Update is called once per frame
    void Update()
    {
        
        Vector3 pos = GetComponent<Transform>().position;

        //GetComponent<Transform>().position = new Vector3(joystick.Horizontal * 2f, joystick.Vertical*2f - 1.5f, 0);
        float horizontal = joystick.Horizontal;
        float vertical = joystick.Vertical;
        //transform.position += horizontal * new Vector3(speed, 0, 0) * Time.deltaTime;
        //transform.position += vertical * new Vector3(0, speed, 0) * Time.deltaTime;

        if (horizontal!=0)
        {
            if (transform.position.x >= 2.81f && horizontal > 0)
            {
                transform.position = new Vector3(2.79f, this.transform.position.y, 0);
                return;
            }
            if (transform.position.x <= -2.81f && horizontal < 0)
            {
                transform.position = new Vector3(-2.79f, this.transform.position.y, 0);
                return;
            }
            transform.position += horizontal * new Vector3(speed, 0, 0)*Time.deltaTime;
        }
        if (vertical!=0)
        {
            if (transform.position.y >= 6.11f && vertical > 0)
            {
                transform.position = new Vector3(this.transform.position.x, 6f, 0);
                return;
            }
            if (transform.position.y <= -4.1f && vertical < 0)
            {
                transform.position = new Vector3(this.transform.position.x, -4f, 0);
                return;
            }
            
            transform.position += vertical * new Vector3(0, speed, 0)*Time.deltaTime;
        }
    }


}
