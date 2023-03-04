using Unity.Collections;
using Unity.Entities;
using Unity.Transforms;
using UnityEngine;

namespace DefaultNamespace.Rival_StandardCharacters.FirstPerson.Scripts.input
{
    public partial class GunInputSystem : SystemBase
    {
        protected override void OnUpdate()
        {
            Entities.ForEach((Entity e, ref GunInput characterInput) =>
            {
                characterInput.shoot = Input.GetKey(KeyCode.Mouse0);
            }).Run();
        }
    }
}