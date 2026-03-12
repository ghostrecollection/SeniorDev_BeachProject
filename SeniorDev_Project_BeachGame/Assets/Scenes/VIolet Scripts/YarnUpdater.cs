using UnityEngine;
using Yarn.Unity;

public class YarnUpdater : MonoBehaviour
{
    public static YarnUpdater instance;
    public VariableStorageBehaviour variableStorage;

    void Awake()
    {
        instance = this;
    }

   public void UpdateShells()
{
    int shellCount = LevelManager.instance.shellCount;
    if (variableStorage != null)
    {
        variableStorage.SetValue("$shellCount", shellCount);
    }
}
    public void UpdateLevel()
{
    int currentLevel = LevelManager.instance.currentLevel;
    if (variableStorage != null)
    {
        variableStorage.SetValue("$currentLevel", currentLevel);
        variableStorage.SetValue("$castleLevel", currentLevel);
    }
    else
    {
        Debug.Log("OMGH JFNSSAK");
    }
}

}