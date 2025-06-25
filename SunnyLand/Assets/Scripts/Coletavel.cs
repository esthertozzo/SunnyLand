using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;

public class Coletavel : MonoBehaviour
{
    void Start()
    {

    }

    //// Update is called once per frame
    void Update()
    {
        Debug.Log("rodando!");
    }

    public TMP_Text texto_pontos;
    public ParticleSystem efeito;
    private static int pontos = 0;
    float velocidade = 5f;
    private bool foiColetado = false;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (foiColetado) return;
        if (collision.CompareTag("Player"))
        {
            foiColetado = true;
            pontos++;
            texto_pontos.text = "Pontos: " + pontos.ToString();
            Instantiate(efeito, transform.position, Quaternion.identity);
        }

        Destroy(gameObject);

        
    }




}
