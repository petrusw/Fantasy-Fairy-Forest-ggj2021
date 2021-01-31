using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float m_Speed;
    [SerializeField] private float m_SpeedMultiplier;
    [SerializeField] private float m_XMin, m_XMax, M_YMin, m_YMax;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (m_SpeedMultiplier < 1)
        {
            m_SpeedMultiplier = 1;
        }
      
    }
    private void FixedUpdate()
    {
        // movement
        Vector2 m_Position = new Vector2(0, 0);
        // go left
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (transform.position.x > m_XMin)
            {
                m_Position.x = -1 * m_Speed * m_SpeedMultiplier;
            }
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (transform.position.x < m_XMax)
            {
                m_Position.x = 1 * m_Speed * m_SpeedMultiplier;
            }
            if(transform.position.x >= 0)
            {
                //Camera.main.transform.position = new Vector3(Camera.main.transform.position.x + m_Speed * m_SpeedMultiplier, 0, 0);
            }
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            if (transform.position.y > M_YMin)
            {
                m_Position.y = -1 * m_Speed * m_SpeedMultiplier;
            }
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (transform.position.y < m_YMax)
            {
                m_Position.y = 1 * m_Speed * m_SpeedMultiplier;
            }
        }

        transform.position = new Vector3(transform.position.x + m_Position.x, transform.position.y + m_Position.y, transform.position.z);
        m_Position = new Vector2(0, 0);
    }
    public void SetSpeedMultiplier(float multiplier)
    {
        m_SpeedMultiplier = multiplier;
    }
    public void ResetSpeedMultiplier()
    {
        m_SpeedMultiplier = 1;
    }
}
