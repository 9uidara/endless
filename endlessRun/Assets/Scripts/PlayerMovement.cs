using System.Collections;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour {

    public float timera;
    public float speed = 5;
    public Rigidbody rb;
    public bool alive=true;
    float horizontalInput;
    public float horizontalMultiplier = 2;


  

    private void FixedUpdate ()
    {
        timera += Time.deltaTime;
        if (timera > 2)
        {
            Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
            Vector3 horizontalMove = transform.right * horizontalInput * speed * Time.fixedDeltaTime;
            rb.MovePosition(rb.position + forwardMove + horizontalMove);
        }
    }

    private void Update () {
        horizontalInput = Input.GetAxis("Horizontal");

       
        }
    public void Die()
    {
        alive = false;
        Invoke("Restart", 2);
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    
}

   

  