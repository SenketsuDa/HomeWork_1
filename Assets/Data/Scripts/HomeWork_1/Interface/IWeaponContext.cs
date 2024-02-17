namespace Assets.Data.Scripts.HomeWork_1.Interface
{
    public interface IWeaponContext
    {
        IWeapon Current { get; set; }
        void Shoot();
        void AddWeapon(IWeapon weapon);
        void ChangeWeapon(bool isNext);
    }
}
