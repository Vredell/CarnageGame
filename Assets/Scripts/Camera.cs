using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject Arick;

    void Update()
    {
        if (Arick != null)
        {
            Vector3 position = transform.position;
            position.x = Arick.transform.position.x;
            transform.position = position;
        }
    }
}
