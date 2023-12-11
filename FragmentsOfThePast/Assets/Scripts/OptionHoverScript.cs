using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionHoverScript : MonoBehaviour
{
    //Animator
    [SerializeField] Animator animator;

    //Al hacer Hover en el texto que haga animacion de scale
    public void OptionHoverFunction()
    {
        animator.SetBool("canPlayOptionHoverAnim", true);
    }

    public void OptionNoHoverFunction()
    {
        animator.SetBool("canPlayOptionHoverAnim", false);
    }

}
