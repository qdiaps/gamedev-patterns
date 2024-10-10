using UnityEngine;

namespace Patterns.Command.Scripts.Command
{
    public class UnitAttack : ICommand
    {
        public void Execute() => 
            Debug.Log("Unit: Attack!");
    }
}