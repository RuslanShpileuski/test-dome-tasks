/*
	This code is a practice C# interview question from https://www.testdome.com/d/c-sharp-interview-questions/18

	11. Folders

	Implement a function FolderNames, which accepts a string containing an XML file that specifies folder structure and returns all folder names that start with startingLetter. The XML format is given in the example below.

	For example, for the letter 'u' and XML file:

	<?xml version="1.0" encoding="UTF-8"?>
	<folder name="c">
		<folder name="program files">
			<folder name="uninstall information" />
		</folder>
		<folder name="users" />
	</folder>

	the function should return "uninstall information" and "users" (in any order).
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

[Serializable, XmlRoot("folder")]
public class Folder
{
	[XmlAttribute("name")]
	public string Name { get; set; }

	[XmlElement("folder")]
	public List<Folder> SubFolders { get; set; }

	public bool StartsWith(string startingString)
	{
		return Name.StartsWith(startingString);
	}

	public bool StartsWith(char startingChar)
	{
		return StartsWith(startingChar.ToString());
	}
}

public class Folders
{
	public static IEnumerable<string> FolderNames(string xml, char startingLetter)
	{
		var xmlSerializer = new XmlSerializer(typeof(Folder));
		var folders = (Folder)xmlSerializer.Deserialize(new StringReader(xml));

		var foldersMatchingCharacter = new List<string>();
		if (folders.StartsWith(startingLetter))
		{
			foldersMatchingCharacter.Add(folders.Name);
		}
		foldersMatchingCharacter.AddRange(folders.SubFolders.Where(x => x.StartsWith(startingLetter)).Select(x => x.Name));
		foldersMatchingCharacter.AddRange(folders.SubFolders.SelectMany(x => x.SubFolders).Where(x => x.StartsWith(startingLetter)).Select(x => x.Name));

		return foldersMatchingCharacter;
	}
}