using System.Collections;
using UnityEngine;
namespace _Project.Scripts
{
    public class Spawner : MonoBehaviour
    {
        public SpriteRenderer spawnerSpriteRenderer;

        private float _topDot;
        private float _bottomDot;
        private float _randomDot;

        [SerializeField] private float minTime = 1f;
        [SerializeField] private float maxTime = 2f;

        public GameObject enemyPrefab;
        public GameObject bonusPrefab;

        private void Start()
        {
            GetDotSpawner();
            
            StartCoroutine(SpawnEnemyLoop());
            StartCoroutine(SpawnBonusLoop());
        }
        
        private void GetDotSpawner()
        {
            _topDot = spawnerSpriteRenderer.bounds.max.y;
            _bottomDot = spawnerSpriteRenderer.bounds.min.y;
        }

        private void SpawnEnemy()
        {
            _randomDot = Random.Range(_topDot, _bottomDot);
            Vector2 spawnPos = new Vector2(spawnerSpriteRenderer.transform.position.x, _randomDot);
            
            Instantiate(enemyPrefab, spawnPos, Quaternion.identity);

        }
        
        private void SpawnBonus()
        {
            _randomDot = Random.Range(_topDot, _bottomDot);
            Vector2 spawnPos = new Vector2(spawnerSpriteRenderer.transform.position.x, _randomDot);
            
            Instantiate(bonusPrefab, spawnPos, Quaternion.identity);

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
                yield return new WaitForSeconds(Random.Range(minTime, (maxTime * 3)));
                SpawnBonus();
            }
        }
    }
}
