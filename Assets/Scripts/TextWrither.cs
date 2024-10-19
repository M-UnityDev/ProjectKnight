using UnityEngine;
using System.Collections;
using TMPro;

public class TextWrither : MonoBehaviour
{
    [SerializeField] private string s;
    [SerializeField] private TMP_Text tx;
    public bool WritText(string text)
    {
        s = text;
        StartCoroutine(nameof(WriteText));
        return true;
    }
    private IEnumerator WriteText()
    {
        tx.text = null;
        tx.text += "<color=#ff0000><size=80>";
        foreach(char c in s)
        {
            yield return new WaitForSeconds(0.05f);
            //tx.text = tx.text.Replace("<size=25>","<size=50>");
            tx.text = tx.text.Replace("<color=#00000032>","<color=#0000007D>");
            yield return new WaitForSeconds(0.05f);
            //tx.text = tx.text.Replace("<size=50>","<size=75>");
            tx.text = tx.text.Replace("<color=#0000007D>","<color=#000000AF>");
            yield return new WaitForSeconds(0.05f);
            //tx.text = tx.text.Replace("<size=75>","<size=100>");
            tx.text = tx.text.Replace("<color=#000000AF>","<color=#000000FF>");
            if(tx.text != "<color=#ff0000><size=80>")
                tx.text += "<color=#0000007D>"+c;
            else
                tx.text += c+"<color=#000000>";
        }
        yield return new WaitForSeconds(0.1f);
        //tx.text = tx.text.Replace("<size=25>","<size=50>");
        tx.text = tx.text.Replace("<color=#00000032>","<color=#0000007D>");
        yield return new WaitForSeconds(0.1f);
        //tx.text = tx.text.Replace("<size=50>","<size=75>");
        tx.text = tx.text.Replace("<color=#0000007D>","<color=#000000AF>");
        yield return new WaitForSeconds(0.1f);
        //tx.text = tx.text.Replace("<size=75>","<size=100>");
        tx.text = tx.text.Replace("<color=#000000AF>","<color=#000000FF>");
    }
}
