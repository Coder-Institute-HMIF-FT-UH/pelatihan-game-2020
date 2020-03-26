using System;
using UnityEngine;

public class RockScript : MonoBehaviour
{
    Animator animator;
    
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>(); // Get Animator Component
        // Panggil fungsi RockAnimation setelah 1 detik
        Invoke("RockAnimation", 1.0f);
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

    /// <summary>
    /// Rock Animation: Set boolean isPlay menjadi true agar animasinya bisa berjalan
    /// </summary>
    void RockAnimation()
    {
        animator.SetBool("isPlay", true);
    }
}
