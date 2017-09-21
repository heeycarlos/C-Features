using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Loops
{
    public class Spawner : MonoBehaviour
    {
        public GameObject spawnPrefab;
        public int spawnAmount = 10;
        public float spawnRadius = 5f;

        // Run by Unity to draw Gizmos in the scene view
        void OnDrawGizmos()
        {
            Gizmos.DrawWireSphere(transform.position, spawnRadius);
        }

        void Generate()
        {
            // Loop up to spawnAmount
            for (int i = 0; i < spawnAmount; i++)
            {
                //Spawn a new GameObject from prefab
                GameObject clone = Instantiate(spawnPrefab);
                //Generate a random position
                Vector3 randomPos = Random.insideUnitSphere * spawnRadius;
                //Cancel z axis
                randomPos.z = 0;
                //Set the object's position to RandomPos
                clone.transform.position = transform.position + randomPos;
            }

        }

        void Start()
        {

            //Within function 
            Generate();
            OnDrawGizmos();
        }
        //Under function 
    }
}
