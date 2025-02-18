using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class Inventory : MonoBehaviour
{
    public List<Item> items = new List<Item>(4);
    public WeaponSwitcher weaponSwitcher;
    private int activeSlot = 0;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) SwitchWeapon(0);
        if (Input.GetKeyDown(KeyCode.Alpha2)) SwitchWeapon(1);
    }

    void SwitchWeapon(int slot)
    {
        activeSlot = slot;
        if (items[slot] != null)
            weaponSwitcher.EquipWeapon(items[slot].weaponPrefab);
    }
}
