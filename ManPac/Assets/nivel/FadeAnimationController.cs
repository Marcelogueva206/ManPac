using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeAnimationController : MonoBehaviour
{
    public Animator anim;
    public bool starAnimation;
    public Movemeny movement;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        starAnimation = movement.textAnimation;
        anim.SetBool("Start", starAnimation);
    }
}
