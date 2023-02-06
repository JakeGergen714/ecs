using Unity.Entities;
using UnityEngine;

namespace DefaultNamespace.Rival_StandardCharacters.FirstPerson.Scripts.UI
{
    public class MainEntityCanvasAuthoring : MonoBehaviour
    {
        public class Baker : Baker<MainEntityCameraAuthoring>
        {
            public override void Bake(MainEntityCameraAuthoring authoring)
            {
                AddComponent<MainEntityCanvas>();
            }
        }
    }
}