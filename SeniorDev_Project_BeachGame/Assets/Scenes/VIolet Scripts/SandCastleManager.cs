using UnityEngine;
using System.Collections.Generic;
using Yarn.Unity;

public class SandCastleManager : MonoBehaviour
{
    public VariableStorageBehaviour variableStorage;
    public List<GameObject> sandCastleStages; 

    private int progress; 
    private bool levelDone;

    void Start()
    {
        UpdateCastle();
    }
    public void UpdateCastle()
    {
        if (LevelManager.instance == null)
        {
            Debug.LogError("LevelManager.instance is null!");
            return;
        }
        progress = LevelManager.instance.currentLevel;
        for (int i = 0; i < sandCastleStages.Count; i++)
        {
            sandCastleStages[i].SetActive(i == progress);  
        }
        if (variableStorage != null)
        {
            variableStorage.SetValue("$castleLevel", progress);
            levelDone = (progress >= sandCastleStages.Count - 1);
            variableStorage.SetValue("$levelDone", levelDone);
        }
    }
    public void OnLevelAdvanced()
    {
        UpdateCastle();
    }
}