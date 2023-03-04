using Unity.Entities;
using Unity.Transforms;
using UnityEngine;

namespace DefaultNamespace.crosshair
{
    public struct CrosshairData : IComponentData
    {
        public float offset;

        public TransformAspect transform;
    }
}