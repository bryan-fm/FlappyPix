using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public AudioClip bg;
    public AudioClip siren;
    private AudioSource audio;
    public bool bgSound = true;
    public int score;
    public Text scoreText;

    void Start()
    {
        Time.timeScale = 1;
        audio = GetComponent<AudioSource>();
        audio.clip = bg;
        //audio.Play();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 0) {
            audio.clip = siren;
            //audio.Play();
        } 
    }

    public void RestartGame() {
        SceneManager.LoadScene(0);
    }
}
