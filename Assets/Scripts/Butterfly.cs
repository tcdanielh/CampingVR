using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Butterfly : MonoBehaviour
{
    float time = 0;

    void Update()
    {
        time += 0.75f * Time.deltaTime;
        float x = 1.4f * Mathf.Cos(time) + 17;
        float y = -.5f;
        float z = 1.4f * Mathf.Sin(time) + 2;
        transform.position = new Vector3(x, y, z);
        transform.eulerAngles = new Vector3(0, 180f * (transform.position.x - 17), 0);
    }
}
