using DefaultNamespace.crosshair;
using DefaultNamespace.Rival_StandardCharacters.FirstPerson.Scripts.input;
using Rival;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;
using Random = UnityEngine.Random;

namespace DefaultNamespace
{
    public partial class ShootSystem : SystemBase
    {
        protected override void OnUpdate()
        {
            //FirstPersonCharacterComponent aspect = SystemAPI.GetComponent<FirstPersonCharacterComponent>(t);

            Entities.ForEach(
                (Entity e, ref GunInput gunInput, ref CrosshairData crosshairData, ref CharacterGun gun, in TransformAspect transform, in Parent parent) =>
                {
                    var grandParent = SystemAPI.GetComponent<Parent>(parent.Value);
                    
                    var firstPersonCharacterAspect = SystemAPI.GetAspectRO<FirstPersonCharacterAspect>(grandParent.Value);
                    var characterAspect = firstPersonCharacterAspect.CharacterAspect;
                    var firstPersonCharacterComponent = firstPersonCharacterAspect.CharacterComponent;

                    Debug.Log(gun.tickSinceLastShot);
                    if (gunInput.shoot && (gun.tickSinceLastShot >= gun.tickBetweenShots))
                    {
                        float3 camPosition = getCamaraPostion(characterAspect, transform);
                        float3 lookDirection = getLookDirection(firstPersonCharacterComponent.ValueRO, characterAspect);
                        
                        Debug.Log(camPosition);
                        Debug.DrawRay(camPosition, lookDirection* 50, Color.black, 10f);

                        gun.tickSinceLastShot = 0;
                    }
                    else
                    {
                        if (gun.tickSinceLastShot < gun.tickBetweenShots)
                        {
                            gun.tickSinceLastShot++;
                        }
                    }
                }).WithoutBurst().Run();
        }

        private float3 getCamaraPostion(KinematicCharacterAspect characterAspect, TransformAspect transform)
        {
            var camPosition = characterAspect.LocalTransform.ValueRO.Position;
            camPosition.y = transform.WorldPosition.y;
            return camPosition;
        }

        private float3 getLookDirection(FirstPersonCharacterComponent firstPersonCharacterComponent, KinematicCharacterAspect characterAspect)
        {
            return math.mul(firstPersonCharacterComponent.ViewLocalRotation, characterAspect.Forward);
        }
    }
}