using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HawkMenArmy : MonoBehaviour
{
    public float amount;
    public Vector3 centercirc;

    void Start()
    {
        amount = 200f;
        CreateArmy();
    }

    void Update()
    {
        
    }

    public void CreateArmy(){
        float spacer = 0.5f;
        float rows = 4f;
            for (int b = 0; b <= rows; b++)
            {
                if (b % 2 == 1){
                    for (int i = 0; i < amount; i++)
                    {
                        GameObject HawkMan = GameObject.Find("SkyArmy/HawkMen1");
                        GameObject HawkManSetPos = Instantiate(HawkMan, transform.position, Quaternion.identity);
                        Vector3 newpos = HawkManSetPos.transform.position;
                        newpos.x -= i ;
                        newpos.z -= b ;
                        HawkManSetPos.transform.position = newpos;
                        HawkManSetPos.name = "HawkMan " + (i + 1) + " Row " + (b + 1);
                        HawkManSetPos.transform.SetParent(GameObject.Find("HawkMen").GetComponent<Transform>());
                    }
                }
                if (b % 2 == 0){
                    for (int i = 0; i < amount; i++)
                    {
                        GameObject HawkMan = GameObject.Find("SkyArmy/HawkMen1");
                        GameObject HawkManSetPos = Instantiate(HawkMan, transform.position, Quaternion.identity);
                        Vector3 newpos = HawkManSetPos.transform.position;
                        newpos.x -= i + 0.5f;
                        newpos.z -= b ;
                        HawkManSetPos.transform.position = newpos;
                        HawkManSetPos.name = "HawkMan " + (i + 1) + " Row " + (b + 1);
                        HawkManSetPos.transform.SetParent(GameObject.Find("HawkMen").GetComponent<Transform>());
                    }
                }
            }
    }
}
