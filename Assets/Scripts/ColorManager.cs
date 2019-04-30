using System.Collections;
using UnityEngine;
using UnityEngine.UI;


public class ColorManager : MonoBehaviour
{

    public Material piste;
    public Material obstacle;
    public GameObject lumiere;

    public Image bg;

    //public PostProcessVolume volume;
    //Bloom bloomLayer = null;
    public MaterialUpdater[] presets;





    private void Awake()
    {
        //DontDestroyOnLoad(gameObject);

        //PlayerPrefs.SetInt("index ecran", i);
        

        ApplyPreset();
    }



    public void ApplyPreset()
    {
        //Calculer Preset aléatoire
        int i = Random.Range(0, presets.Length);
        //Application du preset
        bg.sprite = presets[i].fond; //image de fond

        piste.color = presets[i].couleurPiste; //couleur du matériau de la piste
        obstacle.color = presets[i].couleurObstacle; //couleur du matériau de l'obstacle

        Light light = lumiere.GetComponent<Light>(); //Référence à la lumière

        light.intensity = presets[i].intensiteLumiere; //intensité de la lumière
        light.color = presets[i].couleurDuSoleil; //couleur de la lumière

    }
}
