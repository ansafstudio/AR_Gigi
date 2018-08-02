using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoogleFormMgr : MonoBehaviour {
    public GameObject g_nama;
    public GameObject g_usia;
    public GameObject g_alamat;

    private string Nama;
    private string Usia;
    private string Alamat;

    [SerializeField]
    private string BASE_URL = "https://docs.google.com/forms/d/e/1FAIpQLSew2vYb-TgvINfEXw-cCzSzmbufehIDrNgqqw-0Fn6CtXHvnw/formResponse";
    //https://goo.gl/forms/hCcvBuySLtSRKmw33
    //https://docs.google.com/forms/d/e/1FAIpQLSew2vYb-TgvINfEXw-cCzSzmbufehIDrNgqqw-0Fn6CtXHvnw/viewform?usp=sf_link

    //https://docs.google.com/spreadsheets/d/1K_Oi5ieGAPMoGZ58NTHZ8bbPpWNXraVlwXoULIxMEy4/edit#gid=1274142134


    public GameObject canvas_formIdentitas;
    public GameObject canvas_mainMenu;

    IEnumerator Post(string nama, string usia, string alamat)
    {
        WWWForm form = new WWWForm();
        form.AddField("entry.19780786", nama);
        form.AddField("entry.26413819", usia);
        form.AddField("entry.1649656294", alamat);
        byte[] rawData = form.data;
        WWW www = new WWW(BASE_URL, rawData);
        yield return www;
    }
    public void Send()
    {
        Nama = g_nama.GetComponent<InputField>().text;
        Usia = g_usia.GetComponent<InputField>().text;
        Alamat = g_alamat.GetComponent<InputField>().text;
        StartCoroutine(Post(Nama, Usia, Alamat));


        canvas_formIdentitas.SetActive(false);
        canvas_mainMenu.SetActive(true);

        PlayerPrefs.SetInt("indentitas", 1);
    }
}
