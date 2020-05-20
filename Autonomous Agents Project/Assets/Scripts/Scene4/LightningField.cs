using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightningField : MonoBehaviour
{
    Transform pos1;
    void Start()
    {
        pos1 = GameObject.Find("Planet Mongo/Top").GetComponent<Transform>();
        int particles = 80;
        for (int i = 0; i < particles; i++)
        {
        GameObject lf = GameObject.Find("Lightning Field/Lightning");
        GameObject newlf = Instantiate(lf, transform.position, Quaternion.identity);
            string name = "lf " + i;
            newlf.name = name;
            newlf.transform.SetParent(GameObject.Find("Lightning Field").GetComponent<Transform>());
            newlf.AddComponent<LightningMovement>();
        }
    }
}
