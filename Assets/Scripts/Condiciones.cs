using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Condiciones : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

       
            bool diaMercado = false;
            bool cogerCoche = true;
            if(!diaMercado && cogerCoche)
            {
                Debug.Log("Aparca en esa calle mangurrian");
            }
            else
            {
                Debug.Log("O bien busco otro sitio, o hoy no voy a trabajar");
            }


            bool esLunes = true;
            bool esMiercoles = false;
            
            if (esLunes || esMiercoles)
            {
                Debug.Log("Puedo ir a clase");
            }
            else
            {
                Debug.Log("Me quedo en mi casa");
            }

         
                if (esRojo)
            {
                Debug.Log("Es Rojo");
            }
                else
            { 
                Debug.Log("No es Rojo");
            }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
