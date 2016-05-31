using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BackgroundMusicScript : MonoBehaviour {

    public AudioClip[] music;
    public AudioClip victory;
    public new AudioSource audio;
    public Text winText;
    int currentSong = 0;

	// Use this for initialization
	void Start () {
        audio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        if (WinGame() && !audio.clip.Equals(victory))
        {
            audio.clip = victory;
            audio.Play();
            Debug.Log("I got here");
        }
        if (!audio.isPlaying && !WinGame())
        {
            currentSong++;
            if (currentSong >= music.Length)
                currentSong = 0;
            audio.clip = music[currentSong];
            audio.Play();
         }
    }

    bool WinGame()
    {
        return winText.text.Equals("You won!");
    }
}
