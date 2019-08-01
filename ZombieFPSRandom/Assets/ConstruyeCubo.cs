using UnityEngine;
using System.Collections;
public class ConstruyeCubo : MonoBehaviour
{

    int zombieS, aldeanoS;
    public int limite = 10;
    int mRan;
    int alRam, aldeLocal, edadAlde;
    string[] noM;
    string aldeanoNom;


    void Start()
    {
        zombieS = Random.Range(0, limite+1);
        aldeanoS = limite - zombieS;
        aldeanoS = Random.Range(0, aldeanoS+1);

        noM = new string[20] { "Brayan",
            "Omaira", "Carlos",
            "Jorge", "Omar",
            "David", "Mr Pickles",
            "Kim Jo Il", "Kim Il Sun",
            "Hittler", "Satan",
            "Javier", "José",
            "Blador", "Cesar",
            "Augusto", "Sara",
            "Salome", "Ana", "Jairo" };


        for (int i = 0; i < zombieS; i++) // Ciclo para crear zombies
        {

            mRan = Random.Range(0, 3);
            ZombieS Zom = new ZombieS (mRan);


        }

        for (int i = 0; i < aldeanoS; i++) // Ciclo para crear aldeanos
        {
            aldeLocal = Random.Range(0, 20);
            aldeanoNom = noM[aldeLocal];
            edadAlde = Random.Range(0, 100);
            Aldeano Ald = new Aldeano(aldeLocal, edadAlde);
               
        }
    }

    

    class ZombieS
    {
        int RamD;
        Color zColor;
        int nNom;
        string goName;
        string aColor;
        public ZombieS(int mRan)
        {
            RamD = mRan;
            GameObject go = GameObject.CreatePrimitive(PrimitiveType.Cube);
            Vector3 v = new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));
            go.transform.position = v;

            switch (RamD)
            {

                case 0:
                    zColor = Color.cyan;
                    aColor = "cyan ";
                    break;
                case 1:
                    zColor = Color.green;
                    aColor = "green ";
                    break;
                case 2:
                    zColor = Color.magenta;
                    aColor = "magenta ";
                    break;
            }
            go.GetComponent<Renderer>().material.color = zColor;
            go.name = "Zombie " + aColor;

            print(MensajeZombie(aColor));
        }
        string MensajeZombie (string aZom)
        {
            string zMensaje;
            zMensaje = "Soy un zombie de color " + aZom;
            return zMensaje;
        }
    }


    class Aldeano
    {
        int nNom;
        int goEdad;
        string goName;

        public Aldeano(int aldeLocal, int edadAlde)
        {
            nNom = aldeLocal;
            goEdad = edadAlde;

            

            GameObject go = GameObject.CreatePrimitive(PrimitiveType.Cube);


            Vector3 v = new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));
            go.transform.position = v;
            go.GetComponent<Renderer>().material.color = Color.yellow;
            print(DarMensaje(goName, goEdad));

           


            string DarMensaje(string goName, int goEdad)
            {
                string mensaje;
                string mensaje1 = "Hola Soy ";
                string mensaje2 = goName;
                string mensaje3 = " y tengo ";
                string mensaje4 = goEdad.ToString();
                string mensaje5 = " Años";

                mensaje = mensaje1 + mensaje2 + mensaje3 + mensaje4 + mensaje5;
                return mensaje;
            }



        }
         



    }
}