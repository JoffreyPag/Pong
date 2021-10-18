using System.Collections;
using System.Collections.Generic;
using Unity;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bola : MonoBehaviour
{

    Rigidbody2D rb;
    public Vector2 mVelocidade;

    public float velocidade = 5f;
    public float limiteHorizontal = 12f;
    public AudioClip boing;
    public float delay = 2f;
    public bool jogoIniciado = false;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        delay = delay - Time.deltaTime;
        if (delay <= 0 && jogoIniciado == false) {
            jogoIniciado = true;
            mVelocidade.x = Direction() * velocidade;
            mVelocidade.y = Direction() * velocidade;
            rb = GetComponent<Rigidbody2D>();
            rb.velocity = mVelocidade;
        }

        if (Mathf.Abs(transform.position.x) >= limiteHorizontal) {
            SceneManager.LoadScene(0);
        }
    }

    int Direction() {
        int[] integers = new int[] { -1, 1 };
        return integers[Random.Range(0, integers.Length)];
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        AudioSource.PlayClipAtPoint(boing, transform.position, 1);
    }
}
