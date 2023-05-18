using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teste : MonoBehaviour
{

    public GameObject Sala;
    public GameObject Cozi;
    public int i = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Teleporte()
    {
        if (i > 0)
        {
            this.transform.position = Sala.transform.position;
        }
        else
        {
            this.transform.position = Cozi.transform.position;
        }
        i *= -1;
    }
}
