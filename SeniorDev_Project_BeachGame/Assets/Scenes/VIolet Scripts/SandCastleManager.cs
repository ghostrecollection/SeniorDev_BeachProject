using UnityEngine;
using System.Collections.Generic;

public class SandCastleManager : MonoBehaviour
{
    public List<GameObject> sandCastleStages; 

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
    }
}