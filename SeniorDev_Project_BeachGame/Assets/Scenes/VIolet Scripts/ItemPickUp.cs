using UnityEngine;

public class ItemPickUp : MonoBehaviour
{
    public ItemSO item; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ItemManager.instance.CollectItem(item);
            Destroy(gameObject);
        }
    }
}