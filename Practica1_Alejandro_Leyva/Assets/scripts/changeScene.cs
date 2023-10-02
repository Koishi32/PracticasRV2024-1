using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class changeScene : MonoBehaviour
{
    public int nextScene_Index;
    public int previousScene_Index;
    // Start is called before the first frame update
    public void nextSceneChange()
    {
        SceneManager.LoadSceneAsync(nextScene_Index);
    }
    public void previousSceneChange() {
        SceneManager.LoadSceneAsync(previousScene_Index);
    }
}
