using Unity.Entities;
using UnityEngine;

namespace DefaultNamespace
{
    public class MovementMono : MonoBehaviour
    {
        public float speed;
    }

    public class MovementBaker : Baker<MovementMono>
    {
        public override void Bake(MovementMono authoring)
        {
            AddComponent(new MoveComponent
            {
                speed = authoring.speed
            });
        }
    }
}