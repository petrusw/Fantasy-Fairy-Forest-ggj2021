using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OncollisionActivate : MonoBehaviour
{
    [SerializeField] private GameObject m_Target;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag== "Player")
        {
            m_Target.SetActive(true);
        }
        
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    m_Target.SetActive(true);
    //}
}
