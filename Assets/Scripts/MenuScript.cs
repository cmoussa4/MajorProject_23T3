using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    private Canvas canvas;

    private void Start()
    {
        if (canvas != null)
        {
            canvas = GameObject.FindGameObjectWithTag("Canvas").GetComponent<Canvas>();
        }
        
    }
    public void Play()
    {
        SceneManager.LoadScene(1);
    }

   public void Play1()
    {
        SceneManager.LoadScene(2);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Back()
    {
        SceneManager.LoadScene(0);
    }

    public void DeleteCanvas()
    {
        if(canvas!= null)
        {
            Destroy(canvas);
        }   
    }
}
