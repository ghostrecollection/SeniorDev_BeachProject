using UnityEngine;
using Yarn.Unity;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;

    public int currentLevel = 0;

    public VariableStorageBehaviour variableStorage;

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

    public void AdvanceLevel()
    {
        currentLevel++;
        if (variableStorage != null)
        {
            variableStorage.SetValue("$levelsCompleted", currentLevel);
        }

    }
}