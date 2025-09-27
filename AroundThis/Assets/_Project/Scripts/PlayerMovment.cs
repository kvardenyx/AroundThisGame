using System;
using UnityEngine;

namespace _Project.Scripts
{
    public class PlayerMovment : MonoBehaviour
    {
        [SerializeField] private GameObject playerCenter;
        
        [SerializeField, Range(100f, 200f)] 
        private float playerSpeed = 100f;
        
        [SerializeField] private ScoreController scoreController;

        private void Start()
        {
            scoreController.PowerUp += AddPlayerSpeed;
        }

        void Update()
        {
            Movment();

            if (Input.GetMouseButtonDown(0))
            {
                playerSpeed = -playerSpeed;
            }
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
            playerCenter.transform.Rotate(0f, 0f, playerSpeed * Time.deltaTime);
        }
    }
}
