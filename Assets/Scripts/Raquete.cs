using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raquete : MonoBehaviour
{

    public Vector3 raquetepos;
    public float meuY, velocidade = 5f, limiteMax;
    public bool player1;
    public bool automatico = false;

    public Transform transformBola;

    void Start()
    {
        //pegando posi��o inicial da raquete e aplicando a posicao
        raquetepos.x = transform.position.x;
    }

    void Update()
    {
        raquetepos.y = meuY;
        //Alterando a posicao da raquete
        transform.position = raquetepos;

        float veldelta = velocidade * Time.deltaTime;

        if (!automatico)
        {

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
            else
            {
                if (Input.GetKey(KeyCode.UpArrow))
                {
                    meuY += veldelta;
                }

                if (Input.GetKey(KeyCode.DownArrow))
                {
                    meuY -= veldelta;
                }

                if (Input.GetKey(KeyCode.Return)) automatico = true;
            }

        }
        else {
            meuY = Mathf.Lerp(meuY, transformBola.position.y, 0.01f);
            if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.UpArrow)) automatico = false;
        }

        if (meuY > limiteMax)
        {
            meuY = limiteMax;
        }
        if (meuY < -limiteMax)
        {
            meuY = -limiteMax;
        }
    }
}
