using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIEvents : MonoBehaviour
{
    public Button buttonPause;
    public Button buttonReady;
    public Button buttonStopMute;
    public Button buttonReadyMute;
    public Image backGroundDark;
  

    SpriteState StatesButtonPause; 

    private void Start()
    {

    }


    public void PauseGame()
    {
        buttonPause.gameObject.SetActive(false);
        buttonReady.gameObject.SetActive(true);
        backGroundDark.gameObject.SetActive(true);
  
        Time.timeScale = 0;
             
    }

    public void ReadyGame()
    {
        buttonPause.gameObject.SetActive(true);
        buttonReady.gameObject.SetActive(false);
        Time.timeScale = 1;
        backGroundDark.gameObject.SetActive(false);
    }

    public void StopMute()
    {
        buttonReadyMute.gameObject.SetActive(true);
        buttonStopMute.gameObject.SetActive(false);
   
    }

    public void ReadyMute()
    {
        buttonReadyMute.gameObject.SetActive(false);
        buttonStopMute.gameObject.SetActive(true);
    }

}
