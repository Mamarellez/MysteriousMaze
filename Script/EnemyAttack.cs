﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour {

	public float timeBetweenAttacks = 0.5f;
	public int attackDamage = 10;

	Animator anim;
	GameObject player;
	PlayerHealth playerHealth;
	EnemyHealth enemyHealth;
	bool playerInrange;
	float timer;

	void Awake()
	{
		player = GameObject.FindGameObjectWithTag ("Player");
		playerHealth = player.GetComponent<PlayerHealth> ();
		enemyHealth = GetComponent<EnemyHealth>();
		anim = GetComponent<Animator> ();
	}

	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject == player) 
		{
			playerInrange = true;
		}
	}

	void OnTriggerExit (Collider other)
	{
		if (other.gameObject == player) 
		{
			playerInrange = false;
		}
	}

	void Update()
	{
		timer += Time.deltaTime;
		if (timer >= timeBetweenAttacks && playerInrange && enemyHealth.currentHealth > 0) {
			Attack ();
		}

		if (playerHealth.currentHealth <= 0) {
			anim.SetTrigger ("PlayerDead");
		}
	}

		void Attack ()
		{
			timer = 0f;

			if (playerHealth.currentHealth > 0)
			{
				playerHealth.TakeDamage (attackDamage);
			}
		}
}
