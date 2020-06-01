using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class UnityDataWriter {

	BinaryWriter writer;

	public UnityDataWriter (BinaryWriter writer) {
		this.writer = writer;
	}

	public void Write (float value) {
		writer.Write(value);
	}

	public void Write (string value) {
		writer.Write(value);
	}

	public void Write (int value) {
		writer.Write(value);
	}

	public void Write (Quaternion value) {
		writer.Write(value.x);
		writer.Write(value.y);
		writer.Write(value.z);
		writer.Write(value.w);
	}
	
	public void Write (Vector3 value) {
		writer.Write(value.x);
		writer.Write(value.y);
		writer.Write(value.z);
	}

	public void Write (bool value) {
		writer.Write(value);
	}
}
