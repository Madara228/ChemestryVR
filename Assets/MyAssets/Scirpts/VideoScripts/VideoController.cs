using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoController : MonoBehaviour
{


	public string[] Urls;

	public bool[] VR;
	
	VideoPlayer _player;

	public GameObject Scene;

	public RenderTexture VRtexture;

	public Renderer videoMaterial;

	private bool _vrMode;

	public Material VRSkybox;

	public PlayerMovement PlayerMovement;
	
	
	private int currentVideo;

	void Start()
	{
		_player = GetComponent<VideoPlayer>();
		SetVideo(0);
	}

	public void SetVideo(int number)
	{
		if (VR[number])
		{
			RenderSettings.skybox = VRSkybox;
			_player.renderMode = VideoRenderMode.RenderTexture;
			_player.targetTexture = VRtexture;
			Scene.SetActive(false);
		}
		else
		{
			RenderSettings.skybox = null;
			_player.renderMode = VideoRenderMode.MaterialOverride;
			_player.targetMaterialRenderer = videoMaterial;
			Scene.SetActive(true);
		}
		_player.url = Urls[number];
		currentVideo = number;
	}

	public void PausePlay()
	{
		if (_player.isPlaying)
		{
			_player.Pause();
		}
		else
		{
			_player.Play();
		}
	}

	public void Prev()
	{
		if (currentVideo > 0)
		{
			SetVideo(--currentVideo);
		}
		
		
	}

	public void Next()
	{
		if (currentVideo < Urls.Length - 1)
		{
			SetVideo(++currentVideo);
		}
	}
}
