using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class score : MonoBehaviour {
    public Transform Player;
    public gamemanager gm1;
    public Text scoretext;
    public float timerem = 50f;
	// Update is called once per frame
	void Update () {
        timerem =(timerem-Time.deltaTime);
        //timerem = (int)timerem;
        // scoretext.text = Player.position.z.ToString("0");
        if(timerem>0)
            scoretext.text = timerem.ToString("f0");
        else
        {
            gm1.endGame1();
        }
	}
    public void timeincrease()
    {
        timerem += 3;
    }
    public void timestop()
    {
        timerem += 100;
    }
   /* private void OnGUI()
    {
        if(timerem>0)
        {
            GUI.Label(new Rect(100, 100, 200, 1000), "Time : " + timerem);
        }
        else
            GUI.Label(new Rect(100, 100, 200, 1000), "Time's Up! : ");
    }*/
}
