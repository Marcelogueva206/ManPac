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

    private Rigidbody rb; 
    public float Velocity;
    private Vector3 HV; 
    private float ScreenHeight, ScreenWidth;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        ScreenHeight = Screen.height; 
        ScreenWidth = Screen.width;
        txt.SetActive(false);
        fade.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        MovimientoTouch();

        
        //transform.position += transform.forward * velocity * Time.deltaTime; 
       if(Input.GetKeyDown(KeyCode.D)|| Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.localRotation = Quaternion.Euler(0, 90, 0);
        }

        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.localRotation = Quaternion.Euler(0, -90, 0);
        }
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        }
    }


    public void MovimientoTouch()
    {
        if (Input.touchCount > 0)
        {

            if (Input.GetTouch(0).position.y > ScreenHeight / 2)
            {
                HV = Vector3.forward * Velocity;
                rb.MovePosition(rb.position + HV * Velocity * Time.deltaTime);
            }

            else if (Input.GetTouch(0).position.y < ScreenHeight / 2)
            {
                HV = Vector3.back * Velocity;
                rb.MovePosition(rb.position + HV * Velocity * Time.deltaTime);
            }


            if (Input.GetTouch(0).position.x < ScreenWidth / 2)
            {
                HV = Vector3.left * Velocity;
                rb.MovePosition(rb.position + HV * Velocity * Time.deltaTime);
            }

            else if (Input.GetTouch(0).position.x > ScreenWidth / 2)
            {
                HV = Vector3.right * Velocity;
                rb.MovePosition(rb.position + HV * Velocity * Time.deltaTime);
            }

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
