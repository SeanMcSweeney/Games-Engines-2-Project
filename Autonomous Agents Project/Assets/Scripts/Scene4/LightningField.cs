using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightningField : MonoBehaviour
{
    Transform pos1;
    void Start()
    {
        pos1 = GameObject.Find("Planet Mongo/Top").GetComponent<Transform>();
    }

    void Update()
    {
        
    }
}
