using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using System;

public class AudioManager : MonoBehaviour
{
    //Public Sound array.
    public SoundManager[] sounds;
    //Call an AudioManager Instance.
    public static AudioManager instance;

    //        FindObjectOfType<AudioManager>().Play("Gas");


    private void Start()
    {
        FindObjectOfType<AudioManager>().Play("BirdAmbience");
        FindObjectOfType<AudioManager>().Play("Theme");
    }


    // Start is called before the first frame update
    void Awake()
    {
        //If no instance then 
        if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);
        foreach (SoundManager s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
            s.source.spatialBlend = s.spatialBlend;
        }
    }

    public void Play(string name)
    {
        //Debug should the sound not be located.
        SoundManager s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("Sound: " + name + "not found!");
            return;
        }
        s.source.Play();
    }
}
