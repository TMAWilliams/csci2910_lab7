/**       
 *--------------------------------------------------------------------
 * 	   File name: FileRoot.cs
 * 	Project name: csci2910_lab7
 *--------------------------------------------------------------------
 * Author’s name and email:	 Tessa Williams williamstm5@etsu.edu				
 *          Course-Section: CSCI-2910-970
 *           Creation Date:	 07/03/2023		
 * -------------------------------------------------------------------
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csci2910_lab7
{
    //Code coppied from my submission for lab 4
    public class FileRoot
    {
        private string _rootOfProject;

        public string RootOfProject
        {
            get { return _rootOfProject; }
            init { _rootOfProject = value; }
        }

        /// <summary>
        /// Using the current directory, searches for the matching .sln file type.
        /// If not found, a loop searches the parent directory until the file is found.
        /// Sets this final path where the file was found as the root path for the project.
        /// </summary>
        public FileRoot()
        {
            bool found = false;
            string rootPath = "";
            rootPath = Directory.GetCurrentDirectory();
            while (!found)
            {
                string[] matchingFiles = Directory.GetFileSystemEntries(rootPath, "*.sln");
                if (matchingFiles.Count() != 0)
                {
                    found = true;
                }
                else
                {
                    rootPath = Directory.GetParent(rootPath).ToString();
                }
            }
            RootOfProject = rootPath;
        }
        /// <summary>
        /// Finds the file path of any file within the project root.
        /// </summary>
        /// <param name="fileName">string - relative path of file</param>
        /// <returns>string - combined path of project root and file path</returns>
        public string GetPath(string fileName)
        {
            string path = Path.Combine(RootOfProject, fileName);
            return path;
        }
    }
}
