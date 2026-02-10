using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public abstract class Spell : MonoBehaviour
{
    private void ActivateSpell()
    {
        Debug.Log("Spell Activated");
    }
}

public class FireSpell : Spell
{
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {

    }

    private void ActivateSpell()
    {
        Debug.Log("Fire Spell Activated");
    }

    
}