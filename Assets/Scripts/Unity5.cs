using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unity5 : MonoBehaviour {
    public float speed=10f;
    private Rigidbody rb;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void fixedUpdate () {
        float movehor = Input.GetAxis("Horizontal");
        float movever = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(movehor, 0.0f, movever);
        rb.AddForce(movement * speed);
	}
}
