using UnityEngine;

public class EnemyFOV : MonoBehaviour
{

    [SerializeField] private FieldOfView fieldOfView;
    private Vector3 aimDir = new Vector3(1, 0, 0);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        fieldOfView.SetOrigin(transform.position);
        fieldOfView.SetAimDirection(GetAimDir());
    }

    private Vector3 GetAimDir()
    {
        return aimDir;
    }
}
