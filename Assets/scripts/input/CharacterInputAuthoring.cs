using Unity.Entities;
using UnityEngine;

namespace DefaultNamespace.Rival_StandardCharacters.FirstPerson.Scripts.input
{
    public class CharacterInputAuthoring : MonoBehaviour
    {
       
    }
    
    public class Baker : Baker<CharacterInputAuthoring>
    {
        public override void Bake(CharacterInputAuthoring authoring)
        {
            AddComponent(new CharacterInput());
        }
    }
}