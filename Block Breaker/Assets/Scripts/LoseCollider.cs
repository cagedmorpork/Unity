﻿using UnityEngine;
using System.Collections;

public class LoseCollider : MonoBehaviour {

	private LevelManager levelManager;

	void Start()
	{
		levelManager = GameObject.FindObjectOfType<LevelManager>();
	}
	
	void OnTriggerEnter2D(Collider2D collider)
	{
		print ("Trigger");
		levelManager.LoadLevel("Lose");
		Brick.breakableCount = 0; // need to reset
	}
	
	void OnCollisionEnter2D(Collision2D collision)
	{
		print ("Collision");
	
	}
}
