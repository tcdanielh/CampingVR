using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mushOnce : MonoBehaviour
{
    public bool use;
    private GameObject check;

    void Start()
    {
        use = true;
        check = GameObject.Find("/Mushrooms/CRATE/check");
    }

    public void setUse()
    {
        use = false;
    }

    void Update()
    {
        if (check.GetComponent<shrooms>().full == true)
        {
            this.tag = "edible";
        }
    }
}
