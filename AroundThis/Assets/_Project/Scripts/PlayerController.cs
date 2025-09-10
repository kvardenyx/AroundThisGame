using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace _Project.Scripts
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private ScoreController ScoreController;
        
        [SerializeField] private ScenesManager ScenesManager;
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("Enemy"))
            {
                ScenesManager.OnLosseScene();
            }
            else
            {
                Destroy(other.gameObject);

                ScoreController.AddScore();
            }
        }
    }
}