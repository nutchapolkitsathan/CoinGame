using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController controller;
    private CoinManager coinManager;
    private float speed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        coinManager = GameObject.Find("CoinManager").GetComponent<CoinManager>();
        controller = gameObject.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        controller.Move(move * Time.deltaTime * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Coin")
        {
            Destroy(other.gameObject);
            coinManager.SpawnCoin();
            coinManager.AddCoin();
        }
    }
}
