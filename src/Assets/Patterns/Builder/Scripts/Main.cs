using Patterns.Builder.Scripts.Weapon;
using UnityEngine;

namespace Patterns.Builder.Scripts
{
    public class Main : MonoBehaviour
    {
        private void Start()
        {
            var builder = new EnemyBuilder();
            
            builder.CreateNewEnemy("Enemy 1");
            builder.SetPosition(new Vector3(10, 10, 10));
            builder.SetHealth(50);
            builder.SetWeapon(WeaponType.Gun);
            Debug.Log("Создан первый враг");
            
            builder.CreateNewEnemy("Enemy 2");
            builder.SetScale(new Vector3(5, 2, 1));
            builder.SetRotation(new Quaternion(10, 10, 10, 0));
            builder.SetWeapon(WeaponType.Sword);
            var enemy = builder.GetResult();
            enemy
                .GetComponent<IWeapon>()
                .Attack();
            Debug.Log("Создан второй враг");
            
            builder.CreateNewEnemy("Enemy 3");
            Debug.Log("Создан последний враг");
        }
    }
}