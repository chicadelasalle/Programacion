using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Extraordinaria1 : MonoBehaviour
{
    public InicioScript referenciaInicioScript;
    public int miVariable1 = 2;
    public int miVariable2 = 4;
    public float dinero = 75.5f;
    public bool fechaSalida = true;

    // Start is called before the first frame update
    void Start()
    {
        referencia.Operacion(2, 7);
        CompraJuego();
        Debug.Log("Mi mascota es un" + referenciaMascota.tipo + ",que se llama" + referenciaMascota.nombre + "y tiene" + referenciaMascota.edad + "de edad");
    }

    // Update is called once per frame
    void Update()
    {
        Calculadora();
    }






}
        public    void CompraJuego()

       {
            if(dinero > 60 && fechaSalida)
            {
               Debug.Log("Compralo Ya");
            }
       }

       public void Calculadora()
{
    if (Input.GetKeyDown(KeyCode.S))
    {
        Debug.Log(miVariable1 + miVariable2);
    }
    else if (Input.GetKeyDown(KeyCode.R))
    {
        Debug.Log(miVariable1 - miVariable2);
    }

    else if (Input.GetKeyDown(KeyCode.M))
    {
        Debug.Log(miVariable1 * miVariable2);
    }
    else if (Input.GetKeyDown(KeyCode.D))
    {
        Debug.Log(miVariable1 / miVariable2);
    }
}
    /* public void Calculadora()
{
        int resultado1 (2 + 1)
        int resultado2 (2 - 1)
        int resultado3 (2 * 1)
        int resultado4 (2 / 2)
}

    if (Input.GetKeyDown(KeyCode.S + resultado1 ));
{
    Debug.Log("resultado1");
}
else if (Input.GetKeyDown(KeyCode.R + resultado2));
{
    Debug.Log(resultados2)
}
     */


