using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SlimeCan : ADrop
{
    public Snail player;
    public GameObject imgTime;
    private bool _active = false;
    public float time = 0f;
    private float _maxTime = 100;
    protected override void Start()
    {
        base.Start();
        addMoney = 2;
        imgTime.GetComponent<Image>().fillAmount = time / _maxTime;
    }
    protected override void Update()
    {
        base.UpdateParent();
    }
    protected void FixedUpdate()
    {
        if (_active)
        {
            --time;
            player.Mul = 0.7f;
        }
        if (time <= 0){
            player.Mul = 0.05f;
            _active = false;
        }
        imgTime.GetComponent<Image>().fillAmount = time / _maxTime;
    }
    public override void Execude(GameObject gameObjectLocal, int n)
    {
        switch (n)
        {
            case 1:
                _active = true;
                time = _maxTime;
                gameObjectLocal.GetComponent<GMoney>().Money += addMoney;
                break;
        }
    }
}
