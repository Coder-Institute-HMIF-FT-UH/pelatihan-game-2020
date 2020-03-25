using System;
using UnityEngine;

public class RockScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// OnCollissionEnter: akan mendeteksi jika objek bersentuhan dengan objek lain
    /// </summary>
    /// <param name="other"></param>
    private void OnCollisionEnter(Collision other)
    {
        // Munculkan pesan console
        Debug.Log(gameObject.name + " collision dengan " + other.gameObject.name);
    }
}
