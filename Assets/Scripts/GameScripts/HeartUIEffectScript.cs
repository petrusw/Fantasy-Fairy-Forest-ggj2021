using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartUIEffectScript : MonoBehaviour
{
    [SerializeField] private float m_Scale,m_MaxScale,m_Percentage;
    private float m_NewScale;
    private bool m_IsGrowing;

    // Update is called once per frame
    void Update()
    {
        if (m_IsGrowing && transform.localScale.x < m_MaxScale)
        {
            transform.localScale = new Vector3(transform.localScale.x + m_Percentage, transform.localScale.y + m_Percentage, transform.localScale.z + m_Percentage);
        }
        else
        {
            m_IsGrowing = false;
        }

        if(m_IsGrowing == false && transform.localScale.x > m_Scale)
        {
            transform.localScale = new Vector3(transform.localScale.x - m_Percentage, transform.localScale.y - m_Percentage, transform.localScale.z - m_Percentage);
        }
        else
        {
            m_IsGrowing = true;
        }
    }
}
