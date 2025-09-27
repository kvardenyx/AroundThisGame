using System;
using Unity.VisualScripting;
using UnityEngine;

namespace _Project.Scripts
{
    public class ObjectMovment : MonoBehaviour
    {
        private Rigidbody2D _rb;
        
        public float speed;

        private void Start()
        {
            _rb = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            _rb.linearVelocity = (Vector2.right * (speed * Time.deltaTime));
        }
    }
}