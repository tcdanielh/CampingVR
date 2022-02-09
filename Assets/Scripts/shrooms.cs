using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shrooms : MonoBehaviour
{
    private int counter;
    public GameObject puff;
    public GameObject quest;
    public bool full;
    public GameObject questboard;

    void Start()
    {
        counter = 0;
        full = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "mushroom")
        {
            if(other.gameObject.GetComponent<mushOnce>().use)
            {
                other.gameObject.GetComponent<mushOnce>().setUse();
                counter += 1;
                if (counter == 4)
                {
                    SoundE.playSuccess();
                    GameObject p = Instantiate(puff);
                    p.transform.position = this.transform.position;
                    full = true;
                    quest.GetComponent<MushroomCounter>().end();
                    questboard.GetComponent<MushroomQuest>().complete();
                }
                else
                {
                    quest.GetComponent<MushroomCounter>().change(counter);
                    SoundE.playHit();
                }   

            }
        }
    }
}
