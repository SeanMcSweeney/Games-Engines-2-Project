using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashMovementS1 : MonoBehaviour
{
    public Vector3 velocity = Vector3.zero;
    public Vector3 arrivevelocity = new Vector3(10,10,10);
    public Vector3 posahead = new Vector3(10,10,0);
    public Vector3 target;
    public Vector3 desiredTarget;
    public float damping = 0.01f;
    public float maxSpeed = 2.0f;
    Transform pos1;
    Explosion explosion;
    SwitchSceneTimer sstimer;

    void Start(){
        explosion = GameObject.Find("Sky City/ForExplosions").GetComponent<Explosion>();
        sstimer = GetComponent<SwitchSceneTimer>();
        target = transform.position - posahead;
    }

    void Update()
    {
        if (explosion.exp == true){
            sstimer.timerStart =true;
            HoverMove();
        }
    }

    void HoverMove(){
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

