using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Snail : MonoBehaviour
{
    public Action DeasHendler;
    public Action DeltaStatusHendler;
    public Action DeltaHealsHendler;
    public bool IsNotProtect;
    private float _speed;
    public float Speed { get; set; }
    private int _heals;
    public float startX;
    public int Heals
    {
        get => _heals;
        set
        {
            if (value <= 0)
            {
                if (DeasHendler != null)
                    DeasHendler();
            //deas?
            transform.position = new Vector3(30, 30, 0);
            }
            _heals = value;
            if (DeltaHealsHendler != null)
                DeltaHealsHendler();
        }
    }
    private void Start()
    {
        startX = gameObject.transform.position.x;
        Speed = 0.012f;
        Heals = 5;
        IsNotProtect = true;
    }
    private void Update()
    {
        if (!IsNotProtect)
        {
            transform.position = new Vector3(gameObject.transform.position.x - Speed, gameObject.transform.position.y - Speed * AOutplace.tg20def, 0);
        }
        else
        {
            if (gameObject.transform.position.x < startX)
            {
                transform.position = new Vector3(gameObject.transform.position.x + Speed * 1.5f, gameObject.transform.position.y + Speed * 1.5f * AOutplace.tg20def, 0);
            }
        }
    }
    public void TakeDamage()
    {
        --Heals;
    }

    public void Deas(){
        Heals = 0;
    }

    public void Protect()
    {
        IsNotProtect = !IsNotProtect;
        //temp!!! change to delta texture
        Vector3 vec;
        if (IsNotProtect)
            vec = new Vector3(1f, 1f, 0);
        else
            vec = new Vector3(0.7f, 0.7f, 0);
        transform.localScale = vec;
        if (DeltaStatusHendler != null)
            DeltaStatusHendler();
    }
}
