using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manager : MonoBehaviour
{
    public int wood;

    GameObject fire;
    GameObject smoke;

    public GameObject effect;
    public GameObject effect2;
    public GameObject effect3;
    public GameObject quest;
    public GameObject quest2;
    public GameObject questboard;
    public GameObject treetext;

    public bool started;
    private Rigidbody rb;

    void Start()
    {
        fire = GameObject.Find("/Campfire/FX_Fire");
        smoke = GameObject.Find("/Campfire/FX_Smoke");
        fire.SetActive(false);
        smoke.SetActive(false);
        started = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (started == false)
        {
            if (other.gameObject.tag == "wood")
            {
                wood += 1;
                GameObject puff = Instantiate(effect3);
                puff.transform.position = other.gameObject.transform.position;
                //other.gameObject.SetActive(false);
                other.tag = "Untagged";
                other.GetComponent<Renderer>().enabled = false;
                SoundE.playDrop();
                if (wood < 3)
                {
                    quest.GetComponent<WoodCounter>().change(wood);
                    quest2.GetComponent<WoodCounter>().change(wood);
                }
                else
                {
                    quest.GetComponent<WoodCounter>().full();
                    quest2.GetComponent<WoodCounter>().full();
                }
            }
            else
            {
                if (other.gameObject.tag == "starter")
                {
                    if(wood >= 3)
                    {
                        GameObject poof = Instantiate(effect);
                        poof.transform.position = this.transform.position;
                        fire.SetActive(true);
                        smoke.SetActive(true);
                        SoundE.playSuccess();
                        started = true;
                        quest.GetComponent<WoodCounter>().end();
                        quest2.GetComponent<WoodCounter>().end();
                        questboard.GetComponent<CampfireQuest>().complete();
                        treetext.GetComponent<TreeText>().end();
                    }
                    else
                    {
                        SoundE.playFail();
                    }       
                }
                SoundE.playHit();
                sendBack(other);
            }
        }
        else
        {
            if (other.gameObject.tag == "wood")
            {
                GameObject poof = Instantiate(effect2);
                poof.transform.position = this.transform.position;
                //other.gameObject.SetActive(false);
                other.tag = "Untagged";
                other.GetComponent<Renderer>().enabled = false;
                SoundE.playExplosion();
            }
            else
            {
                SoundE.playHit();
                sendBack(other);
            }
        }
    }

    private void sendBack(Collider other)
    {
        rb = other.gameObject.GetComponent<Rigidbody>();
        other.gameObject.transform.position += new Vector3(0f, .3f, 0f);
        if (Mathf.Abs(rb.velocity.x) < .5f || Mathf.Abs(rb.velocity.z) < .5f)
        {
            rb.velocity = new Vector3(-rb.velocity.x * Mathf.Abs(.5f / rb.velocity.x), -1.5f * rb.velocity.y, -rb.velocity.z * Mathf.Abs(.5f / rb.velocity.z));
        }
        else
        {
            rb.velocity = new Vector3(rb.velocity.x * -1.2f, -1.5f * rb.velocity.y, rb.velocity.z * -1.2f);
        }
    }
}
