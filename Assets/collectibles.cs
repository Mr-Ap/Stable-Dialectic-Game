using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectibles : MonoBehaviour {

    public AudioSource collectsound;
    public score score;
    void OnTriggerEnter(Collider other)
    {
        collectsound.Play();
        score.timeincrease();
        Destroy(gameObject);
    }
}
