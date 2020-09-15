using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Shell : ADrop
{
    public GameObject posShell;
    public bool active = false;
    protected override void Start()
    {
        base.Start();
        addMoney = 2;
    }
    protected override void Update()
    {
        if(!active)
            base.UpdateParent();
    }
    protected void FixedUpdate()
    {
        if (active)
        {
            gameObject.transform.position = posShell.transform.position;
        }
    }
    public override void Execude(GameObject gameObjectLocal, int n)
    {
        switch (n)
        {
            case 1:
                active = true;
                gameObjectLocal.GetComponent<GMoney>().Money += addMoney;
                break;
            case 2:
                active = false;
                Respawn();
                break;
        }
    }
}
