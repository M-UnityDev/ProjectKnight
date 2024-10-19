using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
public class CutSceneDirector : MonoBehaviour
{
    [SerializeField] private GameObject txt1;
    [SerializeField] private string tx1;
    [SerializeField] private GameObject pg1;
    [SerializeField] private GameObject txt2;
    [SerializeField] private string tx2;
    [SerializeField] private GameObject pg2;
    [SerializeField] private GameObject txt3;
    [SerializeField] private string tx3;
    [SerializeField] private GameObject pg3;
    [SerializeField] private GameObject pg4;
    [SerializeField] private GameObject txt4;
    [SerializeField] private GameObject a;
    [SerializeField] private string tx4;
    [SerializeField] private GameObject pgbg;
    private bool isdn = false;
    private bool isdn1 = false;
    private bool isdn2 = false;
    private bool isst;
    public void Strt()
    {
        isst = true;
    }
    void Start()
    {
        StartCoroutine(nameof(CutScen));
    }
    private IEnumerator CutScen()
    {
        yield return new WaitUntil(() => isst);
        pgbg.GetComponent<Animator>().CrossFade("opn",0);
        yield return new WaitForSeconds(0.5f);
        pgbg.GetComponent<RectTransform>().localPosition = new Vector3(pgbg.GetComponent<RectTransform>().localPosition.x, pgbg.GetComponent<RectTransform>().localPosition.y, 2);
        txt1.GetComponent<TextWrither>().WritText(tx1);
        isdn = true;
        yield return new WaitUntil(() => Input.GetButtonDown("Submit")&& isdn);
        yield return new WaitForSeconds(0.1f);
        isdn = false;
        pg1.GetComponent<Animator>().CrossFade("Turn",0);
        txt2.GetComponent<TextWrither>().WritText(tx2);
        isdn1 = true;
        yield return new WaitUntil(() => Input.GetButtonDown("Submit")&& isdn1 && !isdn);
        yield return new WaitForSeconds(0.1f);
        isdn = false;
        pg2.GetComponent<Animator>().CrossFade("Turn",0);
        txt3.GetComponent<TextWrither>().WritText(tx3);
        isdn2 = true;
        yield return new WaitUntil(() => Input.GetButtonDown("Submit")&& isdn2);
        yield return new WaitForSeconds(0.1f);
        isdn2 = false;
        pg3.GetComponent<Animator>().CrossFade("Turn",0);
        txt4.GetComponent<TextWrither>().WritText(tx4);
        isdn2 = true;
        yield return new WaitUntil(() => Input.GetButtonDown("Submit")&& isdn2);
        yield return new WaitForSeconds(0.1f);
        isdn2 = false;
        pg4.GetComponent<RectTransform>().localPosition = new Vector3(pg4.GetComponent<RectTransform>().localPosition.x, pg4.GetComponent<RectTransform>().localPosition.y, -2);
        pg4.GetComponent<Animator>().CrossFade("Turn",0);
        yield return new WaitForSeconds(2);
        a.GetComponent<Animator>().CrossFade("Slid",0);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Game");
    }
}
