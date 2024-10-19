using UnityEngine;
using System.Collections;
using Unity.Cinemachine;
public class StartCutscene : MonoBehaviour
{
    [SerializeField] private Canvas canv;
    [SerializeField] private GameObject cam;
    private void Awake()
    {
        cam.GetComponent<Animator>().CrossFade("CamFad",0);
        GetComponent<Movement>().spd = 0;
        GetComponent<Movement>().jmspd = 0;
        canv.enabled = false;
        StartCoroutine(nameof(Cutst));
    }
    private IEnumerator Cutst()
    {
        yield return new WaitForSeconds(3);
        canv.enabled = true;
        GetComponent<Movement>().spd = 5;
        GetComponent<Movement>().jmspd = 8;
        GetComponent<StartCutscene>().enabled = false;
    }
}
