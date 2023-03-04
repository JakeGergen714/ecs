using System;
using System.Collections.Generic;
using DefaultNamespace.Rival_StandardCharacters.FirstPerson.Scripts.UI;
using Unity.Entities;
using Unity.Transforms;
using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace.crosshair
{
    public partial class CrosshairSystem : SystemBase
    {
        protected override void OnUpdate()
        {
            if (MainGameObjectCanvas.Instance == null || !SystemAPI.HasSingleton<MainEntityCanvas>())
            {
                return;
            }

            Entity mainEntityCanvasEntity = SystemAPI.GetSingletonEntity<MainEntityCanvas>();

            Entities.ForEach((Entity e, ref CrosshairData crosshairData, in TransformAspect t) =>
            {
                crosshairData.transform = t;
                LocalToWorld targetLocalToWorld = SystemAPI.GetComponent<LocalToWorld>(mainEntityCanvasEntity);
                Canvas canvas = MainGameObjectCanvas.Instance;
                Image[] images = canvas.GetComponentsInChildren<Image>();
                foreach (var image in images)
                {
                    var rect = image.GetComponent<RectTransform>();
                    rect.anchoredPosition = getCrosshairDataForName(image.tag, crosshairData);
                }
            }).Run();
        }

        private static Vector2 getCrosshairDataForName(String tag, CrosshairData crosshairData)
        {
            if (tag.Equals(CrosshairConstants.TOP_CROSS_HAIR_TAG))
            {
                Vector2 newPos = new Vector2(0, crosshairData.offset);
                return newPos;
            }
            else if (tag.Equals(CrosshairConstants.BOTTOM_CROSS_HAIR_TAG))
            {
                Vector2 newPos = new Vector2(0, -crosshairData.offset);
                return newPos;
            }
            else if (tag.Equals(CrosshairConstants.RIGHT_CROSS_HAIR_TAG))
            {
                Vector2 newPos = new Vector2(crosshairData.offset, 0);
                return newPos;
            }
            else if (tag.Equals(CrosshairConstants.LEFT_CROSS_HAIR_TAG)) 
            {
                Vector2 newPos = new Vector2(-crosshairData.offset, 0);
                return newPos;
            }
            else
            {
                throw new Exception("you messed up the tag system");
            }
        }
    }
}