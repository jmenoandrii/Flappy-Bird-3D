using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Rigidbody))]
public class Player : MonoBehaviour
{
    private Rigidbody rigidbody;

    [SerializeField]
    private float jumpForce;

    public bool die = false;
    public UnityEvent StartEvent, DieEvent;
    public UnityEvent<int> GetCoinEvent;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    public void Jump()
    {
        if (!die)
        {
            rigidbody.AddForce(Vector3.up * jumpForce);
        }
    }
    public void StartGame()
    {
        rigidbody.isKinematic = false;
        StartEvent.Invoke();
    }

    private void Die()
    {
        die = true;
        DieEvent.Invoke();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Barrier"))
        {
            Die();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            GetCoinEvent.Invoke(1);
        }
        else if (other.gameObject.CompareTag("Barrier"))
        {
            Die();
        }
    }
}
