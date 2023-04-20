using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    float _fturnSpeed = 1;
    float _fmoveSpeed = 0.01f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, _fturnSpeed);
        transform.Translate(0, _fmoveSpeed, 0);
    }
}
