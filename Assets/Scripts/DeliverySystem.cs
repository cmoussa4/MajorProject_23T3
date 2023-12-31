using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DeliverySystem : MonoBehaviour
{
    int packages = 0;
    [SerializeField] TextMeshProUGUI packCount;
    bool packHeld = false;
    [SerializeField] TextMeshProUGUI packDisplay;
    SpriteRenderer spriteRender;
    [SerializeField] GameObject[] Customers;
    [SerializeField] GameObject pickUp;
    
    
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
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Package") && !packHeld)
        {
            Instantiate(pickUp, transform.position, Quaternion.identity);
            Customers[Random.Range(0, Customers.Length-1)].tag = "Customer";
            GameObject.FindGameObjectWithTag("Customer").gameObject.GetComponent<SpriteRenderer>().color = Color.green;
            
            Destroy(collision.gameObject, 0.1f);

            packHeld = true;
            spriteRender.color = Color.cyan;

        }

        if (collision.gameObject.CompareTag("Speedboost"))
        {
            Destroy(collision.gameObject);
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        


        if (collision.gameObject.CompareTag("Customer") && packHeld)
        {
            foreach(GameObject customer in Customers)
            {
                customer.tag = "Untagged";
                customer.GetComponent<SpriteRenderer>().color = Color.white;
            }

            
            packages++;
            packHeld = false;

            spriteRender.color = Color.yellow;
        }

    }

  
}
