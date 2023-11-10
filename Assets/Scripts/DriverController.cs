using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DriverController : MonoBehaviour
{
    [SerializeField] float steerSpeed = 0.1f;
    [SerializeField] public float moveSpeed = 0.001f;
    private GameObject package;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed;
        float speedAmount = Input.GetAxis("Vertical") * moveSpeed;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, speedAmount, 0);
    }





}
