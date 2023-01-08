using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventsManager : MonoBehaviour
{
    public GameObject txt;
    public GameObject fade;
    public bool textAnimation;

    void Start()
    {
        GameEvents.PacmanDeath += GameOverEvent;
        txt.SetActive(false);
        fade.SetActive(false);
    }


    void Update()
    {
        
    }

    public void GameOverEvent()
    {
        textAnimation = true;
        Destroy(this.gameObject);
        txt.SetActive(true);
        fade.SetActive(true);
    }

}


static public class GameEvents
{
    public static Action PacmanDeath;


}
