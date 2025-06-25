using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Vida : MonoBehaviour
{
    public TMP_Text texto_vidas;
    public ParticleSystem efeito;
    private static int vida = 3;
    private bool foiColetado = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (foiColetado) return;
        if (vida == 0)
        {
            texto_vidas.text = "Game Over";
        }
        if (collision.CompareTag("Player"))
        {
            foiColetado = true;
            vida++;
            texto_vidas.text = "Vidas: " + vida.ToString();
            Instantiate(efeito, transform.position, Quaternion.identity);
            Destroy(gameObject);
            if (vida == 5) return;
        }
        
        

    }
}
