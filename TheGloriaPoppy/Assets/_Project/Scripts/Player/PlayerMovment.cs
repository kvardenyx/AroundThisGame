using System;
using UnityEngine;

namespace _Project.Scripts
{
    public class PlayerMovment : MonoBehaviour
    {
        [SerializeField] private GameObject playerCenter;
        [SerializeField] private SpriteRenderer playerSprite;

        [SerializeField] private Rigidbody2D _rb;
        
        [SerializeField, Range(100f, 250f)] 
        private float playerSpeed = 150f;
        
        [SerializeField] private ScoreController scoreController;

        private void Start()
        {
            scoreController.PowerUp += AddPlayerSpeed;
        }

        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                playerSprite.flipY = !playerSprite.flipY;
                
                playerSpeed = -playerSpeed;
            }
        }

        private void FixedUpdate()
        {
            Movment();
        }

        void AddPlayerSpeed()
        {
            if (playerSpeed < 0)
            {
                playerSpeed -= 5f;
            } 
            else if (playerSpeed > 0 && playerSpeed < 200)
            {
                playerSpeed += 5f;
            }
        }

        void Movment()
        {
            _rb.angularVelocity = playerSpeed;
        }
    }
}
