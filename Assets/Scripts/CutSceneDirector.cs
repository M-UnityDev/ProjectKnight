using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using DG.Tweening;
public class CutSceneDirector : MonoBehaviour
{
    [Header("Book Cover")]
    [SerializeField] private Transform BookCover;
    [SerializeField] private TextWrither BookCoverText;
    [SerializeField] private string tx1;
    [Header("Page 1")]
    [SerializeField] private Transform Page1;
    [SerializeField] private TextWrither txt2;
    [SerializeField] private string tx2;
    [Header("Page2")]
    [SerializeField] private Transform Page2;
    [SerializeField] private TextWrither txt3;
    [SerializeField] private string tx3;
    [Header("Page3")]
    [SerializeField] private Transform Page3;
    [SerializeField] private TextWrither txt4;
    [SerializeField] private string tx4;
    [Header("Last Page")]
    [SerializeField] private Transform LastPage;
    [SerializeField] private RectTransform Book;
    private bool isdn = false;
    private bool isdn1 = false;
    private bool isdn2 = false;
    public void Strt() => StartCoroutine(nameof(CutScen));
    private void TurnPage(Transform Page) => Page.DORotate(new Vector3(0,180,0), 2f).SetEase(Ease.InOutCubic);
    private IEnumerator CutScen()
    {
        BookCover.DORotate(new Vector3(0,360,0), 2f).SetEase(Ease.InOutCubic);
        yield return new WaitForSeconds(1f);
        BookCover.localPosition = new Vector3(BookCover.localPosition.x, BookCover.localPosition.y, 5);
        BookCoverText.WritText(tx1);
        isdn = true;
        yield return new WaitUntil(() => Input.GetButtonDown("Submit")&& isdn);
        yield return new WaitForSeconds(0.1f);
        isdn = false;
        TurnPage(Page1);
        txt2.WritText(tx2);
        isdn1 = true;
        yield return new WaitUntil(() => Input.GetButtonDown("Submit")&& isdn1 && !isdn);
        yield return new WaitForSeconds(0.1f);
        isdn = false;
        Page1.localPosition = new Vector3(Page1.localPosition.x, Page1.localPosition.y, Page2.localPosition.z+0.8f);
        TurnPage(Page2);
        txt3.WritText(tx3);
        isdn2 = true;
        yield return new WaitUntil(() => Input.GetButtonDown("Submit")&& isdn2);
        yield return new WaitForSeconds(0.1f);
        isdn2 = false;
        Page2.localPosition = new Vector3(Page2.localPosition.x, Page2.localPosition.y,4);
        TurnPage(Page3);
        txt4.WritText(tx4);
        isdn2 = true;
        yield return new WaitUntil(() => Input.GetButtonDown("Submit")&& isdn2);
        yield return new WaitForSeconds(0.1f);
        isdn2 = false;
        LastPage.localPosition = new Vector3(LastPage.localPosition.x, LastPage.localPosition.y, 1);
        TurnPage(LastPage);
        yield return new WaitForSeconds(2);
        Book.DOAnchorPosY(2000, 1).SetEase(Ease.InOutCubic);
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("Game");
    }
}