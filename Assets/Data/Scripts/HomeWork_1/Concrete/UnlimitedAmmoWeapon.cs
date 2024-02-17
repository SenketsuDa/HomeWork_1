using Assets.Data.Scripts.HomeWork_1.Interface;
using UnityEngine;

namespace Assets.Data.Scripts.HomeWork_1.Concrete
{
    public class UnlimitedAmmoWeapon : IWeapon
    {
        private Ammo _ammo;
        public UnlimitedAmmoWeapon(
            IWeaponContext context)
        {
            context.AddWeapon(this);
            _ammo = new Ammo(99999);
        }
        public void Shoot()
        {
            if (_ammo.Count > 0)
            {
                _ammo.NextBullet(1);
                Debug.Log($"Пиу пиу пиу!!! Осталось патронов: {_ammo.Count}, очень-очень много .О.");
            }
            else
                Debug.Log("Где патроны? =( Их нету!!! =)");
        }
    }
}
