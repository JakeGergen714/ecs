using DefaultNamespace.Rival_StandardCharacters.FirstPerson.Scripts.input;
using Unity.Entities;

namespace DefaultNamespace
{
    public struct CharacterInventory : IComponentData
    {
        public CharacterGun primaryGun;
        public CharacterGun secondaryGun;

        public int currentGun;
    }
}