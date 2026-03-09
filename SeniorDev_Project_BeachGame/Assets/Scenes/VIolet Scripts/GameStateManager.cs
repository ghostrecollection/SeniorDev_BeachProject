using UnityEngine;
using UnityEngine.InputSystem;

public class GameStateManager : MonoBehaviour
{
    public static GameStateManager instance;

    public FollowPlayerControl playerMovement;
    public PlayerInput pInput;
    public Animator playerAnimator;
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

        playerMovement = FindFirstObjectByType<FollowPlayerControl>();
        pInput = GetComponent<PlayerInput>();
        playerAnimator = FindFirstObjectByType<Animator>();
    }

    public void SetState(GameState.gameState newState)
    {
        CurrentState.State = newState;

        if (playerMovement != null)
        {
            playerMovement.enabled = (newState == GameState.gameState.WALKING);
        }
        if (pInput != null)
        {
            pInput.enabled = (newState == GameState.gameState.WALKING);
        }
        if (playerAnimator != null)
    {
        playerAnimator.enabled = (newState == GameState.gameState.WALKING);
    }
    }
}