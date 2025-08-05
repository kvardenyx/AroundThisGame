using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    public GameObject player;
    [SerializeField] private float playerSpeed = 150f;
    
    private void Start()
    {
        Movment();
    }

    void Update()
    {
        Movment();

        if (Input.GetMouseButtonDown(0))
        {
            playerSpeed = -playerSpeed;
        }
    }

    void Movment()
    {
        player.transform.Rotate(0f, 0f, playerSpeed * Time.deltaTime);
    }
}
