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
    [SerializeField] private GameObject plr;
    [SerializeField] private GameObject blcscr;
    [SerializeField] private Vector3 hospos;
    private Vector3 vec;
    private float i;
    private bool isn;

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
        i=1;
        vc2.SetActive(true);
        while (plr.transform.localScale != Vector3.zero)
        {
            i -= 0.1f;
            if(i < 0.1f)
            {
                i = 0;
            }
            vec.Set(i,i,i);
            plr.transform.localScale = vec;
            yield return new WaitForSeconds(0.05f);
        }
        yield return new WaitForSeconds(1f);
        GameObject.Find("Knight").transform.position = hospos;
        vec.Set(1,1,1);
        plr.transform.localScale = vec;
        //SceneManager.LoadScene(HomeScn, LoadSceneMode.Additive);
        blcscr.SetActive(true);
        vc2.SetActive(false);
        yield return new WaitForSeconds(1.5f);
        blcscr.SetActive(false);
    }
}
