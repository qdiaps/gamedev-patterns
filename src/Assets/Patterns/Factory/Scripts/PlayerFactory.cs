using UnityEngine;

namespace Patterns.Factory.Scripts
{
    public class PlayerFactory
    {
        public GameObject Create(string name, Vector3 position, Quaternion rotation)
        {
            var player = new GameObject(name);
            player.transform.position = position;
            player.transform.rotation = rotation;
            return player;
        }
    }
}