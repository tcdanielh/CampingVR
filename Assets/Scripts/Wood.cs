using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wood : MonoBehaviour
{
    public GameObject stick;
    public GameObject effect;
    private int counter;

    void Start()
    {
        counter = 0;
    }

    void Update()
    {
        if (counter >= 5)
        {
            print("called");
            spawnWood();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Vector3 location = other.gameObject.GetComponent<Collider>().ClosestPointOnBounds(transform.position);
        GameObject e = Instantiate(effect);
        e.transform.position = location;
        SoundE.playHit();
        if (other.gameObject.tag == "axe")
        {
            counter += 2;
        }
        else
        {
            counter += 1;
        }
    }

    private void spawnWood()
    {
        GameObject wood = Instantiate(stick);
        wood.transform.position = this.transform.position + new Vector3(Random.Range(-.3f, 0.8f), 8f, -.6f);
        counter = 0;
    }
}
