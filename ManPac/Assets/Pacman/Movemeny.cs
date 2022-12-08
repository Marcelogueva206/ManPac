using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movemeny : MonoBehaviour
{
    public float velocity;
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.position += transform.forward * velocity * Time.deltaTime; 
       if(Input.GetKeyDown(KeyCode.D))
        {
            transform.localRotation = Quaternion.Euler(0, 90, 0);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.localRotation = Quaternion.Euler(0, -90, 0);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        }
    }
}
