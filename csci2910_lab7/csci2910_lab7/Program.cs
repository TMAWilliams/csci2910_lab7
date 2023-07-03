/**       
 *--------------------------------------------------------------------
 * 	   File name: Program.cs
 * 	Project name: csci2910_lab7
 *--------------------------------------------------------------------
 * Author’s name and email:	 Tessa Williams williamstm5@etsu.edu				
 *          Course-Section: CSCI-2910-970
 *           Creation Date:	 07/03/2023		
 * -------------------------------------------------------------------
 */
using System.Text.Json;
namespace csci2910_lab7
{
    public class Program
    {
        static void Main()
        {
            JsonSerializerOptions options = new() { WriteIndented = true, PropertyNameCaseInsensitive = true };
            FileRoot projectRoot = new FileRoot();

            //retrieve_specific_book.json to .csv
            string filePath = projectRoot.GetPath("retrieve_specific_book.json");
            string newFilePath = projectRoot.GetPath("retrieve_specific_book.csv");
            string jsonString = File.ReadAllText(filePath);
            Book book = JsonSerializer.Deserialize<Book>(jsonString, options);
            using (StreamWriter writer = new StreamWriter(newFilePath))
            {
                writer.WriteLine("title,subtitle,authors,publisher,published date");
                writer.WriteLine(book.VolumeInfo.ToString());
            }

            //search_title_author.json to .csv
            filePath = projectRoot.GetPath("search_title_author.json");
            newFilePath = projectRoot.GetPath("search_title_author.csv");
            jsonString = File.ReadAllText(filePath);
            SearchResult result = JsonSerializer.Deserialize<SearchResult>(jsonString, options);
            using (StreamWriter writer2 = new StreamWriter(newFilePath))
            {
                writer2.WriteLine("title,subtitle,authors,publisher,published date");
                for (int i = 0; i < result.Items.Length; i++)
                {
                    writer2.WriteLine(result.Items[i].VolumeInfo.ToString());
                }
            }

            //retrieve_specific_public_bookshelf.json to .csv
            filePath = projectRoot.GetPath("retrieve_specific_public_bookshelf.json");
            newFilePath = projectRoot.GetPath("retrieve_specific_public_bookshelf.csv");
            jsonString = File.ReadAllText(filePath);
            Bookshelf bookshelf = JsonSerializer.Deserialize<Bookshelf>(jsonString, options);
            using (StreamWriter writer3 = new StreamWriter(newFilePath))
            {
                writer3.WriteLine("id,title,description,created,volume count");
                writer3.WriteLine(bookshelf.ToString());
            }

            //retrieve_user_public_bookshelf.json to .csv
            filePath = projectRoot.GetPath("retrieve_user_public_bookshelves.json");
            newFilePath = projectRoot.GetPath("retrieve_user_public_bookshelves.csv");
            jsonString = File.ReadAllText(filePath);
            User user = JsonSerializer.Deserialize<User>(jsonString, options);
            using (StreamWriter writer4 = new StreamWriter(newFilePath))
            {
                writer4.WriteLine("id,title,description,created,volume count");
                for (int i = 0; i < user.Items.Length; i++)
                {
                    writer4.WriteLine(user.Items[i].ToString());
                }
            }

            //retrieve_volumes_user_bookshelf.json to .csv
            filePath = projectRoot.GetPath("retrieve_volumes_user_bookshelf.json");
            newFilePath = projectRoot.GetPath("retrieve_volumes_user_bookshelf.csv");
            jsonString = File.ReadAllText(filePath);
            bookshelf = JsonSerializer.Deserialize<Bookshelf>(jsonString, options);
            using (StreamWriter writer5 = new StreamWriter(newFilePath))
            {
                writer5.WriteLine("title,subtitle,authors,publisher,published date");
                for (int i = 0; i < bookshelf.Items.Length; i++)
                {
                    writer5.WriteLine(bookshelf.Items[i].VolumeInfo.ToString());
                }
            }
        }
    }
}