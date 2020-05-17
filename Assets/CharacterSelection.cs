using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelection : MonoBehaviour
{

    public Move summer;
    public Move winter;

    public Move spring;
    public Move autumn;

    public SunAction summerAction;
    public CloudAction winterAction;

    public ParticleSystem[] particalSystems;

    public FlowerAction springAction;
    public MushroomAction autumnAction;

    public GameObject[] buttons;

    // Start is called before the first frame update
    void Start()
    {
        summer.enabled = false;
        winter.enabled = false;
        spring.enabled = false;
        autumn.enabled = false;
        summerAction.enabled =false;
        winterAction.enabled = false;
        springAction.enabled = false;
        autumnAction.enabled = false;

    }

    void CloseButtons() {
        foreach (GameObject o in buttons){
                o.active = false;
            }
    }


    public void Restart() {
        summer.enabled = false;
        winter.enabled = false;
        spring.enabled = false;
        autumn.enabled = false;
        summerAction.enabled =false;
        winterAction.enabled = false;
        springAction.enabled = false;
        autumnAction.enabled = false;
       foreach (GameObject o in buttons){
                o.active = true;
            }
             foreach (ParticleSystem o in particalSystems){
                o.Stop();
            }
    }

    public void ChooseSummer() {
        summer.enabled = true;
        summerAction.enabled= true;
        CloseButtons();
    }

     public void ChooseWinter() {
        winter.enabled = true;
        winterAction.enabled= true;
        CloseButtons();
    }

    public void ChooseSpring() {
        spring.enabled = true;
        springAction.enabled= true;
        CloseButtons();
    }

    public void ChooseAutumn() {
        autumn.enabled = true;
        autumnAction.enabled= true;
        CloseButtons();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
