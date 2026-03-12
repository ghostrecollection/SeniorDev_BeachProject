using UnityEngine;
using UnityEngine.SceneManagement;
using Yarn.Unity;

public class SceneLoader : MonoBehaviour
{
    public static SceneLoader Instance;

    void Awake()
    {
        Instance = this;
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    [YarnCommand("load_scene")]
    public void YarnLoadScene(string sceneName)
    {
        LoadScene(sceneName);
    }
}
