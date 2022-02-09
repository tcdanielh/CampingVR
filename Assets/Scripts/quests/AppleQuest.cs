using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AppleQuest : MonoBehaviour
{
    public Text AppleText;

    void Start()
    {
        AppleText.text = "???";
        AppleText.color = Color.white;
    }

    public void complete()
    {
        AppleText.text = "Eat the Squirrel's Apple";
        AppleText.color = Color.green;
    }
}
