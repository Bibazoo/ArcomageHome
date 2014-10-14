﻿using UnityEngine;
using System.Collections;
using Arcomage.Core;
using Arcomage.Entity;
using System.Collections.Generic;
using System.Linq;

public class GameController : MonoBehaviour
{

		public Transform respawnCard ;
		public GameObject cards ;

//	public GameObject guiText;

		// Use this for initialization
		void Start ()
		{
				PlayerHelper ps = new PlayerHelper ();


				Vector3 spawnPosition = new Vector3 (respawnCard.position.x - 10, respawnCard.position.y, respawnCard.position.z);
				Quaternion spawnRotation = new Quaternion ();
				spawnRotation = Quaternion.identity;

				while (ps.CountCard < ps.MaxCard) {

						var myCard = ps.GetCard ();

						GameObject card = (GameObject)Instantiate (cards, spawnPosition, spawnRotation);
						spawnPosition.x += 5f;
						spawnPosition.z += 0.5f;
						card.GetComponent<DoneCardScript> ().cardName = myCard.name;

						string Paramscard = string.Empty;
						foreach (var item in myCard.cardParams) {
								if (item.key != Specifications.CostAnimals || 
										item.key != Specifications.CostDiamonds ||
										item.key != Specifications.CostRocks) {
										Paramscard += "Parameter " + item.value.ToString () + "\n";
								}
						}

						var costCard = myCard.cardParams.FirstOrDefault (x => x.key == Specifications.CostAnimals || 
								x.key == Specifications.CostDiamonds ||
								x.key == Specifications.CostRocks).value;


						card.GetComponent<DoneCardScript> ().cardParam = Paramscard;
						card.GetComponent<DoneCardScript> ().cardCost = costCard;

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
		void Update ()
		{
		
		}
}





