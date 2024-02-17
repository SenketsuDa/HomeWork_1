using Assets.Data.Scripts.HomeWork_1.Interface;
using UnityEngine;
namespace Assets.Data.Scripts.HomeWork_1.Concrete
{
    public class MultiShotWeapon : IWeapon
    {
        private Ammo _ammo;
        public MultiShotWeapon(
            IWeaponContext context)
        {
            context.AddWeapon(this);
            _ammo = new Ammo(20);
        }

        public void Shoot()
        {
            if (_ammo.Count > 0)
            {
                _ammo.NextBullet(3);

                for (int i = 0; i < 3; i++)
                {
                    Debug.Log($"Пиу пиу пиу!!!");
                }

                Debug.Log($"Осталось патронов: {_ammo.Count}");

            }
            else
                Debug.Log("Где патроны? =( Их нету!!! =)");


        }
    }
}
