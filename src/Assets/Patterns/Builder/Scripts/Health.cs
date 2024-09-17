using System;
using UnityEngine;

namespace Patterns.Builder.Scripts
{
    public class Health : MonoBehaviour
    {
        private int _health;
        
        public void SetHealth(int health)
        {
            if (health < 0)
                throw new ArgumentOutOfRangeException("health");
            
            _health = health;
            Debug.Log($"{gameObject.name} | здоровье = {_health}");
        }
    }
}