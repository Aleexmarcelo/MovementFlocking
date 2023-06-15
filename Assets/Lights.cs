using UnityEngine;
using UnityEngine.UI;

public class Lights : MonoBehaviour
{
    public GameObject diaObjeto;
    public GameObject noiteObjeto;
    public Button botaoDia;
    public Button botaoNoite;
    public Camera cameraDia;
    public Camera cameraNoite;

    private void Start()
    {
        botaoDia.onClick.AddListener(AtivarModoDia);
        botaoNoite.onClick.AddListener(AtivarModoNoite);
    }

    public void AtivarModoDia()
    {
        diaObjeto.SetActive(true);
        noiteObjeto.SetActive(false);
        cameraDia.gameObject.SetActive(true);
        cameraNoite.gameObject.SetActive(false);
    }

    public void AtivarModoNoite()
    {
        diaObjeto.SetActive(false);
        noiteObjeto.SetActive(true);
        cameraDia.gameObject.SetActive(false);
        cameraNoite.gameObject.SetActive(true);
    }
}
