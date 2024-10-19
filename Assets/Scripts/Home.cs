using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Home : MonoBehaviour
{
    [SerializeField] private Animator dr;
    [SerializeField] private GameObject outl;
    [SerializeField] private GameObject vc1;
    [SerializeField] private GameObject vc2;
    [SerializeField] private string HomeScn;
    private bool isn;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isn && Input.GetButtonDown("Submit"))
        {
            StartCoroutine(nameof(goHom));
        }
    }
    private void OnTriggerEnter(Collider coll)
    {
        if (coll.isTrigger && coll.CompareTag("Dial"))
        {
            dr.CrossFade("DrRot", 0.1f);
            outl.SetActive(true);
            vc1.SetActive(true);
            isn = true;
        }
    }
    private void OnTriggerExit(Collider coll)
    {
        if (coll.isTrigger && coll.CompareTag("Dial"))
        {
            dr.CrossFade("DrUnrot", 0.1f);
            outl.SetActive(false);
            vc1.SetActive(false);
            isn = false;
        }
    }
    private IEnumerator goHom()
    {
        vc2.SetActive(true);
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(HomeScn);
    }
}
