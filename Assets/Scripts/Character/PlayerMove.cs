using ShootEmUp;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ShootEmUp
{
    public class PlayerMove : MonoBehaviour
    {
        [SerializeField] 
        private PlayerInputController _inputController;
        [SerializeField]
        private Rigidbody2D _rigidbody2D;

        [SerializeField]
        private float _speed = 5.0f;

        public void MoveByRigidbodyVelocity(Vector2 vector)
        {
            var nextPosition = this._rigidbody2D.position + vector * this._speed;
            this._rigidbody2D.MovePosition(nextPosition);
        }

        private void FixedUpdate()
        {
           MoveByRigidbodyVelocity(new Vector2(_inputController.HorizontalDirection, 0) * Time.fixedDeltaTime);
        }
    }
}
