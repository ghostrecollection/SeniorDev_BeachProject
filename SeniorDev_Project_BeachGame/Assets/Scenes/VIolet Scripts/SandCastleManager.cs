using UnityEngine;
using System.Collections.Generic;
using Yarn.Unity;

public class SandCastleManager : MonoBehaviour
{
    public VariableStorageBehaviour variableStorage;
    public List<GameObject> sandCastleStages; 

    private int progress;

    void Start()
    {
        UpdateCastle();
    }
    public void UpdateCastle()
    {
        int progress = LevelManager.instance.currentLevel;

        for (int i = 0; i < sandCastleStages.Count; i++)
        {
            sandCastleStages[i].SetActive(i == progress);  
        }

        if (variableStorage != null)
        {
            variableStorage.SetValue("$castleLevel", progress);
        }
    }  
}