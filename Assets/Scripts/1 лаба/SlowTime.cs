using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowTime : MonoBehaviour
{
    public float slowt;
    private Transform player;
    public Keyboard keyboard;
    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    void Update()
    {
        if (Vector3.Distance(player.position, transform.position) < 2) //радиус поражения
        {
            keyboard.Slower(slowt); //замедление
        }
        else
        {
            keyboard.ReturnSpeed(); //ускорение
        }
    }

    
}
