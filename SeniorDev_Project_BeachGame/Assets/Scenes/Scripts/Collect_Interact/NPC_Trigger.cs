using UnityEngine;
using UnityEngine.Events;
using Unity.Cinemachine;

public class NPC_Trigger : MonoBehaviour
{
    public UnityEvent npcTrigger;
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            npcTrigger.Invoke();
        }
    }
}
