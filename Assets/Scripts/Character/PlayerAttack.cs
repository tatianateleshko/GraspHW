using ShootEmUp;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;


namespace ShootEmUp
{
    public class PlayerAttack : MonoBehaviour
    {
        [SerializeField] private Transform _bulletSpawnPosition;
        [SerializeField] private BulletSystem _bulletSystem;
        [SerializeField] private BulletConfig _bulletConfig;
        public bool FireRequared;

        private void FixedUpdate() 
        {
            if (this.FireRequared)
            {
                this.OnFlyBullet();
                this.FireRequared = false;
            }
        }

        private void OnFlyBullet()
        {
            _bulletSystem.FlyBulletByArgs(new BulletSystem.Args
            {
                isPlayer = true,
                physicsLayer = (int)this._bulletConfig.physicsLayer,
                color = this._bulletConfig.color,
                damage = this._bulletConfig.damage,
                position = _bulletSpawnPosition.position,
                velocity = _bulletSpawnPosition.rotation * Vector3.up * this._bulletConfig.speed
            });
        }
    }

}
