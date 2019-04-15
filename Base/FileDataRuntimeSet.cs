using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEventsFramework;

[CreateAssetMenu(menuName="Unity Data/Runtime Sets/File Data")]
public class FileDataRuntimeSet : RuntimeSet<FileData> {

	public FileData activeFile;

	public void SetActiveFile (int index) {
		activeFile = items[index];
	}

/* 	public void SetActiveLoadFile (int index) {
		activeLoadFile = items[index];
	} */
}
