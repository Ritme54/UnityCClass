using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneryManager : MonoBehaviour
{
    [SerializeField] Slider progress;
    [SerializeField] GameObject screen;
    [SerializeField] float displayProgress;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void Coroutine()
    {
        StartCoroutine(TransitionScene(1));
    }

    public void LoadScene(int sceneIndex)
    {
        StartCoroutine(TransitionScene(sceneIndex));
      
    }



    public IEnumerator TransitionScene(int index)
    {
        progress.value = 0;
        screen.SetActive(true);
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(index);

        asyncOperation.allowSceneActivation = false;

        while (asyncOperation.isDone == false)
        {
            progress.value += Time.deltaTime;
            //작업 진행 상태 표시 변수(읽기전용)
            if (asyncOperation.progress >= 0.9f)
            {
                progress.value = Mathf.Lerp(progress.value, 1.0f, Time.deltaTime);

                if (progress.value > 0.99f)
                {
                    asyncOperation.allowSceneActivation = true;
                    screen.SetActive(false);

                }

            }
            yield return null;

        }

        screen.SetActive(false);
    }



   

}