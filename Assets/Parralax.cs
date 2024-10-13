using UnityEngine;
public class Parralax : MonoBehaviour
{
    private float startPos;
    [SerializeField] private GameObject cam;
    [SerializeField] private float parallaxEffect;
    private float dist;
    private void Awake() => startPos = transform.position.x;
    private void Update() 
    {
        dist = cam.transform.position.x * parallaxEffect;
        transform.position.Set(startPos + dist, transform.position.y, transform.position.z);
    }
}
