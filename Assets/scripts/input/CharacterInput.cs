using Unity.Entities;

namespace DefaultNamespace.Rival_StandardCharacters.FirstPerson.Scripts.input
{
    public struct CharacterInput : IComponentData
    {
        public bool shoot;
        public bool primaryWeapon;
        public bool secondaryWeapon;
    }
}