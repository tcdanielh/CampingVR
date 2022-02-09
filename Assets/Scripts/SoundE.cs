using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundE : MonoBehaviour
{
    public static AudioSource sound1;
    public static AudioSource sound2;
    public static AudioSource sound3;
    public static AudioSource sound4;
    public static AudioSource sound5;

    public AudioSource sound11;
    public AudioSource sound22;
    public AudioSource sound33;
    public AudioSource sound44;
    public AudioSource sound55;
        
    // Start is called before the first frame update
    void Start()
    {
        sound1 = sound11;
        sound2 = sound22;
        sound3 = sound33;
        sound4 = sound44;
        sound5 = sound55;
    }

    public static void playDrop()
    {
        sound1.Play();
    }
    public static void playHit()
    {
        sound2.Play();
    }
    public static void playFail()
    {
        sound3.Play();
    }
    public static void playSuccess()
    {
        sound4.Play();
    }
    public static void playExplosion()
    {
        sound5.Play();
    }
}
