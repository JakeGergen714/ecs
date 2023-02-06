using Unity.Entities;
using Unity.Transforms;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Image = UnityEngine.UI.Image;

namespace DefaultNamespace.Rival_StandardCharacters.FirstPerson.Scripts.UI
{
    public partial class MainCanvasSystem : SystemBase
    {
        protected override void OnUpdate()
        {
            if (MainGameObjectCanvas.Instance != null && SystemAPI.HasSingleton<MainEntityCanvas>())
            {
                Entity mainEntityCanvasEntity = SystemAPI.GetSingletonEntity<MainEntityCanvas>();
                LocalToWorld targetLocalToWorld = SystemAPI.GetComponent<LocalToWorld>(mainEntityCanvasEntity);
                Canvas canvas = MainGameObjectCanvas.Instance;
                Image image = canvas.GetComponentInChildren<Image>();
                var rect = image.GetComponent<RectTransform>();
                 rect.anchoredPosition = new Vector2(1,100);
            }
        }
    }
}