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
  

  
    public direcion realPacmanDirecion = direcion.none;

    Vector2 pointStarted;
    Vector2 pointEnded;
    void Start()
    {
        print("eliminé el movimiento por teclado, ahora solo el pacam se puede mover con el mouse o por la pantalla tactil");
        pointStarted = new Vector2(0, 0);
        pointEnded = new Vector2(0, 0);
    }

    void Update()
    {

        MovimientoTouch();
      
       
        if (realPacmanDirecion ==direcion.right)
        {
            transform.localRotation = Quaternion.Euler(0, 90, 0);
        }

        if ( realPacmanDirecion == direcion.left)
        {
            transform.localRotation = Quaternion.Euler(0, -90, 0);
        }
        if ( realPacmanDirecion == direcion.up)
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }

        if ( realPacmanDirecion == direcion.down)
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
            }

 
            if (usuarioTouch.phase == TouchPhase.Ended)
            {
                
                pointEnded = usuarioTouch.position;


                float diferenceY = pointStarted.y - pointEnded.y;
                float diferenceX = pointStarted.x - pointEnded.x;


                if(Mathf.Abs(diferenceX)- Mathf.Abs(diferenceY) > 0) //x es mayor
                {
                    
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


          
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Fantasma"))
        {

            GameEvents.PacmanDeath.Invoke();
            Destroy(this.gameObject);
            


        }
    }
}
