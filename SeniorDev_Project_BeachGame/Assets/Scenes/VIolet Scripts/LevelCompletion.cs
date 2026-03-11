using UnityEngine;

public class LevelCompletion : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (LevelManager.instance != null)
            {
                LevelManager.instance.AdvanceLevel();
            }
            else
            {
                Debug.Log("LevelManager instance is Null");
            }
        }
    }
}