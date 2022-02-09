using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turtle : MonoBehaviour
{
    public GameObject effect;
    public GameObject questboard;
    private bool activated;

    void Start()
    {
        activated = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!activated)
        {
            GameObject e = Instantiate(effect);
            e.transform.position = this.transform.position + new Vector3(.7f, 0.15f, 0.1f);
            activated = true;
            SoundE.playSuccess();
            questboard.GetComponent<TurtleQuest>().complete();
        }    
    }
}
