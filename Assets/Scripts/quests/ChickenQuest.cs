using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChickenQuest : MonoBehaviour
{
    public Text ChickenText;

    void Start()
    {
        ChickenText.text = "Eat a Chicken Wing";
        ChickenText.color = Color.white;
    }

    public void complete()
    {
        ChickenText.color = Color.green;
    }
}
