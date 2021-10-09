using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raquete : MonoBehaviour
{

    public Vector3 raquetepos;
    public float meuY, velocidade = 5f, limiteMax, limiteMin;

    void Start()
    {
        //pegando posição inicial da raquete e aplicando a posicao
        raquetepos.x = transform.position.x;
    }

    void Update()
    {
        raquetepos.y = meuY;
        //Alterando a posicao da raquete
        transform.position = raquetepos;
    
        if (Input.GetKey(KeyCode.UpArrow) && meuY < limiteMax)
        {
            meuY += (velocidade * Time.deltaTime);
        }


        if (Input.GetKey(KeyCode.DownArrow) && meuY > limiteMin)
        {
            meuY -= (velocidade * Time.deltaTime);
        }
        
        
    }
}
