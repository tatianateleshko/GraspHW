using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace ShootEmUp
{
    public class PlayerHealth : MonoBehaviour , IHealth
    {
        public event Action<GameObject> HpEmpty;

        [SerializeField] private int _hitPoints;

        public bool IsHitPointsExists()
        {
            return this._hitPoints > 0;
        }

        public void TakeDamage(int damage)
        {
            this._hitPoints -= damage;
            if (this._hitPoints <= 0)
            {
                this.HpEmpty?.Invoke(this.gameObject);
            }
        }
    }

}
