using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esfera : MonoBehaviour
{
    public float velocidade = 5f;

    public GameObject objetoEmContato;

    void Update()
    {
        // Movimento
        float movimentoX = Input.GetAxis("Horizontal");
        float movimentoZ = Input.GetAxis("Vertical");

        Vector3 movimento = new Vector3(movimentoX, 0f, movimentoZ);
        transform.Translate(movimento*velocidade*Time.deltaTime);

        // Se apertar E e estiver tocando em algo
        if (Input.GetKeyDown(KeyCode.E) &&objetoEmContato!=null)
        {
            Destroy(objetoEmContato);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        objetoEmContato = collision.gameObject;
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject==objetoEmContato)
        {
            objetoEmContato=null;
        }
    }
}