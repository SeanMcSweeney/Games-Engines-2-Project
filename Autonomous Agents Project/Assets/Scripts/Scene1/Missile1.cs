using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile1 : MonoBehaviour
{
    public Vector3 velocity = Vector3.zero;
    public Vector3 arrivevelocity = new Vector3(10,10,10);
    public Vector3 posahead;
    public Vector3 target;
    public Vector3 desiredTarget;
    public float damping = 0.01f;
    public float maxSpeed = 20.0f;
    Transform pos1;
    SwitchSceneTimer sstimer;
    float timer;
    GameObject mainMissile;
    GameObject cloneMissile;
    GameObject currentMissile;
    bool Missile1bool;
    bool Missile2bool;
    bool Missile3bool;
    bool Missile4bool;
    bool Missile5bool;
    bool Missile6bool;
    Transform CloneMissileT;
    int i;
    

    void Start(){
        pos1 = GameObject.Find("Sky City/ForExplosions").GetComponent<Transform>();
        posahead = pos1.position;
        target = posahead;
        mainMissile = GameObject.Find("ajax/missile");
        Missile1bool = true;
        Missile2bool = true;
        Missile3bool = true;
        Missile4bool = true;
        Missile5bool = true;
        Missile6bool = true;
        i = 1;
    }

    void Update()
    {
    timer += Time.deltaTime;
        if (timer >= 16){
            if(transform.position != target){
                if(Missile1bool == true){
                CreateMissile();
                }
                MissileMove();
                Missile1bool = false;
            }
        }
        if (timer >= 17){
            if(transform.position != target){
                if(Missile2bool == true){
                Destroy(currentMissile);
                CreateMissile();
                }
                MissileMove();
                Missile2bool = false;
            }
        }
        if (timer >= 18){
            if(transform.position != target){
                if(Missile3bool == true){
                Destroy(currentMissile);
                CreateMissile();
                }
                MissileMove();
                Missile3bool = false;
            }
        }
        if (timer >= 24){
            if(transform.position != target){
                if(Missile4bool == true){
                Destroy(currentMissile);
                CreateMissile();
                }
                MissileMove();
                Missile4bool = false;
            }
        }
        if (timer >= 25){
            if(transform.position != target){
                if(Missile5bool == true){
                Destroy(currentMissile);
                CreateMissile();
                }
                MissileMove();
                Missile5bool = false;
            }
        }
        if (timer >= 26){
            if(transform.position != target){
                if(Missile6bool == true){
                Destroy(currentMissile);
                CreateMissile();
                }
                MissileMove();
                Missile6bool = false;
            }
        }
    }

    void CreateMissile(){
        //Debug.Log("here");
            cloneMissile = Instantiate(mainMissile, transform.position, transform.rotation);
            cloneMissile.name = "cloneMissile " + i;
            currentMissile = GameObject.Find("cloneMissile " + i);
            CloneMissileT = currentMissile.transform;
            i ++;
    }

    void MissileMove(){
        CloneMissileT.position += velocity * Time.deltaTime;
        velocity *= (1.0f - (damping * Time.deltaTime));
        desiredTarget = target - CloneMissileT.position;
        desiredTarget.Normalize();
        desiredTarget *= maxSpeed;
        velocity = desiredTarget;
        if (desiredTarget - velocity == arrivevelocity){
            velocity = Vector3.zero;
        }
    }
}


