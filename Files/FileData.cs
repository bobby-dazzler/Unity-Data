using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

[CreateAssetMenu(menuName="Unity Data/File")]
public class FileData : ScriptableObject {

	public string folder;

	public string filename;

	public string GetFilePath () {
		string streamingFolder = Path.Combine(Application.streamingAssetsPath, folder);
		string filePath = Path.Combine(streamingFolder, filename);

		return filePath;
	}
}
