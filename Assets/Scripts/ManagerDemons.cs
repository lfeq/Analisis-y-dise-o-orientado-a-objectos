using TMPro;
using UnityEngine;

public class ManagerDemons : MonoBehaviour
{
    InterfaceDemon[] demons = new InterfaceDemon[10];
    public GameObject[] models;
    public TMP_Text nameText;
    public TMP_Text descriptionText;
    public TMP_Text legionNumText;
    private int currentDemon = 0;

    private void Start()
    {
        demons[0] = new InterfaceDemon("Rey Bael", "El primer Rey del Infierno",
            66, "Sur", "Sol", "Oro", "Fuego");
        demons[1] = new InterfaceDemon("Duque  Agares", "Puede  ayudar a  los  fugitivos  a  escapar  y  enseña expresiones inmorales, además de acabar con la dignidad de alguien.",
            31, "Sur", "Venus", "Cobre", "Tierra");
        demons[2] = new InterfaceDemon("Príncipe Vassago", "Puede conocer el pasado y el futuro y además posee la capacidad de encontrar objetos escondidos o perdidos.",
            26, "Oeste", "Jupiter", "Estaño", "Agua");
        demons[3] = new InterfaceDemon("Marqués Samigina", "Enseña ciencias liberales y da cuenta de las almas que murieron en pecado y de los que se ahogaron en el mar.",
            30, "Oeste", "Luna", "Plata", "Agua");
        demons[4] = new InterfaceDemon("Presidente Marbas", "Posee conocimientos sobre lo oculto y enseña artes mecá-nicas, cura  enfermedades y  puede  cambiar  a las personas de forma.",
            36, "Este", "Mercurio", "Mercurio", "Aire");
        demons[5] = new InterfaceDemon("Duque Valefor", "Una de sus misiones principales es la de tentar a robar a las personas.",
            10, "Norte", "Venus", "Cobre", "Tierra");
        demons[6] = new InterfaceDemon("Marqués Aamon", "Conoce hechos pasados y futuros y puede ayudar a recon-ciliar a enemigos aunque también todo lo contrario.",
            40, "Oeste", "Luna", "Plata", "Agua");
        demons[7] = new InterfaceDemon("Duque Barbatos", "Conoce pasado y futuro, reconcilia a amigos en conflicto y da la capacidad de entender las lenguas de los animales.",
            30, "Sur", "Venus", "Cobre", "Fuego");
        demons[8] = new InterfaceDemon("Rey Paimon", "Enseña todas las artes, las  filosofías,  las  ciencias  y las cosas secretas.",
            200, "Oeste", "Sol", "Oro", "Agua");
        demons[9] = new InterfaceDemon("Presidente Buer", "Aparece cuando el Sol está en Sagitario y puede enseñar Ciencias Naturales,  Lógica  y  Moral  Filosófica.",
            50, "Sur", "Mercurio", "Mercurio", "Fuego");

        SetInfo(currentDemon);
    }

    public void next()
    {
        currentDemon++;
        SetInfo(currentDemon);
    }

    public void previous()
    {
        currentDemon--;
        SetInfo(currentDemon);
    }

    private void SetInfo(int index)
    {
        nameText.text = demons[index].Name;
        descriptionText.text = demons[index].Description;
        legionNumText.text = demons[index].Legions.ToString();
        turnOffModels();
        models[index].SetActive(true);
    }

    private void turnOffModels()
    {
        foreach(GameObject model in models)
        {
            model.SetActive(false);
        }
    }
}
