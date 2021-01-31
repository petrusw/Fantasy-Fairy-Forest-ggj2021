using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace PetrusGames.PGPoolingPro
{
    public class PoolingManager : MonoBehaviour
    {
        public static PoolingManager PoolingManagerInstance;

        private List<GameObject> objectPool;

        private GameObject _returnObject;

        [SerializeField] private int objectsInPool;
        [Space]
        [SerializeField] private List<GameObject> prefabsToPool;
        [Space]
        [SerializeField] private int numberOfInstancesForEachPrefab;
        [Space]
        [SerializeField] private bool activate;
        [Space]
        [SerializeField] private bool dontDestroyOnLoad;
        private void Start()
        {
            if (dontDestroyOnLoad)
            {
                DontDestroyOnLoad(gameObject);
            }
            // instantiate the pooling manager
            if(PoolingManagerInstance != null)
            {
                Destroy(this.gameObject);
            }
            else
            {
                PoolingManagerInstance = this;
            }

            // instantiate the pooling list
            objectPool = new List<GameObject>();

            // instantiate the prelaunched prefab's
            foreach(var prefab in prefabsToPool)
            {
                for(int i = 0; i < numberOfInstancesForEachPrefab; i++)
                {
                    var _objectInstance = Instantiate(prefab,transform);
                    
                    if (activate == false)
                    {
                        _objectInstance.SetActive(false);
                    }

                    objectPool.Add(_objectInstance);
                    objectsInPool++;
                }
            }

        }

        /// <summary>
        /// Get a gameobject from pool that is equal at the name given in the prefabs EazyPoolingProName Script
        /// </summary>
        /// <param name="prefab"></param>
        /// <returns> a gameObject that you can use </returns>
        public GameObject GetPooledObject(GameObject prefab)
        {

            for (int i = 0; i < objectPool.Count; i++)
            {
                 if (objectPool[i].GetComponent<PGPoolingProName>().Name == prefab.GetComponent<PGPoolingProName>().Name)
                    {
                       if (objectPool[i].activeSelf == false)
                       {
                        _returnObject = objectPool[i];
                        return _returnObject;
                       }
                        
                    }
            }
            _returnObject = Instantiate(prefab,transform);
            objectPool.Add(_returnObject);
            objectsInPool++;
            return _returnObject;

        }



    }
}

