using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableAfterTime : MonoBehaviour
{
    [SerializeField] private float m_Timer, m_Trigger;
    private void OnEnable()
    {
        m_Timer = 0;
    }
    // Update is called once per frame
    void Update()
    {
        m_Timer += Time.deltaTime;
        if (m_Timer > m_Trigger)
        {
            gameObject.SetActive(false);
        }
    }
}
