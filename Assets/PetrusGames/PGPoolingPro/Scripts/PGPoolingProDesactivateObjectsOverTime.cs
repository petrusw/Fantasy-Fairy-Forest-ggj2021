using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PetrusGames.PGPoolingPro
{
    public class PGPoolingProDesactivateObjectsOverTime : MonoBehaviour
    {

        [SerializeField] private float timer, trigger;

        // Update is called once per frame
        void Update()
        {

            timer += Time.deltaTime;

            if (timer >= trigger)
            {
                timer = 0;
                gameObject.SetActive(false);
            }
        }
    }
}
