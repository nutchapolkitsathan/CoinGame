using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    public GameObject coinObject;
    private float coin = 0;


    public void AddCoin()
    {
        coin++;
        Debug.Log(coin);
    }

    public void SpawnCoin()
    {
        Instantiate(coinObject, new Vector3(Random.Range(-3.0f,3.0f), 0.2f, Random.Range(-3.0f, 3.0f)),Quaternion.identity);
    }

    // Start is called before the first frame update
    void Start()
    {
        SpawnCoin();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
