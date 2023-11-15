using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] GameObject Player;
    DriverController dc;
    [SerializeField] float cameraZoom = -5f;
    // Start is called before the first frame update
    void Awake()
    {
        dc = Player.GetComponent<DriverController>();
    }

    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       

        /*transform.position = Player.transform.position + new Vector3(0, 0f, cameraZoom);

        if (dc.moveSpeed > 0f)
        {
            Camera.current.orthographicSize = 5f;
        }
        else
        {
            Camera.current.orthographicSize = 2.5f;
        }*/
    }

}
