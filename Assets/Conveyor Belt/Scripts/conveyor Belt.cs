using UnityEngine;

public class conveyorBelt : MonoBehaviour
{


    [Header("Settings")]
    [SerializeField] float speed;


    Rigidbody conveyorRigidbody;



    private void Awake()
    {
        conveyorRigidbody = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 pos = transform.localPosition;


        conveyorRigidbody.position -= transform.forward * speed * Time.deltaTime;


        conveyorRigidbody.MovePosition(pos);
    }
}
