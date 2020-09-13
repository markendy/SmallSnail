using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class AOutplace : MonoBehaviour
{
    [SerializeField] private GameObject EnterCube;
    [SerializeField] private GameObject TempCube;
    public void GoToTemp(){
        transform.position = TempCube.transform.position;
    }
    public void Respawn(){
        transform.position = EnterCube.transform.position;
    }
}
