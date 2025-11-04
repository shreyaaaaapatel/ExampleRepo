using UnityEngine;

public class Player : MonoBehaviour
{
    //scope access modifier private or public

    private float playerSpeed;
    private float horizontalInput;
    private float verticalInput;

    private float horizontalScreenLimit = 5f;
    private float verticalScreenLimit = 2.5f;
    public GameObject bulletPrefab;


    void Start()
    {
        playerSpeed = 6.0f;
    }

    // Update is called once per frame
    void Update()
    {
        //movement
        //shooting
        Movement();
        Shooting();
    }
    void Movement()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        //move the player
        transform.Translate(new Vector3(horizontalInput, verticalInput, 0) * Time.deltaTime * playerSpeed);
        //limit the player movement on screen
        if (transform.position.x > horizontalScreenLimit || transform.position.x < -horizontalScreenLimit)
        {
            transform.position = new Vector3(transform.position.x * -1, transform.position.y, 0);
        }
        if (transform.position.y > verticalScreenLimit || transform.position.y < -verticalScreenLimit)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y * -1, 0);
        }
    }
    //shooting
    void Shooting()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Pew Pew" + horizontalInput);
            //spawn bullet
            Instantiate(bulletPrefab, transform.position + new Vector3(0, 1, 0), Quaternion.identity);
        }
    }
}
