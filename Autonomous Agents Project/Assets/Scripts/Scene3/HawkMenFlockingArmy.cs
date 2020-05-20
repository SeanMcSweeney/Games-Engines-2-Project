using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HawkMenFlockingArmy : MonoBehaviour
{
    public List<GameObject> hawkmenflock = new List<GameObject>();
    public GameObject hawkmen;
    void Start()
    {
        int armysize = 30;
        for (int i = 0; i < armysize; i++)
        {
            Vector3 newpos = GameObject.Find("SkyArmy/HawkMen1").GetComponent<Transform>().position;
            newpos.x += (Random.Range(-5f, 5f));
            newpos.y += (Random.Range(-5f, 5f));
            newpos.z += (Random.Range(-5f, 5f));

            GameObject newHawk = Instantiate(hawkmen, newpos, Quaternion.identity);
            string name = "FlockingHawk " + i;
            newHawk.name = name;
            newHawk.transform.SetParent(GameObject.Find("SkyArmy").GetComponent<Transform>());
            newHawk.AddComponent<HawkMenDecision>();
            hawkmenflock.Add(newHawk);

        }
    }

}
