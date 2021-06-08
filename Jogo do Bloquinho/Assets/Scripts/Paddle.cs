using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float velocidadeDoPaddle;
    public float xMinimo;
    public float xMaximo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movimentoDoPaddle();
    }

    private void movimentoDoPaddle(){

        transform.position = new Vector2(Mathf.Clamp(transform.position.x, xMinimo, xMaximo), transform.position.y);

        // Verificando se houve movimentação do Paddle  
        // no eixo Horizontal para a direita do Computador

        if(Input.GetAxisRaw("Horizontal") > 0.01f){
            transform.Translate(Vector2.right * velocidadeDoPaddle * Time.deltaTime);
        }

        // Verificando se houve movimentação do Paddle  
        // no eixo Horizontal para a esquerda do Computador
        
        if(Input.GetAxisRaw("Horizontal") < -0.01f){
            transform.Translate(Vector2.left * velocidadeDoPaddle * Time.deltaTime);
        }
    }
}
