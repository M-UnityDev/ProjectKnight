using UnityEngine;
public class Anim : MonoBehaviour
{
    private Vector3 poscng;
    [SerializeField] private float ampl = 1f;
    [SerializeField] private float ofst = 3f;
    [SerializeField] private float spd = 1f;
    private float elptim;
    private void FixedUpdate()
    {
        transform.Rotate(0,30*Time.deltaTime,0);
        poscng.Set(transform.position.x,ampl * Mathf.Sin(spd*elptim)+ofst,transform.position.z);
        transform.position = poscng;
        elptim += Time.deltaTime;
    }
}
