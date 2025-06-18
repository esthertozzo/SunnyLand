using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Personagem : MonoBehaviour
{
    public string nome = "remi";
    public int vidaInicial = 1;
    public float velocidadeMovimento = 2.5f;
    public bool isDead = false;
    private Rigidbody2D rb;
    public float novaGravidade = 0;

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Nome:\n" + nome + "Pontos:\n" + vidaInicial);
        //rb = GetComponent<Rigidbody2D>();
        //rb.gravityScale = novaGravidade;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
