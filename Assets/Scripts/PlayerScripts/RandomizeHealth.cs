using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomizeHealth : MonoBehaviour
{
    [SerializeField] private float m_HealthMin, m_HealtMax;



    public float RandomizeHealthFloat()
    {
        float normalized = Random.Range(m_HealthMin, m_HealtMax);
        normalized = Mathf.Floor(normalized);
        return normalized;
    }

   
}
