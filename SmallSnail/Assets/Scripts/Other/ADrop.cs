using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ADrop : AOutplace
{
    protected int addMoney = 10;
    protected override void Start()
    {
        base.Start();
    }
    protected virtual void Execude(GameObject gameObjectLocal, int n)
    {

    }
    protected override void Coll(GameObject gameObjectLocal)
    {
        if (gameObjectLocal.GetComponent(typeof(Snail)) as Snail != null)
        {
            if (gameObjectLocal.GetComponent<Snail>().IsNotProtect)
            {
                Execude(gameObjectLocal, 1);
            }
            else
            {
                Execude(gameObjectLocal, 2);
            }
            Respawn();
        }
        if (gameObjectLocal.GetComponent(typeof(ExitCube)) as ExitCube != null)
        {
            GoToTemp();
        }
    }
}
