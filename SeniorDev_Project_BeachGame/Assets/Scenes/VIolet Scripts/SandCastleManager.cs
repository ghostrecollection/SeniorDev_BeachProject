using UnityEngine;
using System.Collections.Generic;
using Yarn.Unity;

public class SandCastleManager : MonoBehaviour
{
    public VariableStorageBehaviour variableStorage;
    public List<GameObject> sandCastleStages; 

    private int currentLevel;

    void Start()
    {
        UpdateCastle();

        //UpdateLvl();
    }

    public void UpdateCastle()
    {
        int currentLevel = LevelManager.instance.currentLevel;

        for (int i = 0; i < sandCastleStages.Count; i++)
        {
            sandCastleStages[i].SetActive(i == currentLevel);
        }
        
    }

    
}