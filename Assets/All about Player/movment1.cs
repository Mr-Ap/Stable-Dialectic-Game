using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movment1 : MonoBehaviour {
    public Rigidbody rb;
    public float frwforce = 200f;
    public float backforce = 50f;
    public float sideforce = 200f;
    public gamemanager gamemanager;
    public CameraSwitch cs;
	// Update is called once per frame
	void FixedUpdate ()
    {
        if (Input.GetKey("w"))
        {
            rb.AddForce(-frwforce * Time.deltaTime,0,0,ForceMode.VelocityChange);
        }

        if (Input.GetKey("s"))
        {
            rb.AddForce(backforce * Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(0,0,sideforce * Time.deltaTime,ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(0,0,-sideforce * Time.deltaTime,ForceMode.VelocityChange);
        }
        if(Input.GetKey("e"))
        {
            rb.AddForce(0, 10f * Time.deltaTime, 0,ForceMode.VelocityChange);
        }

        if (rb.position.y < -10f)
            FindObjectOfType<gamemanager>().endGame();
        if(Input.GetKey("c"))
        {
            FindObjectOfType<CameraSwitch>();
        }

        
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Picks"))
        {
            other.gameObject.SetActive(false);
        }
    }

}

