using UnityEngine;
using System.Collections.Generic;
using Yarn.Unity;

public class SandCastleManager : MonoBehaviour
{
    public VariableStorageBehaviour variableStorage;
    public List<GameObject> sandCastleStages; 

    private int progress; 
    private bool levelDone;

    public  bool visitOneOct = false;
    public  bool allLevelsCompleted = false; 

    void Awake()
{
    if (variableStorage == null)
        variableStorage = FindObjectOfType<VariableStorageBehaviour>();
}

    void Start()
    {
        UpdateCastle();
    }
    public void UpdateCastle()
    {
        if (LevelManager.instance == null)
        {
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
           if (progress >= 1)
        {
            visitOneOct = true;
            variableStorage.SetValue("$visitOneOct", true);
        }

          if (progress >= 3 )
        {
            allLevelsCompleted = true;

            variableStorage.SetValue("$allLevelsCompleted", true);

        }
    }
    public void OnLevelAdvanced()
    {
        UpdateCastle();
    }
}