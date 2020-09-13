using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : Outplace
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public override void Update()
    {
        gameObject.transform.position = new Vector3(gameObject.transform.position.x - 0.1f, gameObject.transform.position.y, 0);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent(typeof(Cube)) as Cube != null)
        {            
            Respawn();
        }
        if (collision.gameObject.GetComponent(typeof(Snail)) as Snail != null)
        {
            collision.gameObject.GetComponent<Snail>().Deas();   
        }
    }
}
