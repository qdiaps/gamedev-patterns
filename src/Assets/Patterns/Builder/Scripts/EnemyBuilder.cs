using Patterns.Builder.Scripts.Weapon;
using UnityEngine;

namespace Patterns.Builder.Scripts
{
    public class EnemyBuilder
    {
        private GameObject _enemy;

        public void CreateNewEnemy(string name) => 
            _enemy = new GameObject(name);

        public GameObject GetResult() =>
            _enemy;
        
        public void SetPosition(Vector3 position) =>
            _enemy.transform.position = position;
        
        public void SetRotation(Quaternion rotation) =>
            _enemy.transform.rotation = rotation;
        
        public void SetScale(Vector3 scale) =>
            _enemy.transform.localScale = scale;

        public void SetHealth(int health)
        {
            _enemy
                .AddComponent<Health>()
                .SetHealth(health);
        }

        public void SetWeapon(WeaponType type)
        {
            switch (type)
            {
                case WeaponType.Sword:
                    _enemy.AddComponent<Sword>();
                    break;
                case WeaponType.Gun:
                    _enemy.AddComponent<Gun>();
                    break;
                default:
                    _enemy.AddComponent<Sword>();
                    break;
            }
        }
    }
}