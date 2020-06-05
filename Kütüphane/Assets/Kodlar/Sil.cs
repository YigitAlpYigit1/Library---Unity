using System;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class Sil : MonoBehaviour
{
    [SerializeField]
    GameObject sayac;

    [SerializeField]
    GameObject panel;

    [SerializeField]
    GameObject panel2;

    public GameObject arsivAd;
    public GameObject arsivYazar;
    public GameObject arsivNot;

    public Sprite resim1;
    public Sprite resim2;
    public Sprite resim3;
    public Sprite resim4;
    public Sprite resim5;
    public Sprite resim6;
    public Sprite resim7;
    public Sprite resim8;

    public void Basildi()
    {
        int tut = Convert.ToInt32(sayac.GetComponentInChildren<Text>().text);
        if (tut > 0)
        {
            string metin = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Desktop\\Kütüphane\\Kitaplar.txt";
            StreamReader reader = new StreamReader(metin);

            for (int i = 0; i < tut + 1; i++)
            {
                string metin2 = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Desktop\\Kütüphane\\Gecici.txt";
                StreamWriter writer = new StreamWriter(metin2, true);
                string tut1 = reader.ReadLine();
                string tut2 = reader.ReadLine();
                string tut3 = reader.ReadLine();
                if (tut1 != arsivAd.GetComponentInChildren<Text>().text ||
                    tut2 != arsivYazar.GetComponentInChildren<Text>().text ||
                    tut3 != arsivNot.GetComponentInChildren<Text>().text)
                {
                    if (tut1 != null || tut2 != null || tut3 != null)
                    {
                        writer.WriteLine(tut1);
                        writer.WriteLine(tut2);
                        writer.WriteLine(tut3);
                    }
                }
                writer.Close();
            }
            reader.Close();

            string metin5 = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Desktop\\Kütüphane\\Kitaplar.txt";
            StreamWriter writer3 = new StreamWriter(metin5, false);
            writer3.Write("");
            writer3.Close();

            string metin3 = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Desktop\\Kütüphane\\Gecici.txt";
            StreamReader reader2 = new StreamReader(metin3);
            for (int i = 0; i < tut; i++)
            {
                string metin4 = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Desktop\\Kütüphane\\Kitaplar.txt";
                StreamWriter writer2 = new StreamWriter(metin4, true);
                string tut4 = reader2.ReadLine();
                string tut5 = reader2.ReadLine();
                string tut6 = reader2.ReadLine();
                if (tut4 != null || tut5 != null || tut6 != null)
                {
                    writer2.WriteLine(tut4);
                    writer2.WriteLine(tut5);
                    writer2.WriteLine(tut6);
                }
                writer2.Close();
            }
            reader2.Close();

            string metin6 = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Desktop\\Kütüphane\\Sayac.txt";
            StreamReader reader3 = new StreamReader(metin6);
            int tutucu = Convert.ToInt32(reader3.ReadLine());
            if (tutucu != 0)
            {
                tutucu--;
            }
            else
                tutucu = 0;
            reader3.Close();

            string metin7 = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Desktop\\Kütüphane\\Sayac.txt";
            StreamWriter writer4 = new StreamWriter(metin7, false);
            writer4.Write(tutucu);
            sayac.GetComponentInChildren<Text>().text = Convert.ToString(tutucu);
            writer4.Close();

            string metin8 = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Desktop\\Kütüphane\\Sayac.txt";
            StreamReader reader4 = new StreamReader(metin8);
            int tuttu = Convert.ToInt32(reader4.ReadLine());
            if (tuttu >= 0)
            {
                panel.transform.GetChild(tuttu).gameObject.SetActive(false);
            }
            reader4.Close();

            int say = Convert.ToInt32(sayac.GetComponentInChildren<Text>().text);

            if (say < 17)
                sayac.GetComponent<Image>().overrideSprite = resim1;
            else if (say >= 17 && say < 43)
                sayac.GetComponent<Image>().overrideSprite = resim2;
            else if (say >= 43 && say < 64)
                sayac.GetComponent<Image>().overrideSprite = resim3;
            else if (say >= 64 && say < 85)
                sayac.GetComponent<Image>().overrideSprite = resim4;
            else if (say >= 85 && say < 108)
                sayac.GetComponent<Image>().overrideSprite = resim5;
            else if (say >= 108 && say < 130)
                sayac.GetComponent<Image>().overrideSprite = resim6;
            else if (say >= 130 && say < 148)
                sayac.GetComponent<Image>().overrideSprite = resim7;
            else if (say >= 148)
                sayac.GetComponent<Image>().overrideSprite = resim8;

            string metinilk = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Desktop\\Kütüphane\\Gecici.txt";
            StreamWriter writer12 = new StreamWriter(metinilk, false);
            writer12.Write("");
            writer12.Close();

            panel2.SetActive(false);
        }
    }
}
