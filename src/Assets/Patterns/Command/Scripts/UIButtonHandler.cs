using Patterns.Command.Scripts.Command;
using UnityEngine;

namespace Patterns.Command.Scripts
{
    public class UIButtonHandler : MonoBehaviour
    {
        private UnitCommandHandler _unitCommandHandler;
        private Transform _unit;

        public void Init(UnitCommandHandler unitCommandHandler, Transform unit)
        {
            _unitCommandHandler = unitCommandHandler;
            _unit = unit;
        }
        
        public void AddAttack() => 
            _unitCommandHandler.AddCommand(new UnitAttack());

        public void AddMoving()
        {
            var newPosition = new Vector3(Random.Range(0, 10), Random.Range(0, 10));
            var command = new UnitMoving(_unit, newPosition);
            _unitCommandHandler.AddCommand(command);
        }

        public void ExecuteUnitCommands() =>
            _unitCommandHandler.ExecuteAllCommands();
    }
}