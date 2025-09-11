using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace _Project.Scripts
{
    public class ObjectMovment : MonoBehaviour
    {
        [SerializeField] private float _speed = 3f;

        private void Update()
        {
            transform.Translate(Vector2.right * (_speed * Time.deltaTime));
        }
    }
}