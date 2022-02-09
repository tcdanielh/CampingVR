using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChickenHP : MonoBehaviour
{
    public Text HPText;
    private int hp;

    void Start()
    {
        hp = 100;
        HPText.text = hp.ToString();
        HPText.color = Color.green;
    }

    public void setHP(int n)
    {
        hp = n;
        updateHP();
    }

    public void updateHP()
    {
        if(hp >= 80)
        {
            HPText.color = Color.green;
        }
        else if(hp >= 60)
        {
            HPText.color = Color.yellow;
        }
        else if(hp >= 40)
        {
            HPText.color = new Color(1f, .55f, 0);
        }
        else if(hp <= 20)
        {
            HPText.color = Color.red;
        }

        HPText.text = hp.ToString();
    }

    public void end()
    {
        HPText.text = "";
    }
}
