using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ShotBtn : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
 
    [HideInInspector]
    public bool Pressed;
    void Start()
    {
    }
    void Update()
    {
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        Pressed = true;
        //Debug.Log("press");
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        Pressed = false;
    }
}
