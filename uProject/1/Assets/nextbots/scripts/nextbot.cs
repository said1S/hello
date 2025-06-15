using UnityEngine;
using UnityEngine.AI;

public class nextbot : MonoBehaviour
{
    private NavMeshAgent agent;
    public GameObject player;
    public int damageCount;
    
    // Добавленные переменные
    private bool isPlayerInContact = false;
    private float nextDamageTime = 0f;
    public float damageInterval = 0.1f; // Интервал между уроном в секундах
    [SerializeField] private float speed;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void FixedUpdate()
    {
        agent.destination = player.transform.position;
        
        // Добавленная логика периодического урона
        if (isPlayerInContact && Time.time >= nextDamageTime)
        {
            playerMananger.Damage(damageCount);
            nextDamageTime = Time.time + damageInterval;
        }
    }

    private void OnCollisionEnter(Collision Player)
    {
        // Добавлено: отмечаем контакт с игроком
        isPlayerInContact = true;
        
        // Оригинальный урон при столкновении
       playerMananger.Damage(damageCount);
        
        // Устанавливаем время следующего урона
        nextDamageTime = Time.time + damageInterval;
    }

    // Добавленный метод для обработки выхода из столкновения
    private void OnCollisionExit(Collision Player)
    {
        isPlayerInContact = false;
    }
}