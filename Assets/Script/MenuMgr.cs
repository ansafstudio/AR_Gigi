using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuMgr : MonoBehaviour {
    public GameObject canvas_FormIdentitas;
    public GameObject canvas_MainMenu;
	public GameObject canvas_Info;
	public GameObject canvas_Panduan;


	// Use this for initialization
	void Start () {
        /*if (PlayerPrefs.GetInt("identitas", 0) != 1)
        {
            canvas_FormIdentitas.SetActive(true);
        }
        else
        {
            canvas_FormIdentitas.SetActive(false);
        }*/
    }
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp(KeyCode.Escape)) {
			if (canvas_MainMenu.activeSelf) {
				Application.Quit ();
			} else {
				//canvas_MainMenu.SetActive (true);
				BacktoMainMenu();
			}
		}

	}

    public void StartAR()
    {
        canvas_MainMenu.SetActive(false);
		canvas_Info.SetActive (false);
		canvas_Panduan.SetActive (false);
    }

	public void OpenPanduan()
	{
		canvas_MainMenu.SetActive(false);
		canvas_Info.SetActive (false);
		canvas_Panduan.SetActive (true);
	}

	public void OpenInfo()
	{
		canvas_MainMenu.SetActive(false);
		canvas_Info.SetActive (true);
		canvas_Panduan.SetActive (false);
	}

	public void BacktoMainMenu()
	{
		canvas_MainMenu.SetActive(true);
		canvas_Info.SetActive (false);
		canvas_Panduan.SetActive (false);
	}

	public void OpenBukuSaku()
	{
        Application.OpenURL("https://drive.google.com/open?id=1mLQ3rGaFq4jSgXOISgHRSW2qg6O4yzZ4");
    }

	public void IsiKuisioner()
	{
        Application.OpenURL("https://goo.gl/forms/pPKQ2Oo4E9a7xh712");
	}
}
