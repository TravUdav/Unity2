using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    public GameObject coin;
    public GameObject wall;
    [SerializeField] private float Health;
    [SerializeField]
    [Range(1f, 100f)]
    private float _damage = 10f;
    void Start()
    {
        
    }

    void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0)) //���� ���
        {
            Health = Health - _damage; //��������� �����
            if (Health <= 0)
            {
                Destroy(gameObject);

                for (int i = 0; i < 3; i++) //��������� �������
                {
                    Instantiate(coin, transform.position, transform.rotation);
                }
            }
        }
        
    }
}
