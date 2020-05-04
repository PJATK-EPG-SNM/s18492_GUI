using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole : MonoBehaviour
{ private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
      gameManager = GameObject.Find("GameManager").GetComponent<GetComponent>();
    }

    // Update is called once per frame
    private void OnTriggerEnter2D (Collider2D collision)
    {
    if (collision.gameObject.CompareTag("Player")) {
     Destroy(collision.gameObject);
     gameManager.GameOver();
	}
        
    }
}
