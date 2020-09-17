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
    public bool INP{ get => IsNotProtect; set {IsNotProtect = value;}}
    private float _speed;
    private float _mul;
    public float Speed { get; set; }
    public float Mul { get; set; }
    private int _heals;
    public float startX;
    public int Heals
    {
        get => _heals;
        set
        {
            if (value >= 10)
            {
                _heals = 10;
            }
            else
            {
                if (value <= 0)
                {
                    if (DeasHendler != null)
                        DeasHendler();
                    Deas();
                }
                _heals = value;
            }
            if (DeltaHealsHendler != null)
                DeltaHealsHendler();
        }
    }
    private void Start()
    {
        startX = gameObject.transform.position.x;
        Speed = 0.02f;
        Mul = 0.05f;
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
                transform.position = new Vector3(gameObject.transform.position.x + Speed * Mul, gameObject.transform.position.y + Speed * Mul * AOutplace.tg20def, 0);
            }
        }
    }
    public void TakeDamage()
    {
        --Heals;
    }

    public void Deas()
    {
        transform.position = new Vector3(0, 10, 0);
    }
    public void Protect()
    {
        IsNotProtect = false;
        GetComponent<Animator>().Play("Protect");
        if (DeltaStatusHendler != null)
            DeltaStatusHendler();
    }
    public void UnProtect(){
        IsNotProtect = true;
        GetComponent<Animator>().Play("Stay");
        if (DeltaStatusHendler != null)
            DeltaStatusHendler();
    }
    //test
    public void AllRespawn(){
        transform.position = new Vector3(1.11f, -0.4f, 0);
        if (Heals <= 0)
            Heals = 5;
        GameObject.Find("Stone").GetComponent<ADrop>().Respawn();
        GameObject.Find("TeaLeaver").GetComponent<ADrop>().Respawn();
        GameObject.Find("SlimeCan").GetComponent<ADrop>().Respawn();
        GameObject.Find("Coin").GetComponent<ADrop>().Respawn();
        //GameObject.Find("Shell").GetComponent<ADrop>().Respawn();
        GameObject.Find("Stone (1)").GetComponent<ADrop>().Respawn();
    }
    public void StopAll(){
        GameObject.Find("Stone").GetComponent<ADrop>().GoToTemp();
        GameObject.Find("TeaLeaver").GetComponent<ADrop>().GoToTemp();
        GameObject.Find("SlimeCan").GetComponent<ADrop>().GoToTemp();
        GameObject.Find("Coin").GetComponent<ADrop>().GoToTemp();
        GameObject.Find("Shell").GetComponent<ADrop>().GoToTemp();
        GameObject.Find("Stone (1)").GetComponent<ADrop>().GoToTemp();
    }
    //end test
}
