using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointScript : MonoBehaviour
{
    //public GameObject Arick;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.GetComponent<ArickRespawn>().reachedCheckPoint(transform.position.x, transform.position.y);

            //GetComponent<Animator>().enabled = true;
        }
    }
}
