using UnityEngine;

namespace Main.Enemy.OSData
{
    [CreateAssetMenu(fileName = "New MobOSData",  menuName = "Enemy/MobOSData")]
    public class MobOSData: ScriptableObject
    {
        public float HP;
        public float Damage;
    }
}
