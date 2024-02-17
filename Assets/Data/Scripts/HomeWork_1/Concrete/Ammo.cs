using UnityEngine;

namespace Assets.Data.Scripts.HomeWork_1.Concrete
{
    public class Ammo
    {
        public int Count
        {
            get => _count;
            set => _count = value;
        }

        private int _count = 0;

        public Ammo(int count)
        {
            _count = count;
        }

        public void NextBullet(int count)
        {
            _count -= count;

            if (_count <= 0)
                _count = 0;
        }
    }
}
