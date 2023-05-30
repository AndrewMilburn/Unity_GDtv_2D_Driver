using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage;
    [SerializeField] float packageDelay;
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("OUCH!!");
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Package" && !hasPackage)
        {
            Debug.Log("Package picked up");
            hasPackage = true;
            Destroy(collision.gameObject, packageDelay);
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
