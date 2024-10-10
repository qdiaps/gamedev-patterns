using UnityEngine;

namespace Patterns.Command.Scripts
{
    public class Main : MonoBehaviour
    {
        [SerializeField] private Transform _unit;
        [SerializeField] private UIButtonHandler _uiButtonHandler;
        
        private void Start()
        {
            var unitCommandHandler = new UnitCommandHandler();
            _uiButtonHandler.Init(unitCommandHandler, _unit);
        }
    }
}