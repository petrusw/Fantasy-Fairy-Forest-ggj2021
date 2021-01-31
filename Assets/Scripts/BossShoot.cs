using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossShoot : MonoBehaviour
{

    [SerializeField] private float m_Health,m_HitPoints,m_Trigger,m_Timer;
    [SerializeField] private Color[] m_Color;
    [SerializeField] private GameObject m_SoundShoot,m_SoundHit;
    [SerializeField] private GameObject m_Bullet,m_MiniBoss,m_HitEffect,m_shootTransform;
 

    // Update is called once per frame
    void Update()
    {
        if (m_Health < 0)
        {
            ActivateLittleBoss();
            try
            {
                m_HitEffect.SetActive(true);
            }
            catch { }
            gameObject.SetActive(false);
        }

        m_Timer += Time.deltaTime;
        if (m_Timer > m_Trigger)
        {
            Shoot();
            m_Timer = 0;
        }
    }
    private void ActivateLittleBoss()
    {
        m_MiniBoss.SetActive(true);
    }
    private void Shoot()
    {
        m_SoundShoot.GetComponent<AudioSource>().Play();
        Instantiate(m_Bullet, m_shootTransform.transform);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "PlayerBullet")
        {
            m_Health -= m_HitPoints;
            m_SoundHit.GetComponent<AudioSource>().Play();
            Instantiate(m_HitEffect, transform);
            collision.gameObject.SetActive(false);
        }
    }
}
