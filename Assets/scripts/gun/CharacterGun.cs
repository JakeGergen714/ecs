using Unity.Entities;

namespace DefaultNamespace
{
    public struct CharacterGun : IComponentData
    {
        public int fireRate;
        public int range;
        public int maxBullets;
        public int bulletCount;

        public float crosshairRecoilOffset;
        public float crosshairDecay;

        public bool didShoot;
        public int tickBetweenShots;
        public int tickSinceLastShot;
    }
}