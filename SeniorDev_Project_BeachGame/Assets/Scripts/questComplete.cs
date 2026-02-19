using UnityEngine;
using Yarn.Unity;

public class questComplete : MonoBehaviour
{
    [YarnCommand("_collectItem")]
    public void collectedItem()
    {
        gameObject.SetActive(false);
    }
}
