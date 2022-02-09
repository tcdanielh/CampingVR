using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CampfireQuest : MonoBehaviour
{
    public Text CampfireText;

    void Start()
    {
        CampfireText.text = "Start a Campfire";
        CampfireText.color = Color.white;
    }

    public void complete()
    {
        CampfireText.color = Color.green;
    }
}
