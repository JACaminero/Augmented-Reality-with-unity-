using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuPrinci : MonoBehaviour
{
    public GameObject btn1, btn2;

    // Start is called before the first frame update
    void Start()
    {
        btn1.GetComponent<Button>().onClick.AddListener(() => SceneManager.LoadScene("Primer"));
        btn2.GetComponent<Button>().onClick.AddListener(() => SceneManager.LoadScene("Segundo"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
