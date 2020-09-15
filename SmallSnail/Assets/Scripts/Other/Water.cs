using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : AOutplace
{
    protected override void Start()
    {
        base.Start();
        this.tg = 0;
        this.Speed = -Speed * 1.65f;
    }
    protected override void Coll(GameObject gameObjectLocal)
    {
        base.Coll(gameObjectLocal);
        if (gameObjectLocal.GetComponent(typeof(Snail)) as Snail != null)
        {
            gameObjectLocal.gameObject.GetComponent<Snail>().Deas();
        }
    }
}
