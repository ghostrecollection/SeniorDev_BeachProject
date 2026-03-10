using UnityEngine;
using Yarn.Unity;
using UnityEngine.InputSystem; 

public class DialogController : MonoBehaviour
{
    public DialogueRunner dialogueRunner;
    public FollowPlayerControl playerMovement;

    public InputManager inputManager;
    public PlayerInput pInput;
    //public InputAction inputAction;

    void Start()
    {
        inputManager = GetComponentInParent<InputManager>();
        playerMovement = GetComponentInParent<FollowPlayerControl>();
        
        PlayerInput pInput = GetComponent<PlayerInput>();
    }

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

        //if (playerMovement != null) playerMovement.enabled = false;
        if(inputManager!= null) inputManager.enabled = false;
        if (pInput != null) pInput.enabled = false;
        inputManager.move = new Vector2(0,0);
        playerMovement.jumpForce = 0;
        //playerMovement.targetAnimSpeed = playerMovement.walkTarget;


    }

    private void OnDialogueEnd()
    {
        GameStateManager.instance.SetState(GameState.gameState.WALKING);

        //if (playerMovement != null) playerMovement.enabled = true;
       if (pInput != null) pInput.enabled = true;
       if(inputManager!= null) inputManager.enabled = true;

        //inputManager.move = new Vector2(0,0);
        playerMovement.jumpForce = 7; 



    }
}