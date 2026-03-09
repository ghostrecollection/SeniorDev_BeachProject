using UnityEngine;
using UnityEngine.SceneManagement;
using Yarn.Unity;

public class LevelCompletion : MonoBehaviour
{
    
    public string mainScene;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            LevelManager.instance.AdvanceLevel();
            SceneManager.LoadScene(mainScene);
        }
    }



}