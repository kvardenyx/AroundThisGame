using UnityEngine;
using UnityEngine.SceneManagement;

namespace _Project.Scripts
{
    public class PlayerHealth : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D other)
        {
            SceneManager.LoadScene(1);
        }
    }
}