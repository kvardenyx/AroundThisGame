using UnityEngine;

namespace _Project.Scripts
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private ScoreController scoreController;
        
        [SerializeField] private ScenesManager scenesManager;
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("Enemy"))
            {
                scenesManager.LoadScene("LoseScene");
            }
            else
            {
                Destroy(other.gameObject);

                scoreController.AddScore();
            }
        }
    }
}