using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using Yarn.Unity;

public class SceneLoader : MonoBehaviour
{
    
    public static SceneLoader Insance;
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadScene(string sceneName)

    {
        SceneManager.LoadScene(sceneName);
    }


}
