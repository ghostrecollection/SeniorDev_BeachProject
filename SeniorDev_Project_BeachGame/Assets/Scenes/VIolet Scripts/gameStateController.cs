using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class gameStateController : MonoBehaviour
{
    public static gameStateController instance { get; private set; }

    public GameState gState;

    public List<IGameStateManager> stateObjs;


    public void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("there already is an instance of gameStateContriller in the scene");
        }
        instance = this;

        gState = new GameState();
    }

    public void Start()
    {
        stateObjs = getAllGameStateObjs();
        
    }

    public void changeState(string state)
    {
        switch (state)
        {
            case "WALKING":
                gState.State = GameState.gameState.WALKING;
                break;
            case "TALKING":
                gState.State = GameState.gameState.TALKING;
                break;
            case "CASTLE":
                gState.State = GameState.gameState.CASTLE;
                break;
             case "MENU":
                gState.State = GameState.gameState.MENU;
                break;
        }
        foreach (IGameStateManager stateObjs in stateObjs)
        {
            stateObjs.GetState(gState);
        }

    }

    public List<IGameStateManager> getAllGameStateObjs()
    {
        IEnumerable<IGameStateManager> stateManagers = FindObjectsByType<MonoBehaviour>(FindObjectsSortMode.None).OfType<IGameStateManager>();
        return new List<IGameStateManager>(stateManagers);
    }
}
