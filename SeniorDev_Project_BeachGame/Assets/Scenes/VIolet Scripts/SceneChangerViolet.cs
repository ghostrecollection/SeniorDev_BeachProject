using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangerViolet : MonoBehaviour
{
    public string sceneToLoad;

    public static SceneChangerViolet instance;  
    [SerializeField] Animator transitionAnim;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            NextLevel();
            //WaitForSeconds(3);
            SceneManager.LoadScene(sceneToLoad);
            
        }
    }

    public void NextLevel()
    {
        StartCoroutine(LoadLevel1());
    }

    IEnumerator LoadLevel1()
    {
    

        
        transitionAnim.SetTrigger("End");
        yield return new WaitForSeconds(3);
        //SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1);
        transitionAnim.SetTrigger("Start");
    }

    private Animator GetEndAnim()
    {
       

        GetComponent<Animator>();
        

        return transitionAnim;
    }
}