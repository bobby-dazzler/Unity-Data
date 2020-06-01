using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEventsFramework;

[CreateAssetMenu(menuName="Unity Data/States/File Manager State")]
public class FileManagerState : State {

	public FileDataRuntimeSet allSaveLoadFiles;

	public FileData activeSaveLoadFile;

}
