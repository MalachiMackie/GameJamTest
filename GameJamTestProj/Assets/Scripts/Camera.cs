using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 offset = new Vector3(0, 6, -8);
        transform.position = transform.position + offset;
    }
}
