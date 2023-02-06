using Unity.Burst;
using Unity.Collections;
using Unity.Entities;
using Unity.Transforms;
using UnityEngine;

namespace DefaultNamespace
{
    [BurstCompile]
    [UpdateInGroup(typeof(InitializationSystemGroup))]
    public partial struct MovementSystem : ISystem
    {
        public void OnCreate(ref SystemState state)
        {
        }

        public void OnDestroy(ref SystemState state)
        {
        }

        [BurstCompile]
        public void OnUpdate(ref SystemState state)
        {
            foreach (var q in SystemAPI.Query<TransformAspect, MoveComponent>())
            {
                var t = q.Item1;
                var m = q.Item2;

                bool forward = Input.GetKey(KeyCode.W);

                if (forward)
                {
                    t.LocalPosition = t.LocalPosition + (m.speed * t.Forward);
                }
               
            }
        }
        
    }
}