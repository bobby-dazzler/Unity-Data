using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class UnityDataReader {

	BinaryReader reader;

	public UnityDataReader (BinaryReader reader) {
		this.reader = reader;
	}

	public float ReadFloat() {
		return reader.ReadSingle();
	}

	public string ReadString () {
		return reader.ReadString();
	}

	public int ReadInt() {
		return reader.ReadInt32();
	}

	public Quaternion ReadQuaternion () {
		Quaternion value;
		value.x = reader.ReadSingle();
		value.y = reader.ReadSingle();
		value.z = reader.ReadSingle();
		value.w = reader.ReadSingle();
		return value;
	}

	public Vector3 ReadVector3 () {
		Vector3 value;
		value.x = reader.ReadSingle();
		value.y = reader.ReadSingle();
		value.z = reader.ReadSingle();
		return value;
	}
}
