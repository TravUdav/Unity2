using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField]

    private GameObject neon;

    private bool neonIsEnabled;

    void Start() //���������
    {
        gameObject.GetComponent<Button>().onClick.AddListener(TurnOnAndOff);
        neonIsEnabled = true;
        neon.SetActive(neonIsEnabled);
    }

    private void TurnOnAndOff() //��������� � ����������
    {
        neonIsEnabled ^= true;
        neon.SetActive(neonIsEnabled);
    }
}
