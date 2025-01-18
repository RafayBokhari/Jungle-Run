using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject startgamepanel;
    public GameObject gameoverpanel;
    public static UIManager uI;


    private void Awake()
    {
        if(uI == null)
        {
            uI = this;
        }
    }

    private void Start()
    {
            startgamepanel.SetActive(true);
        gameoverpanel.SetActive(false);
        Time.timeScale =  0f;
    }

    public void StartGame()
    {
        startgamepanel.SetActive(false);
        Time.timeScale = 1f;
    }
    public void Gameover()
    {
        gameoverpanel.SetActive(true );
       // Time.timeScale = 0f;
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void TryAgain()
    {
       
        SceneManager.LoadScene("Game");
        //startgamepanel.SetActive(false );
    }

}