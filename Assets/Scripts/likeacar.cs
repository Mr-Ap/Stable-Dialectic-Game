using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class likeacar : MonoBehaviour {

    public GameObject Ball;
    public float BallX;
    public float BallY;
    public float BallZ;
	
	// Update is called once per frame
	void Update () {
        BallX = Ball.transform.eulerAngles.x;
        BallY = Ball.transform.eulerAngles.y;
        BallZ = Ball.transform.eulerAngles.z;

        transform.eulerAngles = new Vector3(BallX - BallX, BallY, BallZ - BallZ);
    }
}
