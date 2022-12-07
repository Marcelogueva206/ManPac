using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePacman : MonoBehaviour
{
    //[---Variables---]
    //[Public]
    public Rigidbody rb; 
    public float Velocity;

    //[Private]
    private Vector3 HV;
    void Start()
    {
        rb= GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float H = Input.GetAxisRaw("Horizontal"); 
        float V = Input.GetAxisRaw("Vertical");
        HV = new Vector3(H,V).normalized;
        MoveDirection();
    }
    public void MoveDirection(){
      if(Input.GetKey(KeyCode.W)||Input.GetKey(KeyCode.UpArrow)){
        HV = Vector3.forward * Velocity;
        rb.MovePosition(rb.position + HV * Velocity * Time.deltaTime);
      }else{
         if(Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
            {
        HV = Vector3.back * Velocity;
        rb.MovePosition(rb.position + HV * Velocity * Time.deltaTime);
      }else{
         if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
                {
        HV = Vector3.left * Velocity;
        rb.MovePosition(rb.position + HV * Velocity * Time.deltaTime);
      } else{
         if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
                    {
        HV = Vector3.right * Velocity;
        rb.MovePosition(rb.position + HV * Velocity * Time.deltaTime);
      } 
      }
      } 
      } 
    }
}
