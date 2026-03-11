using UnityEngine;

public class GameState
{
    public enum gameState
    {
        WALKING,
        TALKING,
    }

    public gameState State;

    public GameState()
    {
        State = gameState.WALKING;
    }
    


}
