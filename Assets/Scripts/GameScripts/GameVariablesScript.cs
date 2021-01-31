using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameVariablesScript : MonoBehaviour
{
    // static
    public static GameVariablesScript GameVariablesScriptInstance = new GameVariablesScript();


    // public
    public float m_Health;

    // private
    [SerializeField] private GameObject m_Player;
    [SerializeField] private bool m_IsHealthRandom;
    [SerializeField] private float m_Score;
    [SerializeField] private GameObject[] m_Hearts;
    [SerializeField] private TMPro.TextMeshProUGUI m_ScoreText;
    // accesors
    public float RemoveHealth
    {
        set {
            m_Health -= value;
            for (var i = 3; i >= m_Health; i--)
            {
                try { 
                m_Hearts[i].SetActive(false);
            }
                catch { }
            }
        }
    }
    public float AddScore
    {
        set {
            m_Score += value;
            m_ScoreText.text = m_Score.ToString();
        }
    }
    // functions

    // Start is called before the first frame update
    void Start()
    {
        if(GameVariablesScriptInstance == null)
        {
            GameVariablesScriptInstance = this;
        }




        if (m_IsHealthRandom)
        {
            m_Health = m_Player.GetComponent<RandomizeHealth>().RandomizeHealthFloat();
            for (var i = 3; i >= m_Health; i--)
            {
                m_Hearts[i].SetActive(false);
            }
        }


    }
    private void Update()
    {
        if (m_Health <= 0)
        {
            m_Player.SetActive(false);
            // set all variables back to start point or go to loading screen
            SceneManager.LoadScene("EndScene");

        }
    }

}
