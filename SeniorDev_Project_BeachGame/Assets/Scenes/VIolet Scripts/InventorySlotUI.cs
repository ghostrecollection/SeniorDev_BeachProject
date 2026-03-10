using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class InventorySlotUI : MonoBehaviour
{
    public Image iconImage;
    public TMP_Text countText;

    private int shellCount = 1;
    private ItemSO currentItem;

  

    public void SetItem(ItemSO item)
    {
        currentItem = item;
        iconImage.sprite = item.icon;
        shellCount = 1;
        UpdateText();
    }

    public void IncreaseCount()
    {
        shellCount++;
        UpdateText();

         if (currentItem != null && currentItem.itemName == "Shell" && LevelManager.instance != null)
        {
            LevelManager.instance.SetShellCount(shellCount);
        }
        
    }

    void UpdateText()
    {
        if (shellCount > 1)
        {
            countText.text = "x" + shellCount.ToString();
        }
            
        else
        {
            countText.text = "";
        }
    }
  
}