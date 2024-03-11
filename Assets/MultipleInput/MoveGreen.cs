using UnityEngine;
using UnityEngine.InputSystem;

public class MoveGreen : MonoBehaviour
{
    Vector3 move;

    public void OnMoveGreen(InputValue value)
    {
        Vector2 input = value.Get<Vector2>();
        move.x = input.x;
        move.z = input.y;
    }

    void Update()
    {
        transform.Translate(move * Time.deltaTime);
    }
}
