using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BillboardButton : MonoBehaviour, IPressable
{
    public GameObject billboard;
    private Transform _buttonTransform;
    private Renderer billboard_ren;
    private Transform playerTransform;
    private bool emis = false;
    private void Awake()
    {
        billboard_ren = billboard.GetComponent<Renderer>();
        _buttonTransform = GetComponent<Transform>();
        playerTransform = GameObject.FindGameObjectWithTag("player").GetComponent<Transform>();
    }
    
    void Update()
    {
        
    }

    public void Press()
    {
        if (!emis)
        {
            billboard_ren.material.EnableKeyword("_EMISSION");
            emis = true;
        }
        else if (emis)
        {
            billboard_ren.material.DisableKeyword("_EMISSION");
            emis = false;
        }
    }
    
}
