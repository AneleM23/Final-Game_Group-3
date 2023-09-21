using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuScript : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject panel;

    public void StartGame()
    {
        Time.timeScale = 2f;
        SceneManager.LoadScene(1);
    }

    public void Instructions()
    {
        Time.timeScale = 2f;
        SceneManager.LoadScene(2);
    }

    public void BackToMenu()
    {
        Time.timeScale = 2f;
        SceneManager.LoadScene(0);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        panel.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        panel.SetActive(true);
        Time.timeScale = 1f;
        GameIsPaused = true;
    }

    public void QuitGame()
    {
        Debug.Log("I Quit...");
        Time.timeScale = 2f;
        Application.Quit();
    }
}
