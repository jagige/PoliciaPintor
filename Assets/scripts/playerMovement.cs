using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float jumpForce;
    public float speed;
    public LayerMask groundLayer;
    private Rigidbody2D _rigidbody2D;
    public float _horizontalDirection;
    [SerializeField] private bool _isGrounded;
    private SpriteRenderer _spriteRenderer;
    public float groundCheckRadius;
    public Transform groundcheckPosition;
    public Animator _animator;
    //sound
    public AudioSource _audioSource;
    public AudioClip _jumpAudioClip;

    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        _horizontalDirection = Input.GetAxisRaw("Horizontal");
        _rigidbody2D.linearVelocityX = _horizontalDirection * speed;

        if (_horizontalDirection != 0)
        {
            if (_horizontalDirection == 1)
            {
                _spriteRenderer.flipX = false;
            }
            else
            {
                _spriteRenderer.flipX = true;
            }

        }

        if (Physics2D.OverlapCircle(groundcheckPosition.position, groundCheckRadius, groundLayer))
        {
            _isGrounded = true;
        }
        else
        {
            _isGrounded = false;
        }

        if ((Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow)) && _isGrounded)
        {
            _rigidbody2D.AddForceY(jumpForce, ForceMode2D.Impulse);
            _audioSource.clip = _jumpAudioClip;
            _audioSource.Play();
        }

        controlarAnimaciones();
    }

    private void OnDrawGizmos()//esto es para ver el circulo colicionador
    {
        Gizmos.DrawWireSphere(groundcheckPosition.position, groundCheckRadius);
    }

    private void controlarAnimaciones()
    {
        _animator.SetFloat("velocidadHorizontal", Mathf.Abs(_rigidbody2D.linearVelocityX));
        _animator.SetBool("enSuelo", _isGrounded);
        _animator.SetFloat("velocidadVertical", Mathf.Sign(_rigidbody2D.linearVelocityY));
    }

}
