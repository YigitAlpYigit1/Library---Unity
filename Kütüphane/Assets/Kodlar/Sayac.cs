using UnityEngine;

public class Sayac : MonoBehaviour
{
    [SerializeField]
    GameObject pencere;

    public void Basildi()
    {
        pencere.SetActive(true);
    }
}