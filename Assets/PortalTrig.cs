using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PortalTrig : MonoBehaviour
{

    private void Start()
    {
        
    }

    void Update()
    {
        if (PlayerPrefs.GetInt("Cube", 0) >= 7)
        {

        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Dial") && PlayerPrefs.GetInt("Cube", 0) >= 7)
        {
            SceneManager.LoadScene("End");
        }
    }
}
