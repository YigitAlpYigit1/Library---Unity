using System;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class Ileri : MonoBehaviour
{
    [SerializeField]
    GameObject sayac;

    public GameObject arsivAd;
    public GameObject arsivYazar;
    public GameObject arsivNot;
    int a = 0;
    public void Basildi()
    {
        int tut = Convert.ToInt32(sayac.GetComponentInChildren<Text>().text);
        
        if (tut > 1)
        {
            string metin = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Desktop\\Kütüphane\\Kitaplar.txt";
            StreamReader reader = new StreamReader(metin);

            for (int i = 0; i < a+1; i++)
            {
                arsivAd.GetComponentInChildren<Text>().text = reader.ReadLine();
                arsivYazar.GetComponentInChildren<Text>().text = reader.ReadLine();
                arsivNot.GetComponentInChildren<Text>().text = reader.ReadLine();
            }
            a++;
            if (a >= tut)
                a = 0;
            reader.Close();
        }
    }
}
