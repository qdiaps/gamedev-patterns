using UnityEngine;

namespace Patterns.Builder.Scripts.Weapon
{
    public class Gun : MonoBehaviour, IWeapon
    {
        public void Attack() => 
            Debug.Log($"{gameObject.name} | атака gun");
    }
}