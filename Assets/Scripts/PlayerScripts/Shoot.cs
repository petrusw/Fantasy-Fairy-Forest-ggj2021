using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] private GameObject m_Bullet;
    [SerializeField] private Transform m_StartPosition;
    [SerializeField] private GameObject m_Sound;
    // Start is called before the first frame update
    void Start()
    {
        m_StartPosition = GameObject.Find("bulletStartPosition").transform;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            ShootBullet(m_Bullet);
        }
    }

    private void ShootBullet(GameObject bullet)
    {
        GetBulletFromPool(bullet);
    }

    private void GetBulletFromPool(GameObject bullet)
    {
        var _bullet = PetrusGames.PGPoolingPro.PoolingManager.PoolingManagerInstance.GetPooledObject(bullet);
        _bullet.transform.position = m_StartPosition.position;
        _bullet.SetActive(true);
        m_Sound.GetComponent<AudioSource>().Play();
    }
}
