using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raquete : MonoBehaviour
{

    public Vector3 raquetepos;
    public float meuY, velocidade = 5f, limiteMax;
    public bool player1;

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

        float veldelta = velocidade * Time.deltaTime;

        if (player1)
        {
            if (Input.GetKey(KeyCode.W))
            {
                meuY += veldelta;
            }


            if (Input.GetKey(KeyCode.S))
            {
                meuY -= veldelta;
            }
        }
        else {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                meuY += veldelta;
            }


            if (Input.GetKey(KeyCode.DownArrow))
            {
                meuY -= veldelta;
            }
        }

        if (meuY > limiteMax) {
            meuY = limiteMax;
        }
        if(meuY < -limiteMax)
        {
            meuY = -limiteMax;
        }
        
    }
}
