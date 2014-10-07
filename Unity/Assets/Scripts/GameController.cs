﻿using UnityEngine;
using System.Collections;
//using Arcomage.Core;

/// <summary>
/// Временная заглушка
/// </summary>
public class PlayerHelper
{
	public int CountCard=0;
	public int MaxCard=6;
}

public class GameController : MonoBehaviour {

	public Transform respawnCard ;

	public GameObject cards ;

//	public GameObject guiText;

	// Use this for initialization
	void Start () {
		PlayerHelper ps = new PlayerHelper ();
		Vector3 spawnPosition = new Vector3 (respawnCard.position.x-10 , respawnCard.position.y, respawnCard.position.z);
		Quaternion spawnRotation =new Quaternion();
		spawnRotation= Quaternion.identity;

		while (ps.CountCard < ps.MaxCard) {

			GameObject card = (GameObject) Instantiate (cards,spawnPosition, spawnRotation);
			spawnPosition.x += 5f;
			card.GetComponent<QuadCardController>().cardName = "Card "+ps.CountCard;
			card.GetComponent<QuadCardController>().cardParam = "Parameter "+ps.CountCard;
			card.GetComponent<QuadCardController>().cardCost = ps.CountCard;
			ps.CountCard++;

				}

//		GUIText[] ts = guiText.GetComponentsInChildren<GUIText>();
//
//		foreach (GUIText t in ts) {
//			if (t != null && t.text != null)
//				t.text = "11";
//		}




	}
	
	// Update is called once per frame
	void Update () {
		
	}
}





