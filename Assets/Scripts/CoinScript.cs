using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            //GetComponent<SpriteRenderer>().enabled = false;
            //gameObject.transform.GetChild(0).gameObject.SetActive(true);

            FindObjectOfType<CoinsManager>().AllCoinCollected();

            Destroy(gameObject, 0.1f);
        }
    }
  
}
