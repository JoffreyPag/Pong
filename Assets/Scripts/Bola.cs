using System.Collections;
using System.Collections.Generic;
using Unity;
using UnityEngine;

public class Bola : MonoBehaviour
{

    Rigidbody2D rb;
    public Vector2 mVelocidade;

    public float velocidade = 5f;
    
    // Start is called before the first frame update
    void Start()
    {
        mVelocidade.x = Direction()*velocidade;
        mVelocidade.y = Direction()*velocidade;
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = mVelocidade;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int Direction() {
        int[] integers = new int[] { -1, 1 };
        return integers[Random.Range(0, integers.Length)];
    }
}
