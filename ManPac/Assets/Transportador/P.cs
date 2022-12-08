using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P : MonoBehaviour
{
    public float time;
    public float limite;
    public Collider portalOneCollider;
    public Collider portalTwoCollider;
    public GameObject portalOne;
    public GameObject portalTwo;
    public bool pOneActive;
    public bool pTwoActive;

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("portalOne"))
        {
            portalTwoCollider.enabled = false;  
            transform.position = portalTwo.transform.position;
            pTwoActive = false;
        }

        if (other.gameObject.CompareTag("portalTwo"))
        {
            portalOneCollider.enabled = false;
            transform.position = portalOne.transform.position;
            pOneActive = false;
        }
    }

    void Start()
    {
        
    }

    
    void Update()
    {
        if (!pOneActive || !pTwoActive)
        {
            time += Time.deltaTime; 
        }
        if(time > limite)
        {
            portalTwoCollider.enabled = true;
            portalOneCollider.enabled = true;
            time = 0;
        }
       
    }
}
