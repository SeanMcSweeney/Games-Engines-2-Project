using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public abstract class HawkMenController :MonoBehaviour
{
    public float weight = 1.0f;
    public Vector3 force;

    [HideInInspector]
    public HawkMenSB boid;

    public void Awake()
    {
        boid = GetComponent<HawkMenSB>();
    }

    public abstract Vector3 Calculate();
}