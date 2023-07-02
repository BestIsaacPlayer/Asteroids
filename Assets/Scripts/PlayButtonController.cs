using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayButtonController : MonoBehaviour
{
    [SerializeField] private float growFactor = 1.02f;
    [SerializeField] private float maxSize = 1.1f;
    [SerializeField] private float minSize = 0.9f;

    private bool _shouldGrow = true;

    [SerializeField] private Button button;
    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        if (_shouldGrow)
        {
            button.transform.localScale *= growFactor;
            if (button.transform.localScale.x > maxSize)
            {
                _shouldGrow = false;
            };
        }
        else
        {
            button.transform.localScale /= growFactor;
            if (button.transform.localScale.x < minSize)
            {
                _shouldGrow = true;
            };
        }
    }
    
    public void MoveToScene(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }

}
