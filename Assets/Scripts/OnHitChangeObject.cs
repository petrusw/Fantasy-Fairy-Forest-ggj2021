using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnHitChangeObject : MonoBehaviour
{
    [SerializeField] private GameObject m_Object,m_Explotion,m_explotion2;
    private void Start()
    {
       var obj = Instantiate(m_Object);
        obj.SetActive(false);
        obj.transform.position = transform.position;
        m_Object = obj;

        obj = Instantiate(m_Explotion);
        obj.SetActive(false);
        obj.transform.position = transform.position;
        m_Explotion = obj;

        obj = Instantiate(m_explotion2);
        obj.SetActive(false);
        obj.transform.position = transform.position;
        m_explotion2 = obj;
    }


    private void OnDisable()
    {
        try
        {
            m_Object.transform.position = transform.position;
            m_explotion2.transform.position = transform.position;
            m_Explotion.transform.position = transform.position;
            m_Object.SetActive(true);
            m_Explotion.SetActive(true);
            m_explotion2.SetActive(true);
        }
        catch { }
    }

}
