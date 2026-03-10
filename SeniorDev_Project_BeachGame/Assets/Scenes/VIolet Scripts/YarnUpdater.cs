using UnityEngine;
using Yarn.Unity;

public class YarnUpdater : MonoBehaviour
{
     public VariableStorageBehaviour variableStorage;
     private int shellCount;

    void Start()
    {
        UpdateShells();
    }

    public void UpdateShells()
    {
         int shellCount = LevelManager.instance.shellCount;

        if (variableStorage != null)
            {
                variableStorage.SetValue("$shellCount", shellCount);

            }


       
    
    }
}
