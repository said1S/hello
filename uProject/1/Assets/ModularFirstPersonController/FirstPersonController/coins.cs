using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coins : MonoBehaviour
{
    private void OnCollisionEnter(Collision Player)
    {
       playerMananger.coins++;
        Destroy(gameObject);
    }
}
