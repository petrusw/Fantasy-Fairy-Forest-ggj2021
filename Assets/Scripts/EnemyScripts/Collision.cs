using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    [SerializeField] private float m_PlayerDamage;
    [SerializeField] private float m_Score;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            DisableObject();
            DamageToPlayer(m_PlayerDamage);
        }
        else if (collision.gameObject.tag == "PlayerBullet")
        {
            HitBullet(collision.gameObject.transform);
            AddScore(m_Score);
        }
    }
    private void AddScore(float score)
    {
        GameVariablesScript.GameVariablesScriptInstance.AddScore = score;
    }
   private void HitBullet(Transform bullet)
    {
        DisableObject();
        bullet.gameObject.SetActive(false);
    }

    private void DisableObject()
    {
        gameObject.SetActive(false);
    }
    private void DamageToPlayer(float damage)
    {
        GameVariablesScript.GameVariablesScriptInstance.RemoveHealth = damage;
    }
    private void PlayExplotion()
    {
        // get explotion from pool!!!
    }
}
