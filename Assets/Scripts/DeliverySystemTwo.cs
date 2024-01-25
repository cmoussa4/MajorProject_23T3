using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class DeliverySystemTwo : MonoBehaviour
{
    public int packages = 0;
    [SerializeField] TextMeshProUGUI packCount;
    bool packHeld = false;
    [SerializeField] TextMeshProUGUI packDisplay;
    SpriteRenderer spriteRender;
    [SerializeField] GameObject[] Customers;
    [SerializeField] GameObject pickUp;
    [SerializeField] GameObject popUp;
    [SerializeField] AudioSource pickupSFX;
    [SerializeField] AudioSource DeliveredSFX;

    private void Awake()
    {
        spriteRender = GetComponent<SpriteRenderer>();
        
    }


    void Update()
    {
        packCount.SetText("Packages delivered: " + packages);

        if (packHeld)
        {
            packDisplay.SetText("Carrying package");

        }
        else
        {
            packDisplay.SetText("No package held");

        }

        if(packages == 4)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
           
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Package") && !packHeld)
        {
            Instantiate(pickUp, transform.position, Quaternion.identity);
            Customers[Random.Range(0, Customers.Length - 1)].tag = "Customer";
            GameObject.FindGameObjectWithTag("Customer").gameObject.GetComponent<SpriteRenderer>().color = Color.green;

            Destroy(collision.gameObject, 0.1f);
            pickupSFX.Play();
            packHeld = true;
            spriteRender.color = Color.cyan;

        }

    }
    public void OnCollisionEnter2D(Collision2D collision)
    { 



        if (collision.gameObject.CompareTag("Customer") && packHeld)
        {
            Instantiate(popUp, GameObject.FindGameObjectWithTag("Customer").transform.position, Quaternion.identity);
            foreach (GameObject customer in Customers)
            {
                customer.tag = "Untagged";
                customer.GetComponent<SpriteRenderer>().color = Color.white;
            }
            DeliveredSFX.time = 0.8f;
            DeliveredSFX.Play();

            packages++;
            packHeld = false;
          
            spriteRender.color = Color.yellow;
        }

    }


}
