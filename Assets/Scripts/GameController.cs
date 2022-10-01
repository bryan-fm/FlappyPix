using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public AudioClip bg;
    public AudioClip siren;
    private AudioSource audio;
    public bool bgSound = true;

    void Start()
    {
        audio = GetComponent<AudioSource>();
        audio.clip = bg;
        audio.Play();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 0) {
            audio.clip = siren;
            audio.Play();
        } 
    }
}
