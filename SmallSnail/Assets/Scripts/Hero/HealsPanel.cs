using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class HealsPanel : MonoBehaviour
{
    public Text textHP;
    public Snail snail;

    private void Start()
    {
        snail.DeltaHealsHendler += DrawHP;
        DrawHP();
    }

    private void DrawHP()
    {
        textHP.text = snail.Heals.ToString();
    }
}
