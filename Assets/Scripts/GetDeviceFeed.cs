using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetDeviceFeed : MonoBehaviour {
	[Header("Captured Data")]
	public byte[] recievedData;
	public Texture2D capturedTex;


	[Header("Screen Data Output")]
	public Text connectionStatusText;
	public RawImage deviceFeedView;

	void Start() {
		
	}

	// Update is called once per frame
	void Update() {
		CheckConnection();
	}

	public void SetTextureToImage(Texture recieved) {
		deviceFeedView.texture = recieved;
	}

	public void CheckConnection() {
		if(FMNetworkManager.instance.Server.IsConnected) {
			connectionStatusText.text = "Connected to device";
		} else {
			connectionStatusText.text = "Not Connected";
		}
	}
}