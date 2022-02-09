using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MushroomQuest : MonoBehaviour
{
    public Text MushroomText;

    void Start()
    {
        MushroomText.text = "Collect Mushrooms";
        MushroomText.color = Color.white;
    }

    public void complete()
    {
        MushroomText.color = Color.green;
    }
}
