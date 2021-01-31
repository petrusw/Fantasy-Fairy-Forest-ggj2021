using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetAnimationOnPlayer : MonoBehaviour
{
    [SerializeField] private Animator m_Animator;

    private void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            m_Animator.SetBool("idle",false);
            m_Animator.SetBool("fly", true);
        }
        if (Input.GetKeyUp(KeyCode.RightArrow)|| Input.GetKeyUp(KeyCode.LeftArrow)|| Input.GetKeyUp(KeyCode.UpArrow)|| Input.GetKeyUp(KeyCode.DownArrow))
        {
            m_Animator.SetBool("fly",false);
            m_Animator.SetBool("idle",true);
        }
    }


}
