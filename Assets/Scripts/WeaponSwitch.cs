using UnityEngine;

public class WeaponSwitch : MonoBehaviour
{
    public string currentWeapon = "Sword"; // Standaard wapen
    private int damage;
    private float attackSpeed;

    void Update()
    {
        // Check voor wapenwissel
        if (Input.GetKeyDown(KeyCode.Alpha1)) SwitchWeapon("Sword");
        if (Input.GetKeyDown(KeyCode.Alpha2)) SwitchWeapon("Bow");
        if (Input.GetKeyDown(KeyCode.Alpha3)) SwitchWeapon("Staff");
        if (Input.GetKeyDown(KeyCode.Alpha4)) SwitchWeapon("Dagger");
    }

    void SwitchWeapon(string newWeapon)
    {
        currentWeapon = newWeapon;

        // Bereken stats
        switch (currentWeapon)
        {
            case "Sword":
                damage = 25;
                attackSpeed = 1.0f;
                break;
            case "Bow":
                damage = 20;
                attackSpeed = 1.5f;
                break;
            case "Staff":
                damage = 35;
                attackSpeed = 0.7f;
                break;
            case "Dagger":
                damage = 15;
                attackSpeed = 2.0f;
                break;
            default:
                damage = 10;
                attackSpeed = 1.0f;
                break;
        }

        Debug.Log($"Current Weapon: {currentWeapon} | Damage: {damage} | Attack Speed: {attackSpeed}");
    }
}
