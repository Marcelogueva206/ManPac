using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Build.Content;
using UnityEngine;

public class EatTo : MonoBehaviour
{


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bolita"))
        {
            ScoreEvents.ChangeScore(other.gameObject.GetComponent<Score>().scoreIncrease + ScoreManager.Score);
            
            Destroy(other.gameObject);

        }
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
