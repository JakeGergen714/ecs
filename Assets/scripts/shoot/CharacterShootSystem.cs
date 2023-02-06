using DefaultNamespace.Rival_StandardCharacters.FirstPerson.Scripts.input;
using Unity.Entities;
using Unity.Transforms;
using UnityEngine;

namespace DefaultNamespace.Rival_StandardCharacters.FirstPerson.Scripts.shoot
{
    public partial struct CharacterShootSystem : ISystem
    {
        public void OnCreate(ref SystemState state)
        {
            
        }

        public void OnDestroy(ref SystemState state)
        {
        }

        public void OnUpdate(ref SystemState state)
        {
            foreach (var t in SystemAPI.Query<CharacterInput, LocalTransform>())
            {
                var characterInput = t.Item1;
                var transform = t.Item2;
                if (characterInput.shoot)
                {
                    bool hit = Physics.Raycast(transform.Position, transform.Forward(), Mathf.Infinity);
                    Debug.Log(hit);
                }
            }
        }
    }
}