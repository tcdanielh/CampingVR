using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wing : MonoBehaviour
{
    private GameObject questboard;
    private Renderer rend;

    private bool activated;

    void Start()
    {
        questboard = GameObject.Find("/Quests/chicken");
        rend = this.GetComponent<Renderer>();
    }

    void Update()
    {
        if (rend.enabled == false && activated == false)
        {
            activated = true;
            SoundE.playSuccess();
            questboard.GetComponent<ChickenQuest>().complete();
        }
    }
}
