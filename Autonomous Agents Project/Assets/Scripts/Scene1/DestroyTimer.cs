using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTimer : MonoBehaviour
{
    float timer;
    public float destroyTime;
    void Start()
    {
        if (destroyTime == 0){
        destroyTime = 10;
        }
        timer = 0;
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= destroyTime){
            Destroy(gameObject);
        }
    }
}
