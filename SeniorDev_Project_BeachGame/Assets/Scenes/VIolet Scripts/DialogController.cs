using UnityEngine;
using Yarn.Unity;

public class DialogController : MonoBehaviour
{
    public DialogueRunner dialogueRunner;

    private void OnEnable()
    {
        dialogueRunner.onDialogueStart.AddListener(OnDialogueStart);
        dialogueRunner.onDialogueComplete.AddListener(OnDialogueEnd);
    }

    private void OnDisable()
    {
        dialogueRunner.onDialogueStart.RemoveListener(OnDialogueStart);
        dialogueRunner.onDialogueComplete.RemoveListener(OnDialogueEnd);
    }

    private void OnDialogueStart()
    {
        GameStateManager.instance.SetState(GameState.gameState.TALKING);
    }

    private void OnDialogueEnd()
    {
        GameStateManager.instance.SetState(GameState.gameState.WALKING);
    }
}