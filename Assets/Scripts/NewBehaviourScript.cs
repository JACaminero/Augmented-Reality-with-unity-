using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    GameObject[] spheres;
    public bool changeOrientation;

    // Start is called before the first frame update
    void Start()
    {
        spheres = GameObject.FindGameObjectsWithTag("sphere");
    }

    // Update is called once per frame
    void Update()
    {
        foreach (var item in spheres)
        {
            if (changeOrientation)
            {
                item.transform.Rotate(0, 2, 0);
            }
            else
                item.transform.Rotate(0, -2, 0);
        }
    }

   
}
