using DefaultNamespace.Rival_StandardCharacters.FirstPerson.Scripts.input;
using Unity.Entities;
using UnityEditor.Rendering;
using UnityEngine;

namespace DefaultNamespace
{
    public partial class CharacterInventorySystem : SystemBase
    {
        protected override void OnUpdate()
        {
            Entities.ForEach((Entity e, CharacterInput input, CharacterInventory inventory) =>
            {
               
            }).ScheduleParallel();
        }
    }
}