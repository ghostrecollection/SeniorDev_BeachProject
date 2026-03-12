using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;
    public int shellCount;
    public int currentLevel;

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

    public void SetShellCount(int amount)
    {
        shellCount += amount;

        if (YarnUpdater.instance != null)
        {
            YarnUpdater.instance.UpdateShells();
        }
    }

    public void AdvanceLevel()
    {
        currentLevel++;

        if (YarnUpdater.instance != null)
        {
            YarnUpdater.instance.UpdateLevel();
            
        }
    }
}