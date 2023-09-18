using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotaoTransicao : MonoBehaviour
{
    public GameObject[] cenas;
    public int contador;


    void Start()
    {

    }

    public void proximaCena()
    {
        contador = contador + 1;
        cenas[contador].SetActive(false);
        cenas[contador].SetActive(true);

    }
}
