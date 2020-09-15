using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeaLeavers : ADrop
{
    private int _addHp = 1;
    protected override void Start()
    {
        base.Start();
        addMoney = 5;
    }
    protected override void Execude(GameObject gameObjectLocal, int n)
    {
        switch(n){
            case 1:
                gameObjectLocal.GetComponent<Snail>().Heals += _addHp;
                gameObjectLocal.GetComponent<GMoney>().Money += addMoney;
                break;
        }
    }
}
