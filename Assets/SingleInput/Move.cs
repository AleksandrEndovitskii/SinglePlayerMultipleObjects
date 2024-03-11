using UnityEngine;
using UnityEngine.InputSystem;

public class Move : MonoBehaviour
{
    Vector3 move;

    public void OnMove(Vector2 value)
    {
        move.x = value.x;
        move.z = value.y;
    }

    void Update()
    {
        transform.Translate(move * Time.deltaTime);
    }
}
