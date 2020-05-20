using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HawkMenDecision : MonoBehaviour
{
    public GameObject seeked = null;
    public Vector3 seekedpos = Vector3.zero;
    public int sonum;
    public Vector3 velocity = Vector3.zero;
    public Vector3 arrivevelocity = new Vector3(10,10,10);
    public Vector3 desiredTarget;
    public float damping = 0.01f;
    public float maxSpeed = 2.0f;

    bool chosen;
    void Start()
    {
        GetComponents<HawkMenController>();
        GetComponents<HawkMenSB>();       
        chosen = false; 
    }


    void Update()
    {
        if (chosen == false){
        DecisionState();
        }
        if (chosen == true){
        SeekState();
        }
    }

    void DecisionState(){
        sonum = Random.Range(1,11);
        seeked = GameObject.Find("Soldiers/Soldier" + sonum);
        if (seeked != null){
            seekedpos = seeked.transform.position;
            chosen = true;
        }
        else{
        }
    }

    void SeekState(){
        transform.position += velocity * Time.deltaTime;
        velocity *= (1.0f - (damping * Time.deltaTime));
        desiredTarget = seekedpos - transform.position;
        desiredTarget.Normalize();
        desiredTarget *= maxSpeed;
        velocity = desiredTarget;
        if (desiredTarget - velocity == arrivevelocity){
            velocity = Vector3.zero;
        }
    }
}
