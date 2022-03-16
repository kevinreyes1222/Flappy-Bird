using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	private Rigidbody2D playerRb;
	
	[SerializeField] private float upForce = 350f;
	
	private bool isDead = false;
    
    void Start()
    {
	    playerRb = GetComponent<Rigidbody2D>();
    }

   
    void Update()
    {
	    if (Input.GetButtonDown("Jump") && !isDead)
	    {
	    	playerRb.velocity = Vector2.zero;
	    	playerRb.AddForce(Vector2.up * upForce);
	    }
    }
    
	
	protected void OnCollisionEnter2D()
	{
		isDead = true;
	}
}
