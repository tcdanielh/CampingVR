using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TreeText : MonoBehaviour
{
    public Text FloatingText;

    void Start()
    {
        FloatingText.color = Color.white;
        FloatingText.text = "Hit Tree\nfor Wood";
    }

    public void end()
    {
        FloatingText.text = "Hit Tree\n for More\nWood";
    }
}
