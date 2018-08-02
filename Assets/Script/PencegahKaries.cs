using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PencegahKaries : MonoBehaviour {
	public GameObject sikatGigi;
	public GameObject dentalFloss;
	public GameObject obatKumur;
	public GameObject dietKariogenik;
	public GameObject buttonClose;

	//Gosok Gigi
	public GameObject[] imgSikatGigi;
	int indexSikatGigi = 0;

	// Use this for initialization
	void Start () {
		
	}

	public void OpenMenu(int i)
	{
		switch (i) {
		case 1: 
			sikatGigi.SetActive (true);
			dentalFloss.SetActive (false);
			obatKumur.SetActive (false);
			dietKariogenik.SetActive (false);
			break;
		case 2:
			sikatGigi.SetActive (false);
			dentalFloss.SetActive (true);
			obatKumur.SetActive (false);
			dietKariogenik.SetActive (false);
			break;
		case 3:
			sikatGigi.SetActive (false);
			dentalFloss.SetActive (false);
			obatKumur.SetActive (true);
			dietKariogenik.SetActive (false);
			break;
		case 4:
			sikatGigi.SetActive (false);
			dentalFloss.SetActive (false);
			obatKumur.SetActive (false);
			dietKariogenik.SetActive (true);
			break;
		default:
			break;
		}
		buttonClose.SetActive (true);
	}

	public void CloseMenu()
	{
		sikatGigi.SetActive (false);
		dentalFloss.SetActive (false);
		obatKumur.SetActive (false);
		dietKariogenik.SetActive (false);

		buttonClose.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		for (int i = 0; i < imgSikatGigi.Length; i++) {
			if (indexSikatGigi == i) {
				imgSikatGigi [i].SetActive (true);
			} else {
				imgSikatGigi [i].SetActive (false);
			}
		}

	}

	public void NextSikatGigi()
	{
		if (indexSikatGigi < imgSikatGigi.Length) {
			indexSikatGigi = indexSikatGigi + 1;
		} else {
			indexSikatGigi = 0;
		}

	}
}
