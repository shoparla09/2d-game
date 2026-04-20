using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //laat het spel zien met loadscene(1); door middel van methode  public void PlayGame()
    public void PlayGame()
    {

        SceneManager.UnloadSceneAsync(0);
        SceneManager.LoadSceneAsync(1);
        
    }

    //gaat uit de spel als de exitknop inggedrukt wordt en wordt aangeroepen met de  public void ExitGame() methode.
    public void ExitGame()
    {
        Application.Quit();
    }
}
