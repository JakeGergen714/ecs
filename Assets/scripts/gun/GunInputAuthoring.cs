using Unity.Entities;
using UnityEngine;

namespace DefaultNamespace.gun
{
    public class GunInputAuthoring : MonoBehaviour
    {
       
    }
    
    public class Baker : Baker<GunInputAuthoring>
    {
        public override void Bake(GunInputAuthoring authoring)
        {
            AddComponent(new GunInput());
        }
    }
}