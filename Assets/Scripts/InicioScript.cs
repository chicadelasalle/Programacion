using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InicioScript : MonoBehaviour
{
    public int numeros = 5;
    private float dinero = 5.5f;
    public float pi = 3.14f;
    private string nombre = "alicia";
    public string colegio = "biblioteca";
    public int quince = 15;
    public string frase;
    public float decimal = 3.5f;
    public string perrete = "Stewe";
    public string fecha = "TrecedeFebrero";
    public char inicial = 'A';
    public bool red = false;

    // Start is called before the first frame update+
    void Start()
    {
        RestarNumeros();
        Estudio(biblioteca);
        Multplicar(5, 3);
        //Primera manera con parametros
        Debug.Log(Operacion(3,2,5));
        /*Segunda manera y con parametros
        int resultadoOperacion = Operacion(3, 2, 5);
        Debug.Log(resultadoOperacion);

        Debug.Log(Division(15 / 3));
        */
       


    }

    // Update is called once per frame
    void Update()
    {

      

       
    }
    public void resta()
    {
        Debug.Log(numero - decimal);
    }

    public void Estudio(string nombreSitio)
    {
        Debug.Log("El sitio donde estudio es" + nombreSitio);
    }

    public void Multiplica(int primerNumero, int segundoNumero)

    {
        Debug.Log(primerNumero * segundoNumero);
    }

    public int Operacion(int numero1, int numero2, int numero3)
    {
        int resultado = numero1 * numero2 -numero3;
        return resultado;
    }

    /*Sin parametros
  public int Operacion()
    {
    int resultado= 2 * 5 - 3;
    return resultado;
    }
    */

    public int Division(int miPrimerNumero, int miSegundoNumero)
    {
        int resultado = miPrimerNumero / miSegundoNumero;
        return resultado;
    }
}
