using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balljoystick : MonoBehaviour {

    public float movespeed=5.0f;
    public float drag = 0.5f;
    public float terminalrotationspeed = 25.0f;
    public Vector3 movevector{set;get;}
    private Rigidbody rb;
    private Transform camtransform;
	// Use this for initialization
	void Start () {
        rb = gameObject.GetComponent<Rigidbody>();
        rb.maxAngularVelocity = terminalrotationspeed;
        rb.drag = drag;
	}
	
	// Update is called once per frame
	void Update () {
        movevector = PoolInput();
        movevector = rotatewithview();
        move();

	}
    private void move()
    {
        rb.AddForce(movevector * movespeed);
    }
    private Vector3 PoolInput()
    {
        Vector3 dir = Vector3.zero;
        dir.x = Input.GetAxis("Horizontal");
        dir.z = Input.GetAxis("Vertical");
        if(dir.magnitude >1)
        {
            dir.Normalize();
        }
        return dir;
    }
    private Vector3 rotatewithview()
    {
        if(camtransform!=null)
        {
            Vector3 dir = camtransform.TransformDirection(movevector);
            dir.Set(dir.x, 0, dir.z);
            return dir.normalized * movevector.magnitude;
        }
        else
        {
            camtransform = Camera.main.transform;
            return movevector;
        }
    }
}
