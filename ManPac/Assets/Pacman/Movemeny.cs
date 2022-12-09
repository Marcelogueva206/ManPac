using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movemeny : MonoBehaviour
{
    public float velocity;
    public GameObject txt;
    public GameObject fade;
    public bool textAnimation;
    

    void Start()
    {
        txt.SetActive(false);
        fade.SetActive(false);
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

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Fantasma"))
        {

            
            textAnimation = true;
            Destroy(this.gameObject);
            txt.SetActive(true);
            fade.SetActive(true);


        }
    }
}
