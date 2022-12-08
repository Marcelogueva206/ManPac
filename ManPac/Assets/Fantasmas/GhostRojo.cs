using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GhostRojo : MonoBehaviour
{
    public NavMeshAgent GhostRed;
    public GameObject pacman;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GhostRed.destination = pacman.transform.position;
    }
}
