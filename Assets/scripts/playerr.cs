
using UnityEngine;

public class playerr : MonoBehaviour
{
    private Vector3 direction;
    public float gravity = -9.8f;
    public float strength = 5f;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.space) || Input.GetMouseButtonDown(0))
        {
            direction = Vector3.up * strength;
        }
    }
}


}
