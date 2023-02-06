using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverFall : MonoBehaviour
{
    // Start is called before the first frame update

    public GameOverManager gom;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            gom.showGameOver();
        }
    }
}
