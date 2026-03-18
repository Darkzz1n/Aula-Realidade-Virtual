using System.Collections;
using UnityEngine;
using TMPro; //texto
using UnityEngine.SceneManagement; //cena

public class TMPController : MonoBehaviour
{
    public TextMeshProUGUI textoTMP;
    public string nomeDaCena;

    void Start()
    {
        StartCoroutine(Sequencia());
    }

    IEnumerator Sequencia()
    {
        yield return new WaitForSeconds(5f);
        textoTMP.color=Color.black;

        yield return new WaitForSeconds(5f);
        textoTMP.color=Color.red;

        yield return new WaitForSeconds(5f);
        textoTMP.text="aula";

        yield return new WaitForSeconds(5f);
        textoTMP.text="bola";

        yield return new WaitForSeconds(5f);
        textoTMP.text="cola";

        // Contagem regressiva
        for (int i=10; i>=0; i--)
        {
            textoTMP.text=i.ToString();
            yield return new WaitForSeconds(1f);
        }

        // Troca de cena
        SceneManager.LoadScene("SampleScene");
    }
}