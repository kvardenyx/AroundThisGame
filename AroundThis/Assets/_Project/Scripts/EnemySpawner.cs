using System.Collections;
using UnityEngine;
namespace _Project.Scripts
{
    public class EnemySpawner : MonoBehaviour
    {
        public SpriteRenderer enemySpawnerSpriteRenderer;

        private float _topDot;
        private float _bottomDot;
        private float _randomDot;

        [SerializeField] private float minTime = 1f;
        [SerializeField] private float maxTime = 2f;

        public GameObject enemyPrefab;

        private void Start()
        {
            GetDotEnemySpawner();
            
            StartCoroutine(SpawnEnemyLoop());
        }

        private void SpawnEnemy()
        {
            _randomDot = Random.Range(_topDot, _bottomDot);
            Vector2 spawnPos = new Vector2(enemySpawnerSpriteRenderer.transform.position.x, _randomDot);
            
            Instantiate(enemyPrefab, spawnPos, Quaternion.identity);

        }

        private void GetDotEnemySpawner()
        {
            _topDot = enemySpawnerSpriteRenderer.bounds.max.y;
            _bottomDot = enemySpawnerSpriteRenderer.bounds.min.y;
            
            Debug.Log("top: " + _topDot + "   " + "bottom: " + _bottomDot);
        }
        
        private IEnumerator SpawnEnemyLoop()
        {
            while (true)
            {
                yield return new WaitForSeconds(Random.Range(minTime, maxTime));
                SpawnEnemy();
            }
        }
    }
}
