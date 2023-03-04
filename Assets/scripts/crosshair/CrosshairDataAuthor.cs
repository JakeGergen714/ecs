using Unity.Entities;
using UnityEngine;

namespace DefaultNamespace.crosshair
{
    public class CrosshairDataAuthor : MonoBehaviour
    {
        public class Baker : Baker<CrosshairDataAuthor>
        {
            public override void Bake(CrosshairDataAuthor authoring)
            {
                AddComponent<CrosshairData>();
            }
        }
    }
}