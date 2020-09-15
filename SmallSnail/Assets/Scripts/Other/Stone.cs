using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Stone : ADrop
{
    protected override void Coll(GameObject gameObjectLocal)
    {
        base.Coll(gameObjectLocal);   
        if (gameObjectLocal.GetComponent(typeof(Shell)) as Shell != null && gameObjectLocal.GetComponent<Shell>().active)
        {
            gameObjectLocal.GetComponent<Shell>().Execude(gameObjectLocal, 2);
            Respawn();
        }
    }
    public override void Execude(GameObject gameObjectLocal, int n)
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
