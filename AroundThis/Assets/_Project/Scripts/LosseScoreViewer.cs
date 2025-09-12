using UnityEngine;
using UnityEngine.UI;

namespace _Project.Scripts
{
    public class LoseScoreViewer : MonoBehaviour
    {
        private int _score;

        private Text _currentScoreText;

        private void Start()
        {
            _currentScoreText = gameObject.GetComponent<Text>();
            
            _score = PlayerPrefs.GetInt("Score");

            _currentScoreText.text = "Scored: " + _score.ToString();
        }
    }
}