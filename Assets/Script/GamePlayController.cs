using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayController : MonoBehaviour
{
    [SerializeField] GameObject earCleaner;
    [SerializeField] GameObject earMassage;
    [SerializeField] GameObject Rain;
    [SerializeField] GameObject Catsound;
    [SerializeField] GameObject Firesound;



    [SerializeField] GameObject earCleanerButton;
    [SerializeField] GameObject earMassageButton;
    [SerializeField] GameObject RainButton;
    [SerializeField] GameObject CatsoundButton;
    [SerializeField] GameObject FiresoundButton;
    // Start is called before the first frame update
    void Start()
    {
        earMassage.SetActive(false);
        earCleaner.SetActive(false);
        Rain.SetActive(false);
        Catsound.SetActive(false);
        Firesound.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayEarCleaer()
    {
        earCleaner.SetActive(true);

        earMassageButton.SetActive(true);
        RainButton.SetActive(true);
        CatsoundButton.SetActive(true);
        FiresoundButton.SetActive(true);

       
        earCleanerButton.SetActive(false);

        earMassage.SetActive(false);
        Catsound.SetActive(false);
        Rain.SetActive(false);
        Firesound.SetActive(false);
    }
    public void PlayEarMassage()
    {
        earMassage.SetActive(true);

        earCleanerButton.SetActive(true);
        RainButton.SetActive(true);
        CatsoundButton.SetActive(true);
        FiresoundButton.SetActive(true);

        
        earMassageButton.SetActive(false);

        earCleaner.SetActive(false);
        Catsound.SetActive(false);
        Rain.SetActive(false);
        Firesound.SetActive(false);
    }
    public void PlayRain()
    {
        Rain.SetActive(true);

        earCleanerButton.SetActive(true);
        earMassageButton.SetActive(true);
        CatsoundButton.SetActive(true);
        FiresoundButton.SetActive(true);

        
        RainButton.SetActive(false);

        earCleaner.SetActive(false);
        Catsound.SetActive(false);
        earMassage.SetActive(false);
        Firesound.SetActive(false);
    }
    public void PlayCatsound()
    {
        Catsound.SetActive(true);

        earCleanerButton.SetActive(true);
        earMassageButton.SetActive(true);
        RainButton.SetActive(true);
        FiresoundButton.SetActive(true);

        
        CatsoundButton.SetActive(false);

        earCleaner.SetActive(false);
        Rain.SetActive(false);
        earMassage.SetActive(false);
        Firesound.SetActive(false);
    }
    public void PlayFiresound()
    {
        Firesound.SetActive(true);

        earCleanerButton.SetActive(true);
        earMassageButton.SetActive(true);
        RainButton.SetActive(true);
        CatsoundButton.SetActive(true);

        Catsound.SetActive(false);

        earCleaner.SetActive(false);
        Rain.SetActive(false);
        earMassage.SetActive(false);
        FiresoundButton.SetActive(false);

    }
}
