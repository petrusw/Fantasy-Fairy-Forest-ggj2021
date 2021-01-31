using PetrusGames.PGPoolingPro;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace PetrusGames.PGPoolingPro
{
    public class PGPoolingProDemoObjectSpawnerScript : MonoBehaviour
    {

        [SerializeField] private List<GameObject> prefabs;
        [SerializeField] private float timer, trigger;
        [SerializeField] private float maxSpawnPositionX, maxSpawnPosotionY, maxSpawnPositionZ;
        [SerializeField] private float minSpawnPositionX, minSpawnPosotionY, minSpawnPositionZ;

        // Update is called once per frame
        void Update()
        {

            timer += Time.deltaTime;

            if (timer >= trigger)
            {
                timer = 0;
                foreach (var prefab in prefabs)
                {
                    var obj = PoolingManager.PoolingManagerInstance.GetPooledObject(prefab);
                    obj.transform.position = new Vector3(UnityEngine.Random.Range(minSpawnPositionX, maxSpawnPositionX),
                        Random.Range(minSpawnPosotionY, maxSpawnPosotionY),
                        Random.Range(minSpawnPositionZ, maxSpawnPositionZ));
                    obj.transform.rotation = Quaternion.identity;
                    obj.SetActive(true);
                }
            }
        }
    }
}