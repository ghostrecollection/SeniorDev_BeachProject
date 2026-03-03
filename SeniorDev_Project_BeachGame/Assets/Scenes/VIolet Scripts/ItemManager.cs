using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Yarn.Unity;

public class ItemManager : MonoBehaviour
{
    public static ItemManager instance;

    public int shellCount;

    public GameObject inventoryPanel;
    public GameObject inventorySlotPrefab;
    private Dictionary<ItemSO, InventorySlotUI> inventorySlots = new Dictionary<ItemSO, InventorySlotUI>();

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        } 
        else
        {
            Destroy(gameObject);
        }

        if (inventoryPanel != null)
        {
            inventoryPanel.SetActive(true);
        } 
    }

    public void CollectItem(ItemSO item)
    {

        if (inventorySlots.ContainsKey(item))
        {
            inventorySlots[item].IncreaseCount();
        }
        else
        {
            GameObject slotGO = Instantiate(inventorySlotPrefab, inventoryPanel.transform);
            InventorySlotUI slotUI = slotGO.GetComponent<InventorySlotUI>();
            slotUI.SetItem(item);
            inventorySlots[item] = slotUI;
        }
    }

    
[YarnCommand("GetShellCount")]
public int GetShellCount(string itemName)
    {
        if(itemName == "shell")
            return shellCount;
        return 0;
       
    }
}

    
    
    
    
    /*public void CollectItem(ItemSO item)
    {
        if (itemCounts.ContainsKey(item))
            itemCounts[item]++;
        else
            itemCounts[item] = 1;

        ShowInventoryItem(item);
    }

    private void ShowInventoryItem(ItemSO item)
    {
        inventoryPanel.SetActive(true);

        int count = itemCounts[item];
        itemText.text = $"x{count}"; 
        iconImage.sprite = item.icon;
    }
*/
