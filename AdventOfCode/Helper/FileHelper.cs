namespace AdventOfCode.Helper;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

public static class FileHelper
{

    /*
		 *	Input File Format
		 *	i.e.	
		 *		101
		 *		102
		 *		103
		*/
    public static List<int> GetNumListFromFile(string resourcePath)
    {
        List<int> nums = new();

        using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourcePath))
        {
            using (StreamReader reader = new(stream))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    int res = int.Parse(line);
                    nums.Add(res);
                }
            }
        }

        return nums;
    }

    public static List<string> GetLinesFromFile(string resourcePath)
    {
        List<string> lines = new();

        using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourcePath))
        {
            using (StreamReader reader = new(stream))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    lines.Add(line);
                }
            }
        }

        return lines;
    }
}

