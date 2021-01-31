using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunAway : MonoBehaviour
{

    [SerializeField] private bool m_RandomizeDirection;
    [SerializeField] private float m_Speed;
    [SerializeField]private float m_X , m_Y , m_Z;
    private bool m_StartMoving;
    // Start is called before the first frame update
    void Start()
    {
        m_X = Random.Range(-2, 2) * m_Speed;
        m_Y= Random.Range(-2, 2) * m_Speed;
        m_Z= Random.Range(-2, 2) * m_Speed;

        if(m_X == 0) { m_X = -0.05f; }
        if (m_Y == 0) { m_X = -0.05f; }
        if (m_Z == 0) { m_X = -0.05f; }
        if (m_X > 0)
        {
            var _lx = -transform.localScale.x;
            transform.localScale = new Vector3(_lx, transform.localScale.y, transform.localScale.z);
        }
    }
    private void OnEnable()
    {
        m_StartMoving = true;
    }
    // Update is called once per frame
    void Update()
    {
        if (m_StartMoving)
        {
            transform.position = new Vector3(transform.position.x + m_X , transform.position.y + m_Y , transform.position.z + m_Z);
        }
    }
}
