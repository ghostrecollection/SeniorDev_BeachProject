using UnityEngine;
using UnityEngine.InputSystem;

public class GameStateManager : MonoBehaviour
{
    public static GameStateManager instance;
   public InputManager inputManager;
    public FollowPlayerControl playerFollow;
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

        if (inputManager == null)
            inputManager = FindFirstObjectByType<InputManager>();

        if (playerFollow == null)
            playerFollow = FindFirstObjectByType<FollowPlayerControl>();

        if (pInput == null)
            pInput = FindFirstObjectByType<PlayerInput>();
    }

    public void SetState(GameState.gameState newState)
    {
        CurrentState.State = newState;

        bool isWalking = (newState == GameState.gameState.WALKING);

        if (inputManager != null)
            inputManager.enabled = isWalking;

        if (playerFollow != null)
            playerFollow.enabled = isWalking;

        if (pInput != null)
            pInput.enabled = isWalking;
    }

    void Start()
    {
        SetState(GameState.gameState.WALKING);
    }
}