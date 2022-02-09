using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class MushroomCounter : MonoBehaviour
{
    private int count;
    public Text CrateText;

    void Start()
    {
        count = 0;
        CrateText.color = Color.white;
        //CrateText.text = count.ToString() + "/4" + Environment.NewLine + "mushrooms";
        CrateText.text = count.ToString() + "/4\nmushrooms";

    }

    public void change(int n)
    {
        count = n;
        CrateText.text = count.ToString() + "/4\nmushrooms";
    }

    public void end()
    {
        CrateText.text = "4/4";
        CrateText.color = Color.green;
    }
}
