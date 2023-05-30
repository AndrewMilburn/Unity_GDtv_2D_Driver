using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage;
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("OUCH!!");
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Package")
        {
            Debug.Log("Package picked up");
            hasPackage = true;
        }
        else if(collision.tag == "Customer" && hasPackage)
        {
            Debug.Log("Package delivered");
            hasPackage = false;
        }
        else
        {
            Debug.Log("SQUISH!!");
        }
    }
}
