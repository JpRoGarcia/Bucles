using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spheres : MonoBehaviour
{
    public bool checkbox = false; // Se Crea una Variable de Tipo Booleano y se le Asigna el valor de Falso.

    //Se crea una funcion para que se creen la esferas
    public void Crear()
    {
        int fila = Random.Range(3, 13);// Se Crea uan Variable de Tipo Entero y Se le Asigna Un Valor Random entre 3, 13.
        int columna = Random.Range(3, 13);// Se Crea uan Variable de Tipo Entero y Se le Asigna Un Valor Random entre 3, 13.

        //Se crean 2 for para hacer la crear la matriz.
        for (int f = 0; f < fila; f++)
        {
            GameObject temporal = null;// Se Crea un Objeto Con Valor Nulo.
            for (int c = 0; c < columna; c++)
            {
                GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);//Se crea un objeto y se le asigna las una esfera.
                sphere.transform.position = new Vector3(c * 2.0f, f * 2.0f, 0f); //se accede a la posicion de la esfera y se crea un vector para que vaya aumentando;

                int pinta = Random.Range(0, 7);// Se Crea uan Variable de Tipo Entero y Se le Asigna Un Valor Random entre 0, 7.

                switch (pinta)
                {
                    case 0:
                        sphere.GetComponent<Renderer>().material.color = Color.yellow;//Se le Asigna el Color al Objeto.
                        break;
                    case 1:
                        sphere.GetComponent<Renderer>().material.color = Color.green;//Se le Asigna el Color al Objeto.
                        break;
                    case 2:
                        sphere.GetComponent<Renderer>().material.color = Color.blue;//Se le Asigna el Color al Objeto.
                        break;
                    case 3:
                        sphere.GetComponent<Renderer>().material.color = Color.magenta;//Se le Asigna el Color al Objeto.
                        break;
                    case 4:
                        sphere.GetComponent<Renderer>().material.color = Color.red;//Se le Asigna el Color al Objeto.
                        break;
                    case 5:
                        sphere.GetComponent<Renderer>().material.color = Color.cyan;//Se le Asigna el Color al Objeto.
                        break;
                    case 6:
                        sphere.GetComponent<Renderer>().material.color = Color.white;//Se le Asigna el Color al Objeto.
                        break;
                }

                if (temporal != null)
                {
                    if (a.Comparar(temporal.GetComponent<Renderer>().material.color, sphere.GetComponent<Renderer>().material.color))//se compara la esfera anterior con la nueva.
                    {
                        sphere.GetComponent<Renderer>().material.color = Color.black;//Se e Asigna el Color al Objeto.
                        temporal.GetComponent<Renderer>().material.color = Color.black;//Se e Asigna el Color al Objeto.
                    }
                }
                temporal = sphere;//Se le asigna la esfera al temporal.
            }
        }
    }

    Verificar a = new Verificar();// Se Crea Una Instancia

    public class Verificar// Se crea una Clase Publica
    {
        public bool Comparar(Color a, Color b)//Se crea una funcion para revisar los colores de la esferas.
        {
            return a == b; //Se mira si estan igual los Colores
        }
    }

    void Update()
    {
        // Se crea un boleano para activar las esferas desde el inspector.
        if (checkbox == true)
        {
            Crear();
            checkbox = false;
        }
    }
}
