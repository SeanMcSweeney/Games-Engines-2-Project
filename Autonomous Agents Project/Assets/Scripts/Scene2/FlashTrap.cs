﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashTrap : MonoBehaviour
{
    public Vector3 velocity = Vector3.zero;
    public Vector3 arrivevelocity = new Vector3(10,10,10);
    public Vector3 posahead = new Vector3(10,10,0);
    public Vector3 target;
    public Vector3 desiredTarget;
    public float damping = 0.01f;
    public float maxSpeed = 2.0f;
    Transform pos1;
    float smooth = 5.0f;
    float Angle = 60.0f;
    float TrapTimer;

    void Start(){
        pos1 = GameObject.Find("FlashTarget").GetComponent<Transform>();
    }

    void Update()
    {
        TrapTimer += Time.deltaTime;
        if (TrapTimer >= 15){
            //Debug.Log("Hovertimed");
            HoverMove();
            HoverRotate();
        }
    }

    void HoverMove(){
        target = pos1.position;
        transform.position += velocity * Time.deltaTime;
        velocity *= (1.0f - (damping * Time.deltaTime));
        desiredTarget = target - transform.position;
        desiredTarget.Normalize();
        desiredTarget *= maxSpeed;
        velocity = desiredTarget;
        if (desiredTarget - velocity == arrivevelocity){
            velocity = Vector3.zero;
        }
    }

    void HoverRotate(){
        var rotation = transform.rotation;
        rotation.y = 180;
        transform.rotation = rotation;
        this.transform.LookAt(pos1);
    }
}

