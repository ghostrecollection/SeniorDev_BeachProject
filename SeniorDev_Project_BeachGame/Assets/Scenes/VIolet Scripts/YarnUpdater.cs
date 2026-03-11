using UnityEngine;
using Yarn.Unity;

public class YarnUpdater : MonoBehaviour
{
     public VariableStorageBehaviour variableStorage;
     private int shellCount;
    private int currentLevel;


    void Start()
    {
        UpdateShells();
        UpdateLvl();
    }

    public void UpdateShells()
    {
         int shellCount = LevelManager.instance.shellCount;

        if (variableStorage != null)
            {
                variableStorage.SetValue("$shellCount", shellCount);

            }
    
    }
    public void UpdateLvl()
    {
        int currentLevel = LevelManager.instance.currentLevel;
        if (variableStorage != null)
            {
                variableStorage.SetValue("$currentLevel", currentLevel);

            }
    }

}
