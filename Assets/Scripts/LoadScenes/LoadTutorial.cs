using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class LoadTutorial : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] GameObject panel;

    public void OnPointerClick(PointerEventData eventData)
    {
        SceneManager.LoadScene("Main");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
