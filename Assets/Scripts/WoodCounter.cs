using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WoodCounter : MonoBehaviour
{
    private int count;
    public Text WoodText;

    void Start()
    {
        count = 0;
        WoodText.color = Color.white;
        WoodText.text = count.ToString() + "/3";
    }

    public void change(int n)
    {
        if (n < 3)
        {
            count = n;
            WoodText.text = count.ToString() + "/3";
        }
    }

    public void full()
    {
        WoodText.text = "3/3";
        WoodText.color = Color.green;
    }

    public void end()
    {
        WoodText.text = "";
    }
}
