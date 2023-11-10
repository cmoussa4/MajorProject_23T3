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
    private void Start()
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
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Package") && !packHeld)
        {

            Destroy(collision.gameObject, 0.2f);

            packHeld = true;
            spriteRender.color = Color.cyan;

        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {



        if (collision.gameObject.CompareTag("Customer") && packHeld)
        {
            packages++;
            packHeld = false;

            spriteRender.color = Color.yellow;
        }

    }
}
