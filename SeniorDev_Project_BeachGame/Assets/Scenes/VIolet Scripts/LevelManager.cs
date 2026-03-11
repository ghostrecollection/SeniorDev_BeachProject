using UnityEngine;
using Yarn.Unity;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;

    public int currentLevel = 0;
    
    public int shellCount;

    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);
    }

     public void SetShellCount(int amount)
    {
        shellCount = amount;

    }

    public void AdvanceLevel()
    {
        currentLevel++;
    }
    

}