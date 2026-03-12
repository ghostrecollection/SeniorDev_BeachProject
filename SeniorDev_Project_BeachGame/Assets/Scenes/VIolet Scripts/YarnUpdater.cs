using UnityEngine;
using Yarn.Unity;

public class YarnUpdater : MonoBehaviour
{
    public VariableStorageBehaviour variableStorage;

    void Start()
    {
        UpdateShells();
        LvlCount();
    }

    public void UpdateShells()
    {
        int shellCount = LevelManager.instance.shellCount;

        if (variableStorage != null)
        {
            variableStorage.SetValue("$shellCount", shellCount);
        }
    }

    public void LvlCount()
    {
        int currentLevel = LevelManager.instance.currentLevel;

        if (variableStorage != null)
        {
            variableStorage.SetValue("$currentLevel", currentLevel);
        }
    }
}