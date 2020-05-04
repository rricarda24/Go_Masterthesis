using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using System.IO;
using UnityEngine.SceneManagement;

namespace SimpleVAS
{
	public class CsvRead : MonoBehaviour {

		public string file;
		public static List<string> questionnaireInput  = new List<string>();


		// Use this for initialization
		void Awake () {

			if (SceneManager.GetActiveScene ().name == "BOQ") {
				if (ExperimentSettings.group == "Experimental") {
					if (ExperimentSettings.gender == "Female") file  = "questions_male";
					else file = "questions_female";
				}

				else  if (ExperimentSettings.group == "Control") {
					if (ExperimentSettings.gender == "Female")	file = "questions_female";
					else file = "questions_male";
				}
			}

			Load (file, questionnaireInput);
		}



		private bool Load(string fileName, List<string> arrayToTransferTo) {
			// Handle any problems that might arise when reading the text
			try {

				string line;

				// Create a new StreamReader, tell it which file to read and what encoding the file was saved as
				StreamReader csvFileReader = new StreamReader("./Lists/" + fileName + ".csv", Encoding.Default);

				/*/// Immediately clean up the reader after this block of code is done.
				You generally use the "using" statement for potentially memory-intensive objects
				instead of relying on garbage collection. (Do not confuse this with the using
				directive for namespace at the beginning of a class!) *////
				using (csvFileReader) {

					line = csvFileReader.ReadLine();

					if(line != null) {

						// While there's lines left in the text file, do this:
						do	{
							//  Do whatever you need to do with the text line, it's a string now.
							string[] entries = line.Split(',');

							if (entries.Length > 0){
								//Debug.Log(entries[0]);
								arrayToTransferTo.Add (entries[0]);
							}
							//DoStuff(entries);
							line = csvFileReader.ReadLine();

						}

						while (line != null);
					}

					// Done reading, close the reader and return true to broadcast success
					csvFileReader.Close();
					//Debug.Log("Read all that jass, like " + arrayToTransferTo[0]);
					return true;
				}
			}


			// If anything broke in the try block, we throw an exception with information on what didn't work
			catch (System.Exception e) {
				Debug.Log("{0}\n" + e.Message);
				return false;
			}
		}
	}
}
