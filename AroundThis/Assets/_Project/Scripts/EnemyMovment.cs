using System;
using UnityEngine;

namespace _Project.Scripts
{
    public class EnemyMovment : MonoBehaviour
    {
        [SerializeField] private float enemySpeed = 3f;
        private void Update()
        {
            transform.Translate(Vector2.right * (enemySpeed * Time.deltaTime));
        }
    }
}