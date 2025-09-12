using System.Collections;
using UnityEngine;

namespace _Project.Scripts
{
    public class Spawner : MonoBehaviour
    {
        [SerializeField] private Transform spawnerPositon;
        [SerializeField] private Vector2 spawnerRange;

        [SerializeField, Range(0.5f, 2f)] 
        private float minTime = 1f;
        [SerializeField, Range(2f, 4f)] 
        private float maxTime = 2f;

        [SerializeField] private GameObject enemyPrefab;
        [SerializeField] private GameObject bonusPrefab;
        
        private Vector2 _randomPosition;

        private void Start()
        {
            StartCoroutine(SpawnEnemyLoop());
            StartCoroutine(SpawnBonusLoop());
        }

        private void SpawnEnemy()
        {
            GenerateRandomDot();
            
            Instantiate(enemyPrefab, _randomPosition, Quaternion.identity);

        }
        
        private void SpawnBonus()
        {
            GenerateRandomDot();
            
            Instantiate(bonusPrefab, _randomPosition, Quaternion.identity);

        }

        private void GenerateRandomDot()
        {
            _randomPosition = spawnerPositon.position + new Vector3(0, Random.Range(-spawnerRange.y, spawnerRange.y));
        }
        
        private IEnumerator SpawnEnemyLoop()
        {
            while (true)
            {
                yield return new WaitForSeconds(Random.Range(minTime, maxTime));
                SpawnEnemy();
            }
        }
        
        private IEnumerator SpawnBonusLoop()
        {
            while (true)
            {
                yield return new WaitForSeconds(Random.Range(minTime, (maxTime * 2)));
                SpawnBonus();
            }
        }
    }
}
