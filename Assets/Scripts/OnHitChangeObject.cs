using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnHitChangeObject : MonoBehaviour
{
    [SerializeField] private GameObject m_Object;
    private void Start()
    {
       var obj = Instantiate(m_Object);
        obj.SetActive(false);
        obj.transform.position = transform.position;
        m_Object = obj;
    }


    private void OnDisable()
    {
        try
        {
            m_Object.transform.position = transform.position;
            m_Object.SetActive(true);
        }
        catch { }
    }

}
