using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Coletavel : MonoBehaviour
{
    //private int pontos = 5;
    //// Start is called before the first frame update
    //void Start()
    //{
    //    Debug.Log("o jogo começou! com " + pontos + " pontos.");
    //}

    //// Update is called once per frame
    //void Update()
    //{
    //   // Debug.Log("rodando!");
    //}

    public TMP_Text texto_pontos;
    public ParticleSystem efeito;
    int pontos = 0;

    private void OnTriggerEnter2D(Collider2D outro)
    {
        if (outro.CompareTag("Player")){
            pontos++;
            texto_pontos.text = "Pontos: " + pontos.ToString();
            outro.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
            Instantiate(efeito, transform.position, Quaternion.identity);
        }
    }
}
