using UnityEngine;

public class ItemPickUp : MonoBehaviour
{
    public ItemSO item; 
    public AudioSource collectSound;

    void Start()
    {
        //collectSound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            collectSound.Play();
            ItemManager.instance.CollectItem(item);
            Destroy(gameObject);
        }
    }
}