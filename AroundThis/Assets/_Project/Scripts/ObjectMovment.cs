using UnityEngine;

namespace _Project.Scripts
{
    public class ObjectMovment : MonoBehaviour
    {
        private Rigidbody2D _rb;
        
        [SerializeField, Range(2f, 5f)] 
        private float speed = 3f;

        private void Start()
        {
            _rb = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            _rb.linearVelocity = (Vector2.right * speed);
        }
    }
}