using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody _playerRigidBody;

    public int MoveForce;

    // Start is called before the first frame update
    void Start()
    {
        _playerRigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            _playerRigidBody.AddForce(new Vector3(0, 0, 1) * MoveForce);
        }

        if (Input.GetKey(KeyCode.A))
        {
            _playerRigidBody.AddForce(new Vector3(-1, 0, 0) * MoveForce);
        }

        if (Input.GetKey(KeyCode.S))
        {
            _playerRigidBody.AddForce(new Vector3(0, 0, -1) * MoveForce);
        }

        if (Input.GetKey(KeyCode.D))
        {
            _playerRigidBody.AddForce(new Vector3(1, 0, 0) * MoveForce);
        }
    }
}
