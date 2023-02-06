using Unity.Entities;
using UnityEngine;

namespace DefaultNamespace
{
    public class CharacterInventoryAuthoring : MonoBehaviour
    {
        
    }

    public class Baker : Baker<CharacterInventoryAuthoring>
    {
        public override void Bake(CharacterInventoryAuthoring authoring)
        {
            var inv = new CharacterInventory()
            {
                currentGun = 1,
                primaryGun = GunFactory.createM4(),
                secondaryGun = GunFactory.createUsps()
            };
            AddComponent(inv);
        }
    }
}