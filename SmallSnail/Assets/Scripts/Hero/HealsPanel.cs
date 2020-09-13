using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class HealsPanel : MonoBehaviour
{
    [SerializeField] private Text _textHP;
    [SerializeField] private Snail _snail;

    private void Start()
    {
        _snail.DeltaHealsHendler += DrawHP;
        DrawHP();
    }

    private void DrawHP()
    {
        _textHP.text = _snail.Heals.ToString();
    }
}
