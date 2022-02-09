using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class apple : MonoBehaviour
{
    private GameObject questboard;
    private Renderer rend;
    private bool activated;

    // Start is called before the first frame update
    void Start()
    {
        questboard = GameObject.Find("/Quests/apple");
        rend = this.GetComponent<Renderer>();
        activated = false;
    }

    void Update()
    {
        if (rend.enabled == false && activated == false)
        {
            activated = true;
            SoundE.playSuccess();
            questboard.GetComponent<AppleQuest>().complete();
        }
    }
}
