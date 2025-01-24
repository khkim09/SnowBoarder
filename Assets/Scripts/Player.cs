using UnityEngine;
using UnityEngine.Rendering;

public class Player : MonoBehaviour
{
    [Header("Settings")]
    [SerializeField] private float moveSpeed;
    [SerializeField] private float moveAmount;

    void Update()
    {
        moveAmount = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;

        transform.Translate(moveAmount, 0, 0);
    }
}
