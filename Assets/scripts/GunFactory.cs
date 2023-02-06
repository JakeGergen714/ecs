namespace DefaultNamespace
{
    public class GunFactory
    {
        public static CharacterGun createUsps()
        {
            return new()
            {
                range = 5,
                fireRate = 50
            };
        }
        
        public static CharacterGun createM4()
        {
            return new()
            {
                range = 50,
                fireRate = 100
            };
        }
    }
}