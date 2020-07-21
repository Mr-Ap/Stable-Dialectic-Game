using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EndTrigger : MonoBehaviour {
    public AudioSource clip;
    public AudioSource clap;
    public gamemanager gamemanager;
    public score timestop;
    void OnTriggerEnter()
    {
        timestop.timestop();
        gamemanager.CompleteLevel();
        clip.Pause();
        clap.Play();
    }
}
