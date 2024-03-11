using UnityEngine;
using UnityEngine.InputSystem;

public class MoveRed : MonoBehaviour
{
    Vector3 move;

    public void OnMoveRed(InputValue value)
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
