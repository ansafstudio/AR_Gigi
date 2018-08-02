using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DietKariogenikMgr : MonoBehaviour {
	public GameObject[] img;
	public GameObject buttonHide;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OpenKeterangan(int index)
	{
		for (int i = 0; i < img.Length; i++) {
			if (i == index) {
				img [i].SetActive (true);
			} else {
				img [i].SetActive (false);
			}
		}
		buttonHide.SetActive (true);
	}

	public void HideKeterangan()
	{
		for (int i = 0; i < img.Length; i++) {
			img [i].SetActive (false);
		}
		buttonHide.SetActive (false);
	}
}
