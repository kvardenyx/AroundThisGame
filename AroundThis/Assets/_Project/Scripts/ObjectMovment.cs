using System;
using UnityEngine;

namespace _Project.Scripts
{
    public class ObjectMovment : MonoBehaviour
    {
        [SerializeField] private float speed = 3f;
        private void Update()
        {
            transform.Translate(Vector2.right * (speed * Time.deltaTime));
        }
    }
}