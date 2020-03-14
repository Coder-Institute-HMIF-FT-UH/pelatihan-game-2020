using UnityEngine;

public class IntroductionScript : MonoBehaviour
{
    private float suhuTeh = 100f, suhuIdeal = 50f, suhuDingin = 20f;

    // Update is called once per frame
    void Update()
    {
        // Panggil method CekTemperatur
        CekTemperatur();
        // suhuTeh akan berkurang seiring waktu
        suhuTeh -= Time.deltaTime * 6;
    }
    /// <summary>
    /// CekTemperatur: Mengecek suhuTeh
    /// Jika suhuTeh > suhuIdeal artinya teh masih panas
    /// Jika suhuTeh < suhuDingin artinya teh sudah dingin
    /// Selain itu artinya teh siap diminum
    /// </summary>
    void CekTemperatur(){
        if(suhuTeh > suhuIdeal)
            Debug.Log("Teh masih panas");
        else if(suhuTeh < suhuDingin)
            Debug.Log("Teh sudah dingin");
        else
            Debug.Log("Teh siap diminum.");

    }
}
