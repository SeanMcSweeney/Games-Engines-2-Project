using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallShipToAjax : MonoBehaviour
{
    public Vector3 velocity = Vector3.zero;
    public Vector3 arrivevelocity = new Vector3(10,10,10);
    public Vector3 posahead;
    public Vector3 target;
    public Vector3 desiredTarget;
    public float damping = 0.01f;
    public float maxSpeed = 2.0f;
    Transform pos1;

    void Start(){
        pos1 = GameObject.Find("ajax").GetComponent<Transform>();
        posahead = pos1.position;
    }

    void Update()
    {
        target = transform.position + posahead;
        SlowMoveSeekSB();
    }

    void SlowMoveSeekSB(){
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
}

