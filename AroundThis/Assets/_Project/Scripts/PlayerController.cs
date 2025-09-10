using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace _Project.Scripts
{
    public class PlayerController : MonoBehaviour
    {
        public ScoreController ScoreController;
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("Enemy"))
            {
                SceneManager.LoadScene(1);
            }
            else
            {
                Destroy(other.gameObject);

                ScoreController.AddScore();
            }
        }
    }
}