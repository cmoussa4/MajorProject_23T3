using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class DriverControllerTwo : MonoBehaviour
{
    [SerializeField] float steerSpeed = 250f;
    [SerializeField] public float moveSpeed = 5f;
    [SerializeField] TextMeshProUGUI timerDisplay;
    DeliverySystemTwo ds2;
    public int timeCount;
    [SerializeField] AudioSource engine;
    [SerializeField] AudioSource shakeSFX;
    [SerializeField] TrailRenderer skidmark1;
    [SerializeField] TrailRenderer skidmark2;
    private Shake shake;

    private void Awake()
    {
        shake = GameObject.FindGameObjectWithTag("ScreenShake").GetComponent<Shake>();
        ds2 = GetComponent<DeliverySystemTwo>();
    }
    // Update is called once per frame
    void Update()
    {
        PlayEngine();
        timeCount = 100;
  
        timeCount -= (int)Time.time;
        
        timerDisplay.text = "Timer: " + timeCount.ToString() + " Seconds";
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float speedAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, speedAmount, 0);

        if(timeCount == 0)
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
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Road"))
        {
            steerSpeed = 250f;
            moveSpeed = 5f;
        }
       
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
       steerSpeed = 200f;
       moveSpeed = 3f;
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        shake.ShakeFunction();
        shakeSFX.time = 0.3f;
        shakeSFX.Play();
    }


    private void PlayEngine()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        {
            engine.Play();
            skidmark1.emitting = true;
            skidmark2.emitting = true;
        }
        if (Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.W))
        {
            engine.Pause();
            skidmark1.emitting = false;
            skidmark2.emitting = false;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
        {
            engine.Play();
            skidmark1.emitting = true;
            skidmark2.emitting = true;
        }

        if (Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyUp(KeyCode.S))
        {
            engine.Play();
            skidmark1.emitting = false;
            skidmark2.emitting = false;
        }
    }






}
