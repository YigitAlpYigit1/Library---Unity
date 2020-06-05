using System;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class Arsiv : MonoBehaviour
{
    [SerializeField]
    GameObject pencere;

    public GameObject arsivAd;
    public GameObject arsivYazar;
    public GameObject arsivNot;

    public void Basildi()
    {
        pencere.SetActive(true);
        string metin = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Desktop\\Kütüphane\\Kitaplar.txt";
        StreamReader reader = new StreamReader(metin);

        arsivAd.GetComponentInChildren<Text>().text = reader.ReadLine();
        arsivYazar.GetComponentInChildren<Text>().text = reader.ReadLine();
        arsivNot.GetComponentInChildren<Text>().text = reader.ReadLine();

        reader.Close();
    }
}
