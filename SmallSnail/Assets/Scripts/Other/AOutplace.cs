using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class AOutplace : MonoBehaviour
{
    public float tg = 0.363970234f;
    public readonly static float tg20def = 0.363970234f;
    private float _speed = 0.035f;
    public float Speed { get => _speed; set { _speed = value; } }
    public GameObject spawnObj;
    private GameObject _tempSpawnObj;
    protected virtual void Start()
    {
        _tempSpawnObj = GameObject.FindGameObjectWithTag("TempPlace");
    }
    protected virtual void Update()
    {
        gameObject.transform.position = new Vector3(gameObject.transform.position.x - Speed, gameObject.transform.position.y - Speed * tg, 0);
    }
    public void GoToTemp()
    {
        transform.position = _tempSpawnObj.transform.position;
    }
    public void Respawn()
    {
        transform.position = spawnObj.transform.position;
    }
    public void EditTg(float tg_)
    {
        tg = tg_;
    }
    public void ReserTgTo20()
    {
        tg = tg20def;
    }
    protected void OnCollisionEnter2D(Collision2D collision)
    {
        Caclulate<Collision2D>(collision);
    }
    protected void OnTriggerEnter2D(Collider2D collider)
    {
        Caclulate<Collider2D>(collider);
    }
    protected void Caclulate<T>(T other)
    {
        GameObject gameObjectLocal;
        if (typeof(T) == typeof(Collider2D))
        {
            Collider2D obj = (Collider2D)(object)other;
            gameObjectLocal = obj.gameObject;
        }
        else
        {
            Collision2D obj = (Collision2D)(object)other;
            gameObjectLocal = obj.gameObject;
        }
        Coll(gameObjectLocal);
    }
    protected virtual void Coll(GameObject gameObjectLocal){
        if (gameObjectLocal.GetComponent(typeof(ExitCube)) as ExitCube != null)
        {
            Respawn();
        }
    }
}
