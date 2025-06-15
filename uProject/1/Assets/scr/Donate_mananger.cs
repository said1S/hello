using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Donate_mananger : MonoBehaviour
{
    public static int donate_coins;
    [SerializeField] private  TextMeshProUGUI DonateCoinsText;

    private void Update()
    {
        DonateCoinsText.text = "" + donate_coins;
    }
}
