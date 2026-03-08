using System.Collections;
using UnityEngine;

public class Expression_Blinking : MonoBehaviour
{
    // The material attached to the face.
    [SerializeField] private Material idleExpression;

    // Reference to the source image of both idle and blink --
    // -- allowing it to switch between the expressions.
    [SerializeField] public Texture2D idle, blink;

    // Variables for how long to wait between switching the expression texture.
    [SerializeField] public float preBlink = 3f, postBlink = .5f;

    public bool canBlink = true;
    

    private void Update()
    {
        if (canBlink)
        {
            // Start Coroutine -- when finished repeat.
            StartCoroutine(Blinking());
            canBlink = false;
        }
    }

    IEnumerator Blinking()
    {
        //Debug.Log("Starting first wait!");
        yield return new WaitForSeconds(preBlink);
        idleExpression.mainTexture = blink;
        //Debug.Log("Finished first wait.");
        //Debug.Log("Starting second wait!");
        yield return new WaitForSeconds(postBlink);
        idleExpression.mainTexture = idle;
        //Debug.Log("Finished second wait.");
        canBlink = true;
    }
}
