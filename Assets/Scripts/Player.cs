using UnityEngine;
using UnityEngine.Rendering;

public class Player : MonoBehaviour
{
    [Header("Settings")]
    [SerializeField] private GameObject mainCamera;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float moveAmount;

    void Awake()
    {
        if (mainCamera == null)
        {
            mainCamera = GameObject.FindWithTag("MainCamera").GetComponent<GameObject>();
        }
    }

    void LateUpdate()
    {
        mainCamera.transform.position = this.transform.position + new Vector3(0, 0, -10f);
    }

    void Update()
    {
        moveAmount = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;

        transform.Translate(moveAmount, 0, 0);
    }
}
