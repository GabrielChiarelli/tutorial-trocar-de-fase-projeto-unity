using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;                      // importa os comandos de carregamento de cena

public class TrocarFase : MonoBehaviour
{
    // variável onde colocamos o nome da fase/cena que queremos carregar
    public string nomeDaFase;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // verifica se a 'barra de espaço' foi apertada
        if(Input.GetKeyDown(KeyCode.Space))
        {
            // roda o método 'CarregarNovaFase()'
            CarregarNovaFase();
        }
    }

    private void CarregarNovaFase()
    {
        // pede para que a Unity carregue a fase presente na variável 'nomeDaFase'
        SceneManager.LoadScene(nomeDaFase);
    }
}
