using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRB;
    public ParticleSystem dirtParticle;
    private AudioSource playerAudio;
    private Animator playerAnim;
    public float jumpForce = 10;
    public AudioClip jumpSound;
    public AudioClip crashSound;
    public bool doubleSpeed = false;
    public float gravityModifier;
    private int doubleJumped=0;
    public bool isOnGround = true;
    public bool gameOver;
    public ParticleSystem explosionParticle;
    void Start()
    {
        playerAudio = GetComponent<AudioSource>();
        playerRB = GetComponent<Rigidbody>();
        playerAnim=GetComponent<Animator>();
        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        DoubleJump();
        Dash();
    }
    void Dash()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            doubleSpeed = true;
            playerAnim.SetFloat("Speed_Multiplier", 2.0f);
        }
        else if (doubleSpeed)
        {
            doubleSpeed = false;
            playerAnim.SetFloat("Speed_Multiplier", 2.0f);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
            dirtParticle.Play();
            doubleJumped = 0;
        }
        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Game Over");
            gameOver = true;
            playerAnim.SetBool("Death_b", true);
            playerAnim.SetInteger("DeathType_int", 1);
            explosionParticle.Play();
            dirtParticle.Stop();
            playerAudio.PlayOneShot(crashSound, 1.0f);
            doubleJumped = 0;
        }
    }
    void DoubleJump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && doubleJumped<2&& !gameOver)
        {
            doubleJumped++;
            playerRB.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
            playerAnim.SetTrigger("Jump_trig");
            dirtParticle.Stop();
            playerAudio.PlayOneShot(jumpSound, 1.0f);
        }
    }
}
