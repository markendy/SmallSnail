using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ADrop : AOutplace
{
    protected int addMoney = 3;
    protected override void Start()
    {
        base.Start();
    }
    protected override void Update()
    {

    }
    protected void UpdateParent()
    {
        base.Update();
    }
    public virtual void Execude(GameObject gameObjectLocal, int n)
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
