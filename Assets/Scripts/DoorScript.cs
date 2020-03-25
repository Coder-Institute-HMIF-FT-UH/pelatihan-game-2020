using System;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    /// <summary>
    /// OnTriggerEnter: mendeteksi jika ada objek lain masuk dalam area collider
    /// Dieksekusi hanya sekali
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name + " masuk ke dalam " + gameObject.name);
    }

    /// <summary>
    /// OnTriggerStay: medeteksi jika ada objek yang masih berada dalam area collider
    /// Dieksekusi setiap frame
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerStay(Collider other)
    {
        Debug.Log(other.name + " masih berada di " + gameObject.name);
    }

    /// <summary>
    /// OnTriggerExit: mendeteksi jika ada objek yang sudah keluar dari area collider
    /// Dieksekusi hanya sekali
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerExit(Collider other)
    {
        Debug.Log(other.name + " sudah keluar dari " + gameObject.name);
    }
}
