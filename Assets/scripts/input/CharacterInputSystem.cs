using Unity.Collections;
using Unity.Entities;
using Unity.Transforms;
using UnityEngine;

namespace DefaultNamespace.Rival_StandardCharacters.FirstPerson.Scripts.input
{
    public partial class CharacterInputSystem : SystemBase
    {
        protected override void OnUpdate()
        {
            Entities.ForEach((Entity e, ref CharacterInput characterInput) =>
            {
                characterInput.shoot = Input.GetKey(KeyCode.Mouse0);
                characterInput.primaryWeapon = Input.GetKeyDown(KeyCode.Alpha1);
                characterInput.secondaryWeapon = Input.GetKeyDown(KeyCode.Alpha2);
            }).Run();
        }
    }
}