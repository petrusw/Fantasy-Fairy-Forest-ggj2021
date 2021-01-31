using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFolow : MonoBehaviour
{
    [SerializeField] private Transform m_Player;
    [SerializeField] private float m_SmootSpeed;
    [SerializeField] private Vector3 m_Offset;
    private void FixedUpdate()
    {
        Vector3 _desiredPosition = m_Player.position + m_Offset;
        Vector3 _smoothedPosition = Vector3.Lerp(transform.position, _desiredPosition, m_SmootSpeed);
        transform.position = _smoothedPosition;
    }
}
