using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HerdController : Controller
{
    private GameObject player;
    private Rigidbody herdRb;
    

    private void Start()
    {
        MoveSpeed = 20.0f;
        herdRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");        
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;
        Move(lookDirection,herdRb);
        
    }

   
}
