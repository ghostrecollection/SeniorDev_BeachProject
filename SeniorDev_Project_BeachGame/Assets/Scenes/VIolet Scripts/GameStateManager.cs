using UnityEngine;

public class GameStateManager : MonoBehaviour
{
    public static GameStateManager instance;

    public FollowPlayerControl playerMovement;
    public GameState CurrentState = new GameState();

    private void Awake()
    {
         if (instance == null)
         {
            instance = this;
         }
        else
        {
            Destroy(gameObject);
        } 
        if (playerMovement == null)
        {
            playerMovement = Object.FindFirstObjectByType<FollowPlayerControl>();
        }
    }
    public void SetState(GameState.gameState newState)
    {
        CurrentState.State = newState;

        if (playerMovement != null)
        {
            playerMovement.enabled = (newState == GameState.gameState.WALKING);
        }

    }
}
