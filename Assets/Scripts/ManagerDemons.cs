﻿using UnityEngine;

public class ManagerDemons : MonoBehaviour
{
    Demonios reyBael;
    Demonios duqueAgares;
    Demonios principeVassago;
    Demonios marquesSamigina;
    Demonios presidenteMarbas;
    Demonios duqueValefor;
    Demonios marquesAmon;
    Demonios duqueBarbatos;
    Demonios reyPaimon;
    Demonios presidenteBuer;

    private void Start()
    {
        reyBael = new Demonios("Rey Bael", "El primer Rey del Infierno",
            66, "Sur", "Sol", "Oro", "Fuego");
        duqueAgares = new Demonios("Duque  Agares", "puede  ayudar a  los  fugitivos  a  escapar  y  enseña expresiones inmorales, además de acabar con la dignidad de alguien.",
            31, "Sur", "Venus", "Cobre", "Tierra");
        principeVassago = new Demonios("Príncipe Vassago", "Puede conocer el pasado y el futuro y además posee la capacidad de encontrar objetos escondidos o perdidos.",
            26, "Oeste", "Jupiter", "Estaño", "Agua");
        marquesSamigina = new Demonios("Marqués Samigina", "Enseña ciencias liberales y da cuenta de las almas que murieron en pecado y de los que se ahogaron en el mar.",
            30, "Oeste", "Luna", "Plata", "Agua");
        presidenteMarbas = new Demonios("Presidente Marbas", "Posee conocimientos sobre lo oculto y enseña artes mecá-nicas, cura  enfermedades y  puede  cambiar  a las personas de forma.",
            36, "Este", "Mercurio", "Mercurio", "Aire");
        duqueValefor = new Demonios("Duque Valefor", "Una de sus misiones principales es la de tentar a robar a las personas.",
            10, "Norte", "Venus", "Cobre", "Tierra");
        marquesAmon = new Demonios("Marqués Aamon", "Conoce hechos pasados y futuros y puede ayudar a recon-ciliar a enemigos aunque también todo lo contrario.",
            40, "Oeste", "Luna", "Plata", "Agua");
        duqueBarbatos = new Demonios("Duque Barbatos", "Conoce pasado y futuro, reconcilia a amigos en conflicto y da la capacidad de entender las lenguas de los animales.",
            30, "Sur", "Venus", "Cobre", "Fuego");
        reyPaimon = new Demonios("Rey Paimon", "Enseña todas las artes, las  filosofías,  las  ciencias  y las cosas secretas.",
            200, "Oeste", "Sol", "Oro", "Agua");
        presidenteBuer = new Demonios("Presidente Buer", "Aparece cuando el Sol está en Sagitario y puede enseñar Ciencias Naturales,  Lógica  y  Moral  Filosófica.",
            50, "Sur", "Mercurio", "Mercurio", "Fuego");

        print(reyBael.Name);
        print(duqueAgares.Name);
        print(principeVassago.Name);
        print(marquesSamigina.Name);
        print(presidenteMarbas.Name);
        print(duqueValefor.Name);
        print(marquesAmon.Name);
        print(duqueBarbatos.Name);
        print(reyPaimon.Name);
        print(presidenteBuer.Name);
    }
}