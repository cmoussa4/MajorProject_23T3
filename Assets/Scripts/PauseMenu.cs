using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pausemenuUI;
    bool isgamePaused = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isgamePaused)
            {
                Resume();
            }
            else
            {
                Paused();
            }
        }
               
        
    }

    public void Resume()
    {
        isgamePaused = false;
        Time.timeScale = 1f;
        pausemenuUI.SetActive(false);
    }

    public void Paused()
    {
        isgamePaused = true;
        Time.timeScale = 0f;
        pausemenuUI.SetActive(true);
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
}
