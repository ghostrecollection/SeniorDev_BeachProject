using StarterAssets;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerNPCTalk : MonoBehaviour
{
    public PlayerInput pInput;
    public StarterAssetsInputs mInput;

    public void Start()
    {
        pInput = GetComponent<PlayerInput>();
        mInput = GetComponent<StarterAssetsInputs>();
    }

    public void onTalk()
    {
        pInput.enabled = false;
        mInput.cursorLocked = false;
        mInput.cursorInputForLook = false;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void notTalk()
    {
        pInput.enabled = true;
        mInput.cursorLocked = true;
        mInput.cursorInputForLook = true;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

    }
}
