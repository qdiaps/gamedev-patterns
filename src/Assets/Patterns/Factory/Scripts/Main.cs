using UnityEngine;

namespace Patterns.Factory.Scripts
{
    public class Main : MonoBehaviour
    {
        private void Start()
        {
            var factory = new PlayerFactory();
            var player = factory.Create("Player", new Vector3(10, 5, 30), Quaternion.identity);
            Debug.Log($"Игрок {player.name} создан");
        }
    }
}