using Unity.Entities;
using UnityEngine;

namespace DefaultNamespace
{
    public class GunAuthoring : MonoBehaviour
    {
        
    }

    public class GunBaker : Baker<GunAuthoring>
    {
        public override void Bake(GunAuthoring authoring)
        {
            CharacterGun gun = GunFactory.createM4();
            this.AddComponent(gun);
        }
    }
}