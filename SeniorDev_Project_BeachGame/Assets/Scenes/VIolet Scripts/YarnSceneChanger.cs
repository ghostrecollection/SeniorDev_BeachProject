using UnityEngine;
using UnityEngine.SceneManagement;
using Yarn.Unity;

public class YarnSceneChanger : MonoBehaviour
{
    public static YarnSceneChanger Instance;

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
    }

    [YarnCommand("load_scene")]
    public void YarnLoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
