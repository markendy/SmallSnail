using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class GMoney : MonoBehaviour
{
    [SerializeField] private Text moneyText;
    [SerializeField] private double _money;
    public double Money
    {
        get {return _money;}
        set
        {
            _money = value;
            if (DeltaMoneyHendler != null)
                DeltaMoneyHendler();
        }
    }
    public Action DeltaMoneyHendler;
    private void Start()
    {
        DeltaMoneyHendler += DrawMoney;
        Money = 0;
    }
    private void FixedUpdate()
    {
        Money += 0.1;
    }
    private void DrawMoney()
    {
        moneyText.text = ((int)Money).ToString();
    }
}
