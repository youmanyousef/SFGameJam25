using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    // Initialize variables
    private Rigidbody2D rb;
    public float playerSpeed = 2.0f;
    private float gravityScale = 0.0f;
    private const float gravityValue = 0.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();   
    }

    // Get controls
    //void Update()
    //{
        //pass
    //}

    void FixedUpdate()
    {
        PlayerMovement(rb);    
    }    

    // Player Controls
    // calculate diagonal speed correctly
    float DiagSpeed(float speed)
    {
        return (float)System.Math.Sqrt(0.5 * System.Math.Pow(speed, 2));
    }
    void PlayerMovement(Rigidbody2D rb) 
    {   
        //{rb.linearVelocity = playerSpeed * Vector2.left; }   
        /*Debug.Log(
            "test A:"+Input.GetKey(KeyCode.A)+
            " W: "+Input.GetKey(KeyCode.W)+
            " (A && W): "+(Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.W))
        );*/
        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.W))
        {rb.linearVelocity = DiagSpeed(playerSpeed) * (Vector2.left + Vector2.up); }
        else if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.S))
        {rb.linearVelocity = DiagSpeed(playerSpeed) * (Vector2.left + Vector2.down); }
        else if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.W))
        {rb.linearVelocity = DiagSpeed(playerSpeed) * (Vector2.right + Vector2.up); }
        else if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.S)) 
        {rb.linearVelocity = DiagSpeed(playerSpeed) * (Vector2.right + Vector2.down); }
        else if (Input.GetKey(KeyCode.A)) {rb.linearVelocity = playerSpeed * Vector2.left; }    
        else if (Input.GetKey(KeyCode.D)) {rb.linearVelocity = playerSpeed * Vector2.right; }    
        else if (Input.GetKey(KeyCode.W)) {rb.linearVelocity = playerSpeed * Vector2.up; }    
        else if (Input.GetKey(KeyCode.S)) {rb.linearVelocity = playerSpeed * Vector2.down; }    
        else {rb.linearVelocity = 0 * Vector2.down;}
    }    
    
}
