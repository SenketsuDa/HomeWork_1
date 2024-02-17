using Assets.Data.Scripts.HomeWork_1.Concrete;
using Assets.Data.Scripts.HomeWork_1.Interface;
using UnityEngine;

namespace Assets.Data.Scripts.HomeWork_1
{
    public class Bootstrap : MonoBehaviour
    {
        private IWeaponContext _weaponContext;
        [SerializeField] private WeaponChanger _weapongChanger;

        private void Awake()
        {
            _weaponContext = new WeaponContext();

            _weapongChanger.Construct(_weaponContext);
        }


        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
                _weaponContext.Shoot();
        }

    }
}
