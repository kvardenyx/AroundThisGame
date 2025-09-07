using UnityEngine;

namespace _Project.Scripts
{
    public class Destroyer : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D other)
        {
            Destroy(other.gameObject);
        }
    }
}