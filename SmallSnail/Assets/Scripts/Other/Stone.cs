using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Stone : AOutplace
{
    
    private void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject.GetComponent(typeof(Snail)) as Snail != null)
        {
            if(collider.gameObject.GetComponent<Snail>().IsNotProtect){
                collider.gameObject.GetComponentInParent<Snail>().TakeDamage();
            }
            else{
                collider.gameObject.GetComponentInParent<GMoney>().Money += 10;
            }
            Respawn();
        }
        if (collider.gameObject.GetComponent(typeof(Cube)) as Cube != null)
        {
            GoToTemp();
        }
    }
}
