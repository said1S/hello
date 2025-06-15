using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class donateCoins : MonoBehaviour
{
    private void OnCollisionEnter(Collision Player)
    {
        Donate_mananger.donate_coins++;
        Destroy(gameObject);
    }


}
