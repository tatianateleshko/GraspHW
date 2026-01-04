using UnityEngine;

namespace ShootEmUp
{
    public sealed class GameManager : MonoBehaviour
    {
        [SerializeField] private PlayerHealth _playerHealth;
        private void OnEnable()
        {
           _playerHealth.HpEmpty += FinishGame;
        }

        private void OnDisable()
        {
            _playerHealth.HpEmpty += FinishGame;
        }

        private void FinishGame(GameObject _)
        {
            Debug.Log("Game over!");
            Time.timeScale = 0;
        }
    }
}