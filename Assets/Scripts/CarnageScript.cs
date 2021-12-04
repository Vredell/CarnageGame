using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarnageScript : MonoBehaviour
{
    public GameObject Arick;

    public void Update()
    {
        Vector3 direction = Arick.transform.position - transform.position;
        if (direction.x >= 0.0f) transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        else transform.localScale = new Vector3(-1.0f, 1.0f, 1.0f);

        float distance = Mathf.Abs(Arick.transform.position.x - transform.position.x);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            //collision.transform.GetComponent<PlayerRespawn>().PlayerDamage();
            Debug.Log("Player Damaged");
            Destroy(collision.gameObject);
        }
    }
}
