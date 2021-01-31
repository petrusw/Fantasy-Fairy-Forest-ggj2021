using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletMoveStraight : MonoBehaviour
{
    [SerializeField] private float m_Speed;

    // Start is called before the first frame update
    void Start()
    {
        if (m_Speed == 0.0f)
        {
            m_Speed = 0.1f;
        }
    }

    private void FixedUpdate()
    {
        float _position = -1 * m_Speed;
        transform.position = new Vector3(transform.position.x + _position, transform.position.y, transform.position.z);
    }
}
