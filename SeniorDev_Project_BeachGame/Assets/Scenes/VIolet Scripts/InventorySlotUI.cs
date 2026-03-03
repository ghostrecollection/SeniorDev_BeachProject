using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class InventorySlotUI : MonoBehaviour
{
    public Image iconImage;
    public TMP_Text countText;

    private int count = 1;

    public void SetItem(ItemSO item)
    {
        iconImage.sprite = item.icon;
        countText.text = $"x{count}";
    }

    public void IncreaseCount()
    {
        count++;
        countText.text = $"x{count}";
    }
}