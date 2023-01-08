using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextAnimationController : MonoBehaviour
{
    public Animator anim;
    public bool starAnimation;
    public EventsManager eventsManager;

    void Update()
    {
        starAnimation = eventsManager.textAnimation;
        anim.SetBool("Start", starAnimation);
    }
}
