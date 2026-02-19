using UnityEngine;
using UnityEngine.Events;

public class NPC_Trigger : MonoBehaviour
{
    public UnityEvent dialogTrigger;

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            dialogTrigger.Invoke();
        }
    }
}
