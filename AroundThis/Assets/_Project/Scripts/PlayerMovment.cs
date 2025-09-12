using UnityEngine;

namespace _Project.Scripts
{
    public class PlayerMovment : MonoBehaviour
    {
        [SerializeField] private GameObject playerCenter;
        
        [SerializeField, Range(100f, 300f)] 
        private float playerSpeed = 150f;

        void Update()
        {
            Movment();

            if (Input.GetMouseButtonDown(0))
            {
                playerSpeed = -playerSpeed;
            }
        }

        void Movment()
        {
            playerCenter.transform.Rotate(0f, 0f, playerSpeed * Time.deltaTime);
        }
    }
}
