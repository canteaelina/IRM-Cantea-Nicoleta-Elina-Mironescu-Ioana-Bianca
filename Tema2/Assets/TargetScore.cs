using UnityEngine;
using TMPro;

public class TargetScore : MonoBehaviour
{
    [Header("Interfata UI")]
    public TextMeshProUGUI textScor;
    
    [Header("Efecte Optionale")]
    public ParticleSystem efectVizual;
    
    private int scorCurent = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Projectile"))
        {
            scorCurent += 10;
            
            if (textScor != null)
            {
                textScor.text = "Scor: " + scorCurent;
            }

            if (efectVizual != null)
            {
                efectVizual.Play();
            }
        }
    }
}