using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float _fturnSpeed;
    [SerializeField] float _fmoveSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * _fturnSpeed;
        float speedAmout = Input.GetAxis("Vertical") * _fmoveSpeed;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, speedAmout, 0);
    }
}
