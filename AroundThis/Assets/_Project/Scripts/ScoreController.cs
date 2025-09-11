using System;
using UnityEngine;
using UnityEngine.UI;

namespace _Project.Scripts
{
    public class ScoreController : MonoBehaviour
    {
        private int _scoreValue = 0;
        private Text _scoreText;

        private void Start()
        {
            _scoreText = gameObject.GetComponent<Text>();
            
            _scoreText.text = _scoreValue.ToString();
            
            PlayerPrefs.SetInt("Score", _scoreValue);
        }

        public void AddScore()
        {
            _scoreValue++;
            
            PlayerPrefs.SetInt("Score", _scoreValue);

            _scoreText.text = _scoreValue.ToString();
        }
    }
}