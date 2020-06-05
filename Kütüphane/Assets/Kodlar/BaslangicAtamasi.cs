using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class BaslangicAtamasi : MonoBehaviour
{
    [SerializeField]
    GameObject sayac;

    [SerializeField]
    GameObject panel;

    public Sprite resim1;
    public Sprite resim2;
    public Sprite resim3;
    public Sprite resim4;
    public Sprite resim5;
    public Sprite resim6;
    public Sprite resim7;
    public Sprite resim8;

    private void Start()
    {
        Screen.SetResolution(450, 800, false);

        string metin2 = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Desktop\\Kütüphane\\Sayac.txt";
        StreamReader ader = new StreamReader(metin2);
        int a = Convert.ToInt32(ader.ReadLine());
        sayac.GetComponentInChildren<Text>().text = Convert.ToString(a);
        if(a>=164)
        {
            a = 164;
        }
        for (int i = 0; i < a; i++)
        {
            panel.transform.GetChild(i).gameObject.SetActive(true);
        }
        ader.Close();

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
