using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightningMovement : MonoBehaviour
{
    float timer = 0;
    float circheight;
    float circwidth;
    float circspeed;
    float timermax;
    Transform pos1;
    void Start()
    {
        pos1 = GameObject.Find("Planet Mongo/Top").GetComponent<Transform>();
        circwidth = Random.Range(50, 300);
        circheight = Random.Range(10, 30);
        circspeed = Random.Range(1, 5);
        timermax = Random.Range(5, 10);
    }

    void Update()
    {
        float stoptime = 20f;
        timer += Time.deltaTime;
        if (timer < stoptime){
        LightningMove();
        }
    }

    void LightningMove()
    { 
        timer += Time.deltaTime * circspeed;
        if (timer >= timermax){
            timer = 0;
        }
        float x = Mathf.Cos (timer) * circwidth;
        float y = 10 * circheight;
        float z = Mathf.Sin (timer) * circwidth;

        transform.position = new Vector3 (x, y, z);
    }
}
