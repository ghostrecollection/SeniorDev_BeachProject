using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager_EndingScene : MonoBehaviour
{
    
    public void ReturnToStart()
    {
        SceneManager.LoadScene(0);
    }

}
