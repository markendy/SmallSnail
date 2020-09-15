using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Stone : ADrop
{
    protected override void Execude(GameObject gameObjectLocal, int n)
    {
        switch(n){
            case 1:
                gameObjectLocal.GetComponent<Snail>().TakeDamage();
                break;
            case 2:
                gameObjectLocal.GetComponent<GMoney>().Money += addMoney;
                break;
        }
    }
}
