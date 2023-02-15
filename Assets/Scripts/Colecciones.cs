  using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colecciones : MonoBehaviour
{

    public string[] nombres = new string[] { "Alfonso", "Maria", "Enrique", "Carla", "Gabriel" };
    private string[] nombresOrdenados = new string[] { "Alfonso", "Carla", "Enrique", "Gabriel", "Maria" };
    public float[] acciones = new float[] { 2.5f, 2.4f, 2.55f, 3.05f, 2.70f, 3.00f };
    public char[] letras = new char[] { 'C', 'A', 'M', 'P', 'N' };
    public string[] oficios = new string[10];
    public bool[] asistencia = new bool[] { true, false, false, true, true };
    public List<string> seriesFavoritas = new List<string> ();




   // Start is called before the first frame update
   void Start()
    {
        int pot = 1;

        if (pos >= 1 && pos < nombresOrdenados.Length) ;
        {
            Debug.Log("El segundo de la lista es:" + nombresOrdenados[pos]);
        }

        Debug.Log("El tamaño del array de valores es : " + acciones.Count);

        seriesFavoritas.Add("Juego de Tronos");
        {
            Debug.Log(seriesFavoritas[0]);
        }

        seriesFavoritas.Add("Aqui no hay quien viva");
        {
            Debug.Log(seriesFavoritas[1]);
        }

        seriesFavoritas.Add("The walking dead");
        {
            Debug.Log(seriesFavoritas[2]);
        }

        seriesFavoritas.Add("Prision Break");
        {
            Debug.Log(seriesFavoritas[3]);
        }

        seriesFavoritas.Add("Orange is the new black");
        {
            Debug.Log(seriesFavoritas[4]);
        }

        seriesFavoritas.Remove("The walking dead");
        seriesFavoritas.Insert(2, "La casa de papel");
        Debug.Log("Mis series favoritas son:" + seriesFavoritas.Count);
    }


    // Update is called once per frame
    void Update()
    {

    }

}