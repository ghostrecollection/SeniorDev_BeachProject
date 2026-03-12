using UnityEngine;
using UnityEngine.SceneManagement;
using Yarn.Unity;

public class YarnSceneChanger : MonoBehaviour
{

    public DialogueRunner dialogueRunner;

    public void Awake()
    {
        
        dialogueRunner.AddCommandHandler<string>("load_scene", LoadScene);
    }

    private void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}