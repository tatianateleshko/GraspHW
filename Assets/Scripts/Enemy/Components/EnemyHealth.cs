using System;
using UnityEngine;

namespace ShootEmUp
{
    public sealed class EnemyHealth : MonoBehaviour , IHealth
    {
        public event Action<GameObject> HpEmpty;
        
        [SerializeField] private int _hitPoints;
        
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