using UnityEngine;

public class ResetLocation : MonoBehaviour
{
    private Transform transformPlayer;

    public GameObject respawnPos;
    //public float moveTime = 20f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transformPlayer = GetComponent<Transform>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        /*if(collision.gameObject.CompareTag("Enemy"))
        {
            Respawn();

        }*/

        if(collision.gameObject.CompareTag("Spike"))
        {
            Respawn();
        }
    }

    public void Respawn()
    {
        transform.position = respawnPos.transform.position;
    }
}

