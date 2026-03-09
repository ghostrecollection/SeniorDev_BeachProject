using UnityEngine;
using Yarn.Unity;
using UnityEngine.InputSystem; 

public class DialogController : MonoBehaviour
{
    public DialogueRunner dialogueRunner;
    public FollowPlayerControl playerMovement;
    public PlayerInput pInput;
    public Animator playerAnimator;

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

        if (playerMovement != null) playerMovement.enabled = false;
        if (pInput != null) pInput.enabled = false;
        if (playerAnimator != null) playerAnimator.enabled = false;
    }

    private void OnDialogueEnd()
    {
        GameStateManager.instance.SetState(GameState.gameState.WALKING);

        if (playerMovement != null) playerMovement.enabled = true;
        if (pInput != null) pInput.enabled = true;
        if (playerAnimator != null) playerAnimator.enabled = true;
    }
}