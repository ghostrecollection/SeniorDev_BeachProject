using UnityEngine;
using UnityEngine.InputSystem;

public class GameStateManager : MonoBehaviour
{
    public static GameStateManager instance;
    public InputManager inputManager;
    public  FollowPlayerControl playerFollow;
    public PlayerInput pInput;


    public GameState CurrentState = new GameState();
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        inputManager = FindFirstObjectByType<InputManager>();

        playerFollow = FindFirstObjectByType<FollowPlayerControl>();
        
        pInput = GetComponent<PlayerInput>();
        
    }

    public void SetState(GameState.gameState newState)
    {
        CurrentState.State = newState;

        if (inputManager != null)
        {
            inputManager.enabled = (newState == GameState.gameState.WALKING);
        }
        if (playerFollow != null)
        {
            //playerFollow.enabled = (newState == GameState.gameState.WALKING);
        }
        if (pInput != null)
        {
            pInput.enabled = (newState == GameState.gameState.WALKING);
        }
        
    }
}