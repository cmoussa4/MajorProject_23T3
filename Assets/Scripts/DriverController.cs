using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class DriverController : MonoBehaviour
{
    [SerializeField] float steerSpeed = 0.1f;
    [SerializeField] public float moveSpeed = 0.001f;
    [SerializeField] TextMeshProUGUI timerDisplay;
    public int timeCount;
    

    // Update is called once per frame
    void Update()
    {
        timeCount = (int)Time.time;

        timerDisplay.text = "Timer: " + timeCount.ToString() + " Seconds";
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float speedAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime; 
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, speedAmount, 0);

        if(timeCount == 100)
        {
            SceneManager.LoadScene(0);
        }
        

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Road"))
        {
            steerSpeed = 250f;
            moveSpeed = 5f;
        }
        else if (collision.gameObject.CompareTag("pavement"))
        {
            steerSpeed = 200f;
            moveSpeed = 3f;
        }
        else
        {
            steerSpeed = 200f;
            moveSpeed = 3f;
        }
    }







}
