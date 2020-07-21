using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nilesh : MonoBehaviour {
    private CharacterController p;
    public float speedMouse = 10f;
    private Vector3 moveDir =Vector3.zero;
    public float speed = 20f;
	// Use this for initialization
	void Start () {
        p = gameObject.GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
        moveDir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        moveDir = transform.TransformDirection(moveDir);
        moveDir = moveDir * speed;
        p.Move(moveDir * Time.deltaTime);
        float h = speedMouse * Input.GetAxis("Mouse X");
        transform.Rotate(0, h, 0);
	}
}
