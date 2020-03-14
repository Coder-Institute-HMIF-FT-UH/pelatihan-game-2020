using UnityEngine;

public class IntroductionScript : MonoBehaviour
{
    int jumlah = 3;
    bool isCounting = false;
    public int[] angkaRandom;

    private void Start(){
        // Looping for
        for(int i=0; i<jumlah; i++){
            Debug.Log("Looping For. Nilai: " + i);
        }

        // Looping while
        while(jumlah > 0){
            Debug.Log("Looping While. Nilai: " + jumlah);
            jumlah--; // Decrement jumlah
        }

        // Looping Do While
        do{
            Debug.Log("Looping DoWhile");
        } while(isCounting);

        // Looping foreach
        foreach(int angka in angkaRandom){
            Debug.Log("Looping foreach. Nilai: " + angka);
        }
    }
}
