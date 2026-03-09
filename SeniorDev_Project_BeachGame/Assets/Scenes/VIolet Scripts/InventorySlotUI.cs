using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class InventorySlotUI : MonoBehaviour
{
    public Image iconImage;
    public TMP_Text countText;

    private int count = 1;
    private ItemSO currentItem;

    public void SetItem(ItemSO item)
    {
        currentItem = item;
        iconImage.sprite = item.icon;
        count = 1;
        UpdateText();
    }

    public void IncreaseCount()
    {
        count++;
        UpdateText();
    }

    void UpdateText()
    {
        if (count > 1)
        {
            countText.text = "x" + count.ToString();
        }
            
        else
        {
            countText.text = "";
        }
    }
}