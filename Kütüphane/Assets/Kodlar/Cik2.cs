using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class Cik2 : MonoBehaviour
{
    [SerializeField]
    GameObject pencere;
    public void Basildi()
    {
        pencere.SetActive(false);
    }
}