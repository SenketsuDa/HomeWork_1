using Assets.Data.Scripts.HomeWork_1.Interface;
using TMPro;
using UnityEngine;

namespace Assets.Data.Scripts.HomeWork_1.Concrete
{
    public class WeaponChanger : MonoBehaviour, IWeaponChanger
    {
        [SerializeField] private TMP_Text _currentWeaponText;

        private IWeaponContext _weaponContext;

        public void Construct(
            IWeaponContext weaponContext)
        {
            _weaponContext = weaponContext;
        }

        public void ChangeWeapon(bool isNext)
        {
           _weaponContext.ChangeWeapon(isNext);
           _currentWeaponText.text = $"Выбранное Оружие: {_weaponContext.Current.GetType().Name}";
        }
    }
}
