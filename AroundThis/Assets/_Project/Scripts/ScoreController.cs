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
        }

        public void AddScore()
        {
            _scoreValue++;

            _scoreText.text = _scoreValue.ToString();
        }
    }
}