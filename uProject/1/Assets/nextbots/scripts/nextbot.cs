using UnityEngine;
using UnityEngine.AI;

public class nextbot : MonoBehaviour
{
    private NavMeshAgent agent;
    public GameObject player;
    public int damageCount;
    
    // ����������� ����������
    private bool isPlayerInContact = false;
    private float nextDamageTime = 0f;
    public float damageInterval = 0.1f; // �������� ����� ������ � ��������
    [SerializeField] private float speed;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void FixedUpdate()
    {
        agent.destination = player.transform.position;
        
        // ����������� ������ �������������� �����
        if (isPlayerInContact && Time.time >= nextDamageTime)
        {
            playerMananger.Damage(damageCount);
            nextDamageTime = Time.time + damageInterval;
        }
    }

    private void OnCollisionEnter(Collision Player)
    {
        // ���������: �������� ������� � �������
        isPlayerInContact = true;
        
        // ������������ ���� ��� ������������
       playerMananger.Damage(damageCount);
        
        // ������������� ����� ���������� �����
        nextDamageTime = Time.time + damageInterval;
    }

    // ����������� ����� ��� ��������� ������ �� ������������
    private void OnCollisionExit(Collision Player)
    {
        isPlayerInContact = false;
    }
}