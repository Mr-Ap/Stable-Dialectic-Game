using UnityEngine.SceneManagement;
using UnityEngine;
using System.Collections;
public class gamemanager : MonoBehaviour {
    bool gameover = false;
    public float restartdelay=2f;
    public GameObject completelevelUI;
    public GameObject gameoverUI;
    public int flag = 0;
    public void CompleteLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        completelevelUI.SetActive(true);
        

    }
	public void endGame()
    {
        if (gameover == false && flag==0)
        {
            gameover = true;
            Invoke("restart", restartdelay);
        }
    }
    public void endGame1()
    {
        gameoverUI.SetActive(true);
        flag = 1;
        endGame();
    }

    void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
