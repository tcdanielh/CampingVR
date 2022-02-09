using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chicken : MonoBehaviour
{
    public GameObject wing;
    public GameObject BloodEffect;
    public GameObject DieExplosionEffect;
    public GameObject HP;

    public AudioSource hitSound;
    public AudioSource deathSound;

    private SkinnedMeshRenderer smr;
    private BoxCollider bc;
    
    private int health;

    void Start()
    {
        smr = GetComponentInChildren<SkinnedMeshRenderer>();
        bc = GetComponent<BoxCollider>();
        health = 100;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "axe")
        {
            health = 0;
            HP.GetComponent<ChickenHP>().setHP(health);
        }
        else
        {
            health -= 10;
            HP.GetComponent<ChickenHP>().setHP(health);
        }
        if (health <= 0)
        {
            HP.GetComponent<ChickenHP>().setHP(health);
            Death();
        }
        else
        {
            Vector3 location = other.gameObject.GetComponent<Collider>().ClosestPointOnBounds(transform.position);
            Blood(location);
            hitSound.Play();
        }
    }

    private void Blood(Vector3 l)
    {
        GameObject effect = Instantiate(BloodEffect);
        effect.transform.position = l;
    }

    private void Death()
    {
        HP.GetComponent<ChickenHP>().end();
        deathSound.Play();
        smr.enabled = false;
        bc.enabled = false;

        GameObject w = Instantiate(wing);
        GameObject effect = Instantiate(DieExplosionEffect);
        w.transform.position = this.transform.position + new Vector3(0f, .3f, 0f);
        effect.transform.position = this.transform.position;

        Rigidbody rb = w.GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0f, 2f, 0f);
    }
}
