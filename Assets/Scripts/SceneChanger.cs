using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChanger : MonoBehaviour
{
    public string SceneName; 

    void Start()
    {
        GetComponent<Button>().onClick.AddListener(() => SceneManager.LoadScene(SceneName));
    }
}