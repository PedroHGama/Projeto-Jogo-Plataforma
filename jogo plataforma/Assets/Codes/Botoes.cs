using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Botoes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IniciarJogo()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void sairJogo()
    {
        Application.Quit();
    }

    public void avancar()
    {
            SceneManager.LoadScene("FIM");
        
    }
}
