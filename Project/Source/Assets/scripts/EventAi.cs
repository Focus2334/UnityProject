using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;


public class EventAi : MonoBehaviour //Скрипт врагов. Отвечает за анимации, поведение ИИ, характеристики.
{
    [SerializeField] private Animator _animation;
    [SerializeField] private GameObject _player;
    [SerializeField] private float _triggerDistance;
    NavMeshAgent agent;
    [SerializeField] bool idle = false;
    List<Transform> points = new List<Transform>();
    [SerializeField] GameObject pointsObject;
    [SerializeField] GameObject _bloodParticle;
    private int _pointsNumber;
    private int _currentPoint;
    public float timer = -1; //Таймер до уничтожения врага (по умолчанию -1 так как он еще не запущен)
    private float _attackDelay;

    public void destroy() //Метод уничтожения врага, запускает анимацию смерти и таймер до уничтожения
    {
        timer = 0;
        _animation.SetBool("Patroling", false);
        _animation.SetBool("Chase", false);
        _animation.SetBool("Attack", false);
        _animation.SetBool("Die", true);

    }


    private void Start()
    {
        agent = _animation.GetComponent<NavMeshAgent>();
        Transform pointsObjectTransform = pointsObject.transform;
        foreach (Transform t in pointsObjectTransform)
        {
            points.Add(t);
            _pointsNumber += 1;
        }
        agent.SetDestination(points[0].position);
    }
    void Update()
    {
        if (_attackDelay > 0)
        {
            _attackDelay -= Time.deltaTime;
        }
        if (timer > 0.8)
        {
            Destroy(gameObject);
        }
        if (timer >= 0)
        {
            timer += Time.deltaTime;
            return;
        }

        if (timer < 0)
        {
            if (Vector3.Distance(transform.position, _player.transform.position) > _triggerDistance && idle is false)
            {
                agent.SetDestination(points[_currentPoint].position);
                _animation.SetBool("Patroling", true);
                _animation.SetBool("Chase", false);
                _animation.SetBool("Attack", false);
            }
            else if (Vector3.Distance(transform.position, _player.transform.position) < 1.4)
            {
                _animation.SetBool("Patroling", false);
                _animation.SetBool("Chase", false);
                _animation.SetBool("Attack", true);
                if (_attackDelay <= 0)
                {
                    _player.GetComponent<HealthManager>().Damage(10);
                    _attackDelay = 1;
                    GameObject _bloodParticleOnScene = Instantiate(_bloodParticle, transform.position + transform.forward * 0.5f + transform.up, Quaternion.identity);
                    Destroy(_bloodParticleOnScene, 0.2f);
                }
                
                
            }
            else if (Vector3.Distance(transform.position, _player.transform.position) > 1.4 && Vector3.Distance(transform.position, _player.transform.position) < _triggerDistance)
            {
                _animation.SetBool("Patroling", false);
                _animation.SetBool("Chase", true);
                _animation.SetBool("Attack", false);
                agent.SetDestination(_player.transform.position);
            }
            else
            {
                _animation.SetBool("Patroling", false);
                _animation.SetBool("Chase", false);
                _animation.SetBool("Attack", false);
                agent.SetDestination(gameObject.transform.position);
            }
        }
            

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == points[_currentPoint].gameObject)
        {
            _currentPoint++;
            if (_currentPoint >= _pointsNumber)
            {
                _currentPoint = 0;
            }
        }
    }
}
