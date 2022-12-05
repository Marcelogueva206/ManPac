using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{

    public static int Score = 0;

    // Start is called before the first frame update
    void Start()
    {
        ScoreEvents.ChangeScore += ChangeScore;
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeScore(int amount)
    {
        Score= amount;
    }

}


public static class ScoreEvents
{
    public static Action <int> ChangeScore;
  

}