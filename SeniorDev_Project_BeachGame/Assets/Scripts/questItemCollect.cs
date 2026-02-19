using UnityEngine;
using Yarn.Unity;

public class questItemCollect : MonoBehaviour
{
    public static bool qCollected;
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            GetComponent<MeshRenderer>().enabled = false;
            qCollected = true;
        }
    }

    [YarnFunction("qCollectCheck")]
    public static bool collectChecker()
    {
        return qCollected;
    }
}
