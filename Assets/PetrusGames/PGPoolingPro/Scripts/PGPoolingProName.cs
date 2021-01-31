using UnityEditor;
using UnityEngine;
using System;

namespace PetrusGames.PGPoolingPro
{
    
    internal class PGPoolingProName : MonoBehaviour
    {
        [SerializeField]
        private string _name;

        public string Name
        {
            get
            {
                return _name;
            }
        }

    }
}