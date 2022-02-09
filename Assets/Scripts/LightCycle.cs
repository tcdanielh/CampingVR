using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightCycle : MonoBehaviour
{
    float rotation;

    void Start()
    {
        rotation = 0f;   
    }

    void Update()
    {
        rotation = rotation + .003f;
        transform.eulerAngles = new Vector3(43, rotation, -62);
        if(rotation >= 360)
        {
            rotation = 0f;
        }
    }
}
