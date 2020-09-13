using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Outplace : AOutplace
{
    public float tg = 0.363970234f;
    public readonly static float tg20def = 0.363970234f;
    public virtual void Update()
    {
        gameObject.transform.position = new Vector3(gameObject.transform.position.x - 0.1f, gameObject.transform.position.y - 0.1f * tg, 0);
    }

    private void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject.GetComponent(typeof(Cube)) as Cube != null)
        {            
            Respawn();
        }
    }
    public void EditTg(float tg_){
        tg = tg_;
    }
    public void ReserTgTo20(){
        tg = tg20def;
    }
}
