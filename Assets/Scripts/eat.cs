using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eat : MonoBehaviour
{
    public AudioSource munch;
    public GameObject effect;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "edible")
        {
            other.GetComponent<Renderer>().enabled = false;
            GameObject m = Instantiate(effect);
            m.transform.position = other.transform.position;
            munch.Play();
            other.tag = "Untagged";
        }
    }
}
