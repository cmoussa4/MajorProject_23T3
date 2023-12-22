using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class DriverControllerTwo : MonoBehaviour
{
    [SerializeField] float steerSpeed = 0.1f;
    [SerializeField] public float moveSpeed = 0.001f;
    [SerializeField] TextMeshProUGUI timerDisplay;
    public int timeCount;
    DeliverySystemTwo ds2;


    private void Start()
    {
        ds2 = GetComponent<DeliverySystemTwo>();
    }
    // Update is called once per frame
    void Update()
    {
        timeCount = 100;
  
        timeCount -= (int)Time.time;
        
        timerDisplay.text = "Timer: " + timeCount.ToString() + " Seconds";
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float speedAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, speedAmount, 0);

        if(timeCount == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

    }









}
