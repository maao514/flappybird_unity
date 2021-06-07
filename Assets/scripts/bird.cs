using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird : MonoBehaviour {
	public gamemanager gamemanager;
	public float velocity = 1;
	private Rigidbody2D rb;
	private bool start = false;
	
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			rb.velocity = Vector2.up * velocity;
		}
	}
	private void OnCollisionEnter2D(Collision2D collision){
		gamemanager.GameOver();

	}
	public void fly()
    {
		
	}
}
