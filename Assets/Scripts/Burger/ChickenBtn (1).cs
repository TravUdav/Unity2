using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenBtn : MonoBehaviour, IPressable
{
    public BurgerBuilder _Burger;
    private Renderer _renderer;
    private bool emis = true;
    private float time = 2f;

    private void Awake()
    {
        _renderer = GetComponent<Renderer>();
    }

    public void Press()
    {
        _Burger._burger.SetChicken();
        StartCoroutine(Timer(time));
    }

    IEnumerator Timer(float time)
    {
        _renderer.material.DisableKeyword("_EMISSION");
        yield return new WaitForSeconds(time);
        _renderer.material.EnableKeyword("_EMISSION");
    }
}
