using UnityEngine;

public class GameState
{
    public enum gameState
    {
        WALKING,
        TALKING,
        CASTLE,
        MENU
    }

    public gameState State;

    public GameState()
    {
        State = gameState.WALKING;
    }
    


}
