using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelection : MonoBehaviour {

    public GameObject summer;
    public GameObject winter;

    public GameObject spring;
    public GameObject autumn;

    GameObject[] seasons;

    public ParticleSystem[] particalSystems;

    public GameObject[] buttons;

    // Start is called before the first frame update
    void Start () {
        seasons = new GameObject[] { summer, winter, spring, autumn };
        DisableControls ();
    }

    void CloseButtons () {
        foreach (GameObject o in buttons) {
            o.active = false;
        }
    }

    void DisableControls () {
        foreach (var season in seasons) {
            Move move = season.GetComponent<Move> ();
            RandomMovement autoMove = season.GetComponent<RandomMovement> ();
            Action action = season.GetComponent<Action> ();
            move.enabled = false;
            autoMove.enabled = false;
            action.enabled = false;
        }
    }

    public void Restart () {
        DisableControls ();
        foreach (GameObject o in buttons) {
            o.active = true;
        }
        foreach (var season in seasons) {
            Action action = season.GetComponent<Action> ();
            action.Stop();
        }
    }

    void Enable (GameObject season) {
        Move move = season.GetComponent<Move> ();
        RandomMovement autoMove = season.GetComponent<RandomMovement> ();
        Action action = season.GetComponent<Action> ();
        move.enabled = true;
        action.enabled = true;
        autoMove.enabled = false;

    }

    void EnableAutomove () {
        foreach (var season in seasons) {
            RandomMovement autoMove = season.GetComponent<RandomMovement> ();
            autoMove.enabled = true;
        }
    }

    void ChooseSeason (GameObject season) {
        EnableAutomove ();
        Enable (season);
        CloseButtons ();
    }

    public void ChooseSummer () {
        ChooseSeason (summer);
    }

    public void ChooseWinter () {
        ChooseSeason (winter);
    }

    public void ChooseSpring () {
        ChooseSeason (spring);
    }

    public void ChooseAutumn () {
        ChooseSeason (autumn);
    }

    // Update is called once per frame
    void Update () {

    }
}