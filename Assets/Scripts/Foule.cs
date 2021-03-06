﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Foule : MonoBehaviour {

	public GameManager GM;
	public GameObject Moogle;
	public Transform foule;

	public int nbDancer = 100;
	private float posX;
	private float posY;
	public float circleIncrease = 0.005f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		GM.player.GetComponent<PlayerController> ().speed = 0.2f + (nbDancer * 0.0005f);


		if (Input.GetKey (KeyCode.Space))
			SpawnDancer ();
	}

	private void generateSpawnPosition () {

		switch(Random.Range(1,5)){
		case 1:
			posX = Random.Range (foule.position.x - (foule.GetComponent<CircleCollider2D> ().radius * 0.5f), foule.position.x - (foule.GetComponent<CircleCollider2D> ().radius * 3));
			posY = Random.Range (foule.position.y - (foule.GetComponent<CircleCollider2D> ().radius * 3), foule.position.y + (foule.GetComponent<CircleCollider2D> ().radius * 3));
			break;
		case 2:
			posX = Random.Range (foule.position.x + (foule.GetComponent<CircleCollider2D> ().radius * 0.5f), foule.position.x + (foule.GetComponent<CircleCollider2D> ().radius * 3));
			posY = Random.Range (foule.position.y - (foule.GetComponent<CircleCollider2D> ().radius * 3), foule.position.y + (foule.GetComponent<CircleCollider2D> ().radius * 3));
			break;
		case 3:
			posX = Random.Range (foule.position.x - (foule.GetComponent<CircleCollider2D> ().radius * 0.5f), foule.position.x + (foule.GetComponent<CircleCollider2D> ().radius * 3));
			posY = Random.Range (foule.position.y - (foule.GetComponent<CircleCollider2D> ().radius * 3), foule.position.y - (foule.GetComponent<CircleCollider2D> ().radius * 3));
			break;
		case 4:
			posX = Random.Range (foule.position.x - (foule.GetComponent<CircleCollider2D> ().radius * 0.5f), foule.position.x + (foule.GetComponent<CircleCollider2D> ().radius * 3));
			posY = Random.Range (foule.position.y + (foule.GetComponent<CircleCollider2D> ().radius * 3), foule.position.y + (foule.GetComponent<CircleCollider2D> ().radius * 3));
			break;
		}
	}



	private void SpawnDancer () {


		circleIncrease *= 0.996f;
		foule.GetComponent<CircleCollider2D> ().radius += circleIncrease;
		nbDancer++;
		generateSpawnPosition ();
		GameObject dancerSpawned = Instantiate (Moogle, new Vector2(posX, posY), foule.rotation, foule.transform);
		GameManager.instance.RegisterToPlayer (true, dancerSpawned);

		//d = dancerSpawned.GetComponent<Dancer> ();
		//d.foule = this;
	}
	}