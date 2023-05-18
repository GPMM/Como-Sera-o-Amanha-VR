using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfigMenu : MonoBehaviour
{
    public GameObject Player;
    public GameObject Sal;
    public GameObject Cozi;
    public int i = 1;
    
    public void Cozinha()
    {
       this.transform.position = Cozi.transform.position;
    }

    public void Sala()
    {
      this.transform.position = Sal.transform.position;
    }
}
