using UnityEngine;

public class CameraLook : MonoBehaviour
{
    public float sensibilidade = 200f;

    float rotacaoX = 0f;
    float rotacaoY = 120f;

    public Transform playerBody;
    public float rotacaoInicialY = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;

        rotacaoY = rotacaoInicialY;
        playerBody.localRotation = Quaternion.Euler(0f, rotacaoY, 0f);
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensibilidade * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * sensibilidade * Time.deltaTime;

        // vertical (cima/baixo)
        rotacaoX -= mouseY;
        rotacaoX = Mathf.Clamp(rotacaoX, -30f, 30f);

        // horizontal (esquerda/direita)
        rotacaoY += mouseX;
        rotacaoY = Mathf.Clamp(rotacaoY, 60f, 120f);

        transform.localRotation = Quaternion.Euler(rotacaoX, 0f, 0f);
        playerBody.localRotation = Quaternion.Euler(0f, rotacaoY, 0f);
    }
}