using UnityEngine;

public class ResetObject : MonoBehaviour
{
    Vector3 orginalPos;
    void Start()
    {
        orginalPos = gameObject.transform.position;
    }
    private void OnDisable()
    {
        transform.position = orginalPos;
    }
}
