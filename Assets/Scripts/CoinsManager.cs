using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinsManager : MonoBehaviour
{
    public Text levelEnd;
    public Text monedasTotales;
    public Text monedas;

    private int totalMonedasInLevel;

    private void Start()
    {
        totalMonedasInLevel = transform.childCount;
    }

    private void Update()
    {
        AllCoinCollected();
        monedasTotales.text = totalMonedasInLevel.ToString();
        monedas.text = transform.childCount.ToString();

    }
    
    public void AllCoinCollected()
    {
        if (transform.childCount == 0)
        {
            Debug.Log("No quedan mas monedas, Nivel completado");
            levelEnd.gameObject.SetActive(true);
            //transition.SetActive(true);
            //Invoke("ChangeScene", 1);
        }
    }

}
