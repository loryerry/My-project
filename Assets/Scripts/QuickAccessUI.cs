using UnityEngine;
using UnityEngine.UI;

public class QuickAccessUI : MonoBehaviour
{
    public Image[] slotImages; // Массив для спрайтов оружия
    public Inventory inventory; // Ссылка на инвентарь
    public Color activeColor = Color.white;  // Цвет активного слота
    public Color inactiveColor = new Color(1, 1, 1, 0.5f); // Цвет неактивных слотов

    void Start()
    {
        UpdateUI();
    }

    public void UpdateUI()
    {
        for (int i = 0; i < slotImages.Length; i++)
        {
            if (i < inventory.items.Count && inventory.items[i] != null && inventory.items[i].weaponPrefab != null)
            {
                // Устанавливаем спрайт оружия
                slotImages[i].sprite = inventory.items[i].weaponPrefab.GetComponent<SpriteRenderer>().sprite;
                slotImages[i].color = (i == inventory.ActiveSlot) ? activeColor : inactiveColor;
            }
            else
            {
                slotImages[i].sprite = null; // Если слот пустой
                slotImages[i].color = new Color(1, 1, 1, 0); // Делаем его прозрачным
            }
        }
    }
}
