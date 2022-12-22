using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Movemeny : MonoBehaviour
{
    public  enum direcion
    {
        right, left, up, down, none
    }


    public float velocity;
    public GameObject txt;
    public GameObject fade;
    public bool textAnimation;

    //private Rigidbody rb; 
    //public float Velocity;
    //private Vector3 HV; 
    //private float ScreenHeight, ScreenWidth;
    public direcion realPacmanDirecion = direcion.none;

    Vector2 pointStarted;
    Vector2 pointEnded;
    void Start()
    {
        pointStarted = new Vector2(0, 0);
        pointEnded = new Vector2(0, 0);
        //rb = GetComponent<Rigidbody>();
        //ScreenHeight = Screen.height; 
        //ScreenWidth = Screen.width;
        txt.SetActive(false);
        fade.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        MovimientoTouch();
        print(realPacmanDirecion);

        
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow)||realPacmanDirecion ==direcion.right)
        {
            transform.localRotation = Quaternion.Euler(0, 90, 0);
        }

        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow) || realPacmanDirecion == direcion.left)
        {
            transform.localRotation = Quaternion.Euler(0, -90, 0);
        }
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow) || realPacmanDirecion == direcion.up)
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow) || realPacmanDirecion == direcion.down)
        {
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        }
        transform.position += transform.forward * velocity * Time.deltaTime;
        realPacmanDirecion = direcion.none;
    }

    Touch usuarioTouch;

    public void MovimientoTouch()
    {
        if (Input.touchCount > 0)
        {
            usuarioTouch = Input.GetTouch(0);
        

            
            if (usuarioTouch.phase == TouchPhase.Began)
            {

                pointStarted = usuarioTouch.position;
                print(usuarioTouch.position + "pulsó");
            }

            

            if (usuarioTouch.phase == TouchPhase.Ended)
            {
                
                pointEnded = usuarioTouch.position;
                print(usuarioTouch.position + " pulsando");


                float diferenceY = pointStarted.y - pointEnded.y;
                float diferenceX = pointStarted.x - pointEnded.x;


                if(Mathf.Abs(diferenceX)- Mathf.Abs(diferenceY) > 0) //x es mayor
                {
                    print(diferenceX);
                    if (diferenceX < 0)
                    {
                        realPacmanDirecion = direcion.right;

                    }
                    else
                    {
                        realPacmanDirecion = direcion.left;
                    }
                }
                else // y es mayor
                {
                    print(diferenceY);
                    if (diferenceY < 0)
                    {
                        realPacmanDirecion = direcion.up;

                    }
                    else
                    {
                        realPacmanDirecion = direcion.down;
                    }
                }



            

             
            }


            //if (Input.GetTouch(0).position.y > ScreenHeight / 2)
            //{
            //    HV = Vector3.forward * Velocity;
            //    rb.MovePosition(rb.position + HV * Velocity * Time.deltaTime);
            //}

            //else if (Input.GetTouch(0).position.y < ScreenHeight / 2)
            //{
            //    HV = Vector3.back * Velocity;
            //    rb.MovePosition(rb.position + HV * Velocity * Time.deltaTime);
            //}


            //if (Input.GetTouch(0).position.x < ScreenWidth / 2)
            //{
            //    HV = Vector3.left * Velocity;
            //    rb.MovePosition(rb.position + HV * Velocity * Time.deltaTime);
            //}

            //else if (Input.GetTouch(0).position.x > ScreenWidth / 2)
            //{
            //    HV = Vector3.right * Velocity;
            //    rb.MovePosition(rb.position + HV * Velocity * Time.deltaTime);
            //}

        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Fantasma"))
        {


            textAnimation = true;
            Destroy(this.gameObject);
            txt.SetActive(true);
            fade.SetActive(true);


        }
    }
}
