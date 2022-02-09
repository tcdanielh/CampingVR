using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgMusic : MonoBehaviour
{
    public AudioSource Track1;
    public AudioSource Track2;
    public AudioSource Track3;

    public int select;
    public int hist;

    void Start()
    {
        select = -1;
        hist = -1;
    }

    void pickSong()
    {
        select = Random.Range(0, 3);
        while(select == hist)
        {
            select = Random.Range(0, 3);
        }
        hist = select;
    }

    void playSong()
    {
        if (select == 0)
        {
            Track1.Play();
        }
        else if (select == 1)
        {
            Track2.Play();
        }
        else if (select  == 3)
        {
            Track3.Play();
        }
    }

    void Update()
    {
        if(Track1.isPlaying == false && Track2.isPlaying == false && Track3.isPlaying == false)
        {
            pickSong();
            playSong();
        }
    }
}
