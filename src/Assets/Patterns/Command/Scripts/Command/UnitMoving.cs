using UnityEngine;

namespace Patterns.Command.Scripts.Command
{
    public class UnitMoving : ICommand
    {
        private readonly Transform _unit;
        private readonly Vector3 _target;
        
        public UnitMoving(Transform unit, Vector3 target)
        {
            _unit = unit;
            _target = target;
        }
        
        public void Execute()
        {
            Debug.Log("Unit: Moving");
            _unit.position = _target;
        }
    }
}