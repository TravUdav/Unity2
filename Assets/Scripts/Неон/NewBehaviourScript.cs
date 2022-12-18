using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField]

    private GameObject neon;

    private bool neonIsEnabled;

    void Start() //активация
    {
        gameObject.GetComponent<Button>().onClick.AddListener(TurnOnAndOff);
        neonIsEnabled = true;
        neon.SetActive(neonIsEnabled);
    }

    private void TurnOnAndOff() //включение и выключение
    {
        neonIsEnabled ^= true;
        neon.SetActive(neonIsEnabled);
    }
}
