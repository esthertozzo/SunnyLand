using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Vida : MonoBehaviour
{

    int vidas = 3;
    private bool foiColetado = false;
    public TMP_Text texto_vidas;
    public ParticleSystem efeito;
    GameObject inimigo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // quando colidir c om o inimigo tirar uma vida

    void OnTriggerEnter2D(Collider2D inimigo)
    {
        if (foiColetado) return;
        if (inimigo.CompareTag("Player"))
        {
            foiColetado = true;
            vidas = vidas - 1;
            texto_vidas.text = "Vidas: " + vidas.ToString();
            Instantiate(efeito, transform.position, Quaternion.identity);
            Destroy(gameObject);

        }
        if(vidas == 0)
        {
            Debug.Log("Game Over");
        }
    }
}
