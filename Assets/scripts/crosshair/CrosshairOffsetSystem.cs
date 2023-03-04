using DefaultNamespace.Rival_StandardCharacters.FirstPerson.Scripts.input;
using DefaultNamespace.Rival_StandardCharacters.FirstPerson.Scripts.UI;
using Unity.Entities;
using Unity.Transforms;
using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace.crosshair
{
    public partial class CrosshairOffsetSystem : SystemBase
    {
        protected override void OnUpdate()
        {
            Entities.ForEach((Entity e, ref CrosshairData crosshairData, in CharacterInventory inventory, in CharacterInput input) =>
            {
                if (!input.shoot)
                {
                    if (crosshairData.offset > 0)
                    {
                        crosshairData.offset -= inventory.primaryGun.crosshairDecay;
                    }

                    if (crosshairData.offset < 0)
                    {
                        crosshairData.offset = 0;
                    }
                }
                else
                {
                    crosshairData.offset += inventory.primaryGun.crosshairRecoilOffset;
                }
            }).Run();
        }
    }
}