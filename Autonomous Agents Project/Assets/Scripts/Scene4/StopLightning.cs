using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopLightning : MonoBehaviour
{
    float timer = 0;
    void Update()
    {
        float stoptime = 40f;
        timer += Time.deltaTime;
        if (timer <= stoptime){
        }
        else {
            //Debug.Log("stopped");
            stopLightning();
        }
    }

    void stopLightning()
    {
        GameObject go = GameObject.Find("Lightning Field");
        (go).SetActive(false);
    }
}
