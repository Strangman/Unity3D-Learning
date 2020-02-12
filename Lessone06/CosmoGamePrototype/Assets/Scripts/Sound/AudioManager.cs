using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum SoundFxType
{
	//Game sounds
	Shot,
	Hit,
	GetBonus,
	BonusAppear,
	SpaceShip,
	Explosion,

	//UI
	Click,
	OpenWindow,
	CloseWindow
}

public enum MusicType
{
	Level_1_Music,
	Level_2_Music,
}

public class AudioManager : MonoBehaviour
{
	[SerializeField] private List<AudioClipData> _audioClipDataList;
	[SerializeField] private List<MusicClipData> _musicClipDataList;
	[SerializeField] private AudioSource _soundFXSource;
	[SerializeField] private AudioSource _musicSource;

	private static AudioManager _intance;
	public static AudioManager Instance
	{
		get
		{
			if (_intance == null)
			{
				var go = new GameObject();
				go.name = "AudioManager";
				_intance = go.AddComponent<AudioManager>();
			}
			return _intance;
		}
	}
	public void PlaySoundFx(SoundFxType soundFxType)
	{
		var audioClipData = GetAudioClipData(soundFxType);
		_soundFXSource.PlayOneShot(audioClipData.Clip);
	}

	public void PlayMusic(MusicType musicType)
	{
		var musicClip = GetMusicClipData(musicType);
		_musicSource.clip = musicClip.Clip;
		_musicSource.Play();
	}

	private AudioClipData GetAudioClipData(SoundFxType soundFxType)
	{
		var data = _audioClipDataList.Find(clip => clip.Type == soundFxType);
		return data;
	}

	private MusicClipData GetMusicClipData(MusicType musicType)
	{
		var data = _musicClipDataList.Find(clip => clip.Type == musicType);
		return data;
	}

	private void Awake()
	{
		_intance = this;
	}

}

public enum AudioSourceType
{
	SoundFx,
	Music
}

[Serializable]
public class AudioSourceData
{
	public AudioSourceType Type;
	public AudioSource Source;
}

[Serializable]
public class AudioClipData
{
	public SoundFxType Type;
	public AudioClip Clip;
}

[Serializable]
public class MusicClipData
{
	public MusicType Type;
	public AudioClip Clip;
}
