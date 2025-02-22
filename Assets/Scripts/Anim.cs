using UnityEngine;
public class Anim : MonoBehaviour
{
    private Vector3 poscng;
    [SerializeField] private float ampl = 1f;
    [SerializeField] private float spd = 1f;
    [SerializeField] private bool isnrot;
    private float pos;
    private float elptim;
    private void Awake() => pos = transform.position.y;
    private void FixedUpdate()
    {
        if (!isnrot)
            transform.Rotate(0,30*Time.deltaTime,0);
        poscng.Set(transform.position.x,ampl * Mathf.Sin(spd*elptim)+pos,transform.position.z);
        transform.position = poscng;
        elptim += Time.deltaTime;
    }
}
