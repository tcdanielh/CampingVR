using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurtleQuest : MonoBehaviour
{
    public Text TurtleText;
    void Start()
    {
        TurtleText.text = "???";
        TurtleText.color = Color.white;
    }

    public void complete()
    {
        TurtleText.text = "Pet the Turtle";
        TurtleText.color = Color.green;
    }
}
