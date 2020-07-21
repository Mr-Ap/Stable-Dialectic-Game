using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followplayer : MonoBehaviour {

    public Transform player;
    public Vector3 offset;
   // private float speedmouse = 2f;
	// Update is called once per frame
	void Update () {
       // float h = speedmouse * Input.GetAxis("Mouse X");
       // transform.Rotate(0, h, 0);
        transform.position = player.position + offset;
	}
}
