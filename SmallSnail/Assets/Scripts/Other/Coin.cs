using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : ADrop
{
    protected override void Start()
    {
        base.Start();
        addMoney = 5;
    }
    protected override void Update()
    {
        base.UpdateParent();
    }
    public override void Execude(GameObject gameObjectLocal, int n)
    {
        switch(n){
            case 1:
                gameObjectLocal.GetComponent<GMoney>().Money += addMoney;
                break;
        }
    }
}
