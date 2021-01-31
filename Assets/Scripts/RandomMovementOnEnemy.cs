using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMovementOnEnemy : MonoBehaviour
{
    [SerializeField] private float m_Speed,m_Timer,m_Trigger;
    private Vector3 pos;
    [SerializeField]private float m_X, m_Y,m_XMax,m_XMin,M_YMax,m_YMIN;
    // Start is called before the first frame update
    void Start()
    {
        Randomise();
    }

    // Update is called once per frame
    void Update()
    {
        m_Timer += Time.deltaTime;

        pos = transform.position;
        if (m_Timer >= m_Trigger)
        {
            Randomise();
            m_X = m_X * m_Speed;
            m_Y = m_Y * m_Speed;

            m_Timer = 0;
        }
        if(pos.y > M_YMax)
        {
            m_Y = -0.1f;
        }
       
        if (pos.y < m_YMIN)
        {
            m_Y = +0.1f;
        }
       
        transform.position = new Vector3(pos.x + m_X, pos.y + m_Y, transform.position.z);
    }

    private void Randomise()
    {
        m_X = Random.Range(-0.5f, 0.5f);
        m_Y = Random.Range(-0.5f, 0.5f);
    }
}
