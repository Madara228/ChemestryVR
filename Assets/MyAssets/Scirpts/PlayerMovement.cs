using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Transform camera;
    private float _toggleAngle = 30f;
    private bool _moveForward = false;
    private float speed = 3f;
    public AudioSource source;
    private CharacterController cc;


    void Start()
    {
        cc = GetComponent<CharacterController>();
        source = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (camera.eulerAngles.x > _toggleAngle && camera.eulerAngles.x < 90f)
        {
            _moveForward = true;
            Debug.Log(camera.eulerAngles.x);
        }
        else
        {
            
            _moveForward = false;
            Debug.Log(camera.eulerAngles.x);
        }

        if (_moveForward)
        {
            Vector3 forward = camera.TransformDirection(Vector3.forward);
            cc.SimpleMove(forward * speed);
            Debug.Log(camera.eulerAngles.x);
        }
    }
}
