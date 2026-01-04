using UnityEngine;

namespace ShootEmUp
{
    public sealed class PlayerInputController : MonoBehaviour
    {
        [SerializeField]
        private PlayerAttack _playerAttack;
        public float HorizontalDirection { get; private set; }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _playerAttack.FireRequared = true;
            }

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                this.HorizontalDirection = -1;
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                this.HorizontalDirection = 1;
            }
            else
            {
                this.HorizontalDirection = 0;
            }
        }
        
    }
}