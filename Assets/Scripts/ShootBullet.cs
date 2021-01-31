using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBullet : MonoBehaviour
{

    [SerializeField] private GameObject m_Bullet;
    [SerializeField] private float m_Timer,m_Trigger;
    [SerializeField] private Animator m_Animator;
    [SerializeField] private GameObject m_TriggerObject;
    private bool m_IsSchooting;
    private GameObject m_BulletNew;
    // Update is called once per frame

    private void Start()
    {
        m_IsSchooting = true;
    }
    void Update()
    {
        m_Timer += Time.deltaTime;

        if (m_Timer >= m_Trigger && m_IsSchooting)
        {
            GetBullet(m_Bullet);
            m_Timer = 0;
        }
    }

    private void OnEnable()
    {
        m_IsSchooting = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Trigger")
        {
            m_IsSchooting = true;
        }
    }
    public void GetBullet(GameObject bullet)
    {
        m_Animator.SetTrigger("Attack");
        m_BulletNew = bullet;
        m_Timer = 0;
    }
    public void ShootBulletNow()
    {
        GameObject _bullet = PetrusGames.PGPoolingPro.PoolingManager.PoolingManagerInstance.GetPooledObject(m_BulletNew);
        _bullet.transform.position = transform.position;
        _bullet.gameObject.SetActive(true);
    }
}
