using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldPickup : MonoBehaviour {
    public int value;
    public GameObject PickupEffect;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            FindObjectOfType<GameManager>().AddGold(value);
            Instantiate(PickupEffect, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
