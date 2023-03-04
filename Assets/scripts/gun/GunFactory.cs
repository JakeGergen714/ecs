namespace DefaultNamespace
{
    public class GunFactory
    {
        public static CharacterGun createUsps()
        {
            return new()
            {
                range = 5,
                fireRate = 50,
                crosshairRecoilOffset = 1,
                crosshairDecay = 10f,
            };
        }
        
        public static CharacterGun createM4()
        {
            return new()
            {
                range = 50,
                fireRate = 100,
                crosshairRecoilOffset = 0,
                crosshairDecay = 100f,
                tickBetweenShots = 0,
            };
        }
    }
}