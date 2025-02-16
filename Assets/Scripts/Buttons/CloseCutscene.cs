using UnityEngine;

public class CloseCutscene : MonoBehaviour
{
    public GameObject cutsceneImage;
    public GameObject strelicaDesno;
    public GameObject strelicaLijevo;
    public GameObject startButton;

    public void CloseImage()
    {
        if (cutsceneImage != null)
        {

            cutsceneImage.SetActive(false);
            strelicaDesno.SetActive(false);
            strelicaLijevo.SetActive(false);
            startButton.SetActive(false);

        }
        else
        {
            Debug.LogError("Cutscene Image reference is not set!");
        }
    }
}