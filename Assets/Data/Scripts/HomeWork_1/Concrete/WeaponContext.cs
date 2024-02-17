using Assets.Data.Scripts.HomeWork_1.Interface;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace Assets.Data.Scripts.HomeWork_1.Concrete
{
    public class WeaponContext : IWeaponContext
    {
        public IWeapon Current { get; set; } = null;
        public Dictionary<IWeapon, Type> Weapons { get; set; } = null;

        private IEnumerator<KeyValuePair<IWeapon, Type>> _weaponsEnum;

        public WeaponContext()
        {
            Weapons = new Dictionary<IWeapon, Type>();

            InitAllWeapons();

            _weaponsEnum = Weapons.GetEnumerator();
        }

        public void InitAllWeapons()
        {
            _ = new LimitedAmmoWeapon(this);
            _ = new UnlimitedAmmoWeapon(this);
            _ = new MultiShotWeapon(this);
        }

        public void Shoot()
        {
            if (Current == null)
                Debug.Log("Ааааа, нету в руках оружия, упс");
            else
                Current.Shoot();
        }

        public void AddWeapon(IWeapon weapon)
           => Weapons?.TryAdd(weapon, weapon.GetType());


        public void ChangeWeapon(bool isNext)
        {
            if (_weaponsEnum.MoveNext())
                Current = _weaponsEnum.Current.Key;
            else
                _weaponsEnum.Reset();
        }
        
    }
}
