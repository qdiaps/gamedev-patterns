using UnityEngine;

namespace Patterns.Builder.Scripts.Weapon
{
    public class Sword : MonoBehaviour, IWeapon
    {
        public void Attack() => 
            Debug.Log($"{gameObject.name} | атака sword");
    }
}