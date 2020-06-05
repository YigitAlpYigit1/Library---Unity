using System;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class Ekle : MonoBehaviour
{
    [SerializeField]
    GameObject sayac;

    [SerializeField]
    GameObject panel;

    public InputField ad;
    public InputField yazar;
    public InputField not;

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
        if (ad.text != "" && yazar.text != "")
        {
            string metin = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Desktop\\Kütüphane\\Kitaplar.txt";
            StreamWriter writer = new StreamWriter(metin, true);
            writer.WriteLine(ad.text);
            writer.WriteLine(yazar.text);
            writer.WriteLine(not.text);
            writer.Close();
            ad.text = null;
            yazar.text = null;
            not.text = null;

            string metin2 = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Desktop\\Kütüphane\\Sayac.txt";
            StreamReader ader = new StreamReader(metin2);
            int a = Convert.ToInt32(ader.ReadLine());
            a++;
            sayac.GetComponentInChildren<Text>().text = Convert.ToString(a);
            ader.Close();


            string metin3 = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Desktop\\Kütüphane\\Sayac.txt";
            StreamWriter writer3 = new StreamWriter(metin3, false);
            writer3.Write(a);
            writer3.Close();

            string metin4 = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Desktop\\Kütüphane\\Sayac.txt";
            StreamReader reader = new StreamReader(metin4);
            int tut2 = Convert.ToInt32(reader.ReadLine());
            if (tut2 < 165)
            {
                for (int i = 0; i < tut2; i++)
                {
                    panel.transform.GetChild(i).gameObject.SetActive(true);
                }
            }
            reader.Close();

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
        }
    }
}
