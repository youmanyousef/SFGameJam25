using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitScript : MonoBehaviour
{
    //trigger script from template
    //scene management code snippets from docs.unity3d.com
    public LayerMask playerLayer;
    private AssetBundle myLoadedAssetBundle;
    public string level;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            SceneManager.LoadScene(level);
            Debug.Log("hit!");        
        }
    }
}
