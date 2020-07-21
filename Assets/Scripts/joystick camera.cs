using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class joystickcamera : MonoBehaviour {
    private const float y_angle_min = 0.0f;
    private const float y_angle_max = 180.0f;
    //
    private Transform thistransform;
    private Camera cam;
    public Transform camtransform { set; get; }
    private float distance = 10.0f;
    private float currentx=0.0f;
    private float currenty = 0.0f;
    private float sensivityx = 4.0f;
    private float sensivityy = 1.0f;

	// Use this for initialization
	private void Start () {
        camtransform = new GameObject("Camera Container").transform;
        cam = camtransform.gameObject.AddComponent<Camera>();
        cam.tag = "MainCamera";
        thistransform = transform;
	}
	
	// Update is called once per frame
	private void Update () {
		

	}
}
